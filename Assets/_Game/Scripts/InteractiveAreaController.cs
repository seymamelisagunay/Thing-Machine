using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveAreaController : MonoBehaviour
{
    //[HideInInspector] public bool isWorkingMachine;
    
    public GameObject ButtonE;
    public GameObject interactiveObject = null;
    public GameObject machine = null;

    public bool isWorking10Seconds;
    public bool rotateLeft;
    public bool rotateRight;
    public bool rotateFast;
    public bool rotateStop;
    public bool addGravity;
    
    [SerializeField] private AddGravity _addGravity = null;
    [SerializeField] private KinematicRotate _kinematicRotate = null;
    
    
    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.CompareTag("Player")) 
            ButtonE.gameObject.SetActive(true);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (addGravity)
                {
                    _addGravity.addGravityObject();
                }
                else if (isWorking10Seconds)
                {
                    _kinematicRotate.StartRotation(10,interactiveObject, 1, 1);
                }
                else if (rotateStop)
                {
                    _kinematicRotate.StopRotation(interactiveObject);
                    if (KinematicRotate.isWorkingMachine == -1)
                    {
                        KinematicRotate.SetmachineIsRotating(1);
                    }
                }
                
                DestroyArea();
            }
        }
        
    }
    

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            ButtonE.gameObject.SetActive(false);
        
    }

    private void DestroyArea()
    {
        Destroy(gameObject);
        ButtonE.gameObject.SetActive(false);
    }
}
