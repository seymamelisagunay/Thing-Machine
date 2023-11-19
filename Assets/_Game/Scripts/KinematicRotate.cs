using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KinematicRotate : MonoBehaviour
{
    static public int isWorkingMachine = 0;
    
    public GameObject clockRotate = null;
    public GameObject machineRotate = null;
    
    public bool isClockFirstStart = false;

    private void Start()
    {
        if(isClockFirstStart)
            StartRotation(60, clockRotate, 1, 1);
    }
    
    /// <summary>
    /// Rotates the specified object at the desired speed and direction for a specified duration.
    /// </summary>
    /// /// <param name="speedX">speed coefficient</param>
    /// <param name="direction">to right = 1, to left = -1</param>
    public void StartRotation(int workTime, GameObject turnTool, int speedX, int direction) //direction to right = 1, left = -1
    {
        Vector3 fromRotation = turnTool.transform.localRotation.eulerAngles;
        Vector3 toRotation = fromRotation + new Vector3(0, direction * 360 * speedX, 0);
        turnTool.transform.DOLocalRotate(toRotation, workTime, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetId("ClockTween");
        
        if (turnTool.CompareTag("machine"))
            SetmachineIsRotating(-1);
    }

    public void StopRotation(GameObject stopTool)
    {
        if (stopTool == null) return;
        DOTween.Kill(stopTool);
    }
    static public void SetmachineIsRotating(int newValue)
    {
        isWorkingMachine = newValue;
    }

}
