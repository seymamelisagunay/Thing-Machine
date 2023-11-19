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
        SetmachineIsRotating(0);
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
        if (turnTool.CompareTag("clock"))
        {
            turnTool.transform.DOLocalRotate(toRotation, workTime, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetId("clockTween");
        }

        if (turnTool.CompareTag("machine"))
        {
            turnTool.transform.DOLocalRotate(toRotation, workTime, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetId("machineTween");
        }
     
    }

    public void StopRotationClock()
    {
        DOTween.Kill("clockTween");
    }
    public void StopRotationmachine()
    {
        DOTween.Kill("machineTween");
    }
    static public void SetmachineIsRotating(int newValue)
    {
        isWorkingMachine = newValue;
    }

}
