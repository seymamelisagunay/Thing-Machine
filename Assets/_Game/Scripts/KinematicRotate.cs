using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KinematicRotate : MonoBehaviour
{
    public bool directionX;
    public bool directionY;
    public bool directionZ;
    public bool turn;
    public int workTime;

    private void Start()
    {
        TurnX();
    }

    public void TurnX()
    {
        transform.DORotate(Vector3.right, workTime, RotateMode.Fast);
    }
    
}
