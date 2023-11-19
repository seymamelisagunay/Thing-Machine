using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public enum SceneTime
    {
        Future,
        Present,
        Past
    }
    
    [SerializeField] private SceneTime selectedTime;
    public GameObject DateCanvas;
    private int _number;
    public void FinishLevel()
    {
        switch (selectedTime)
        {
            case SceneTime.Future:
                if (KinematicRotate.isWorkingMachine == 1)
                {
                    DateCanvas.SetActive(true);
                    //yazi yazcak kullanici entera bascak
                    if(_number == 19)
                        PlayerPrefs.SetInt("future19",1);
                    else
                        PlayerPrefs.SetInt("future19",0);
                }
                //diger sahneye gec
                break;
            
            case SceneTime.Present:
                if (KinematicRotate.isWorkingMachine == 1)
                {
                    DateCanvas.SetActive(true);
                    //yazi yazcak kullanici entera bascak
                    if(_number == 11)
                        PlayerPrefs.SetInt("present11",1);
                    else
                        PlayerPrefs.SetInt("present11",0);
                }
                //digersahneye gec
                break;
            
            case SceneTime.Past:
                if (KinematicRotate.isWorkingMachine == 1)
                {
                    DateCanvas.SetActive(true);
                    //yazi yazcak kullanici entera bascak
                    if(_number == 23)
                        PlayerPrefs.SetInt("past23",1);
                }
                if (PlayerPrefs.GetInt("future19") == 1 && PlayerPrefs.GetInt("present11") == 1 &&
                    PlayerPrefs.GetInt("past23") == 1)
                {
                    //oyun bitti bitti sahnesini ac
                }
                else
                {
                    PlayerPrefs.SetInt("future19",0);
                    PlayerPrefs.SetInt("present11",0);
                    PlayerPrefs.SetInt("past23",0);
                }
                //digersahneye gec
                break;
            
            default:
                Debug.Log("Geçersiz");
                break;
        }
    }
}
