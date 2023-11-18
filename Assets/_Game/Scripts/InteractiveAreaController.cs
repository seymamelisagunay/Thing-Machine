using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveAreaController : MonoBehaviour
{

    public GameObject ButtonE;
    
    [SerializeField] private AddGravity _addGravity = null;
    
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
                if (_addGravity != null)
                {
                    _addGravity.addGravityObject();
                    DestroyArea();
                }
                
                //buraya ekle
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
