using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    public TMP_Text inputField;
    
    private string _number;
    private bool check = false;
    public void FinishLevel()
    {
        switch (selectedTime)
        {
            case SceneTime.Future:
                if (KinematicRotate.isWorkingMachine == 1)
                {
                    DateCanvas.SetActive(true);
                    check = true;
                    if(_number == "19")
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
                    check = true;
                    if(_number == "11")
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
                    check = true;
                    if(_number == "23")
                        PlayerPrefs.SetInt("past23",1);
                }
                if (PlayerPrefs.GetInt("future19") == 1 && PlayerPrefs.GetInt("present11") == 1 &&
                    PlayerPrefs.GetInt("past23") == 1)
                {
                    //tum yazdigi sayilari tarih gibi goster ui
                    // sonra oyunu bitircek ui goster
                }
                else
                {
                    PlayerPrefs.SetInt("future19",0);
                    PlayerPrefs.SetInt("present11",0);
                    PlayerPrefs.SetInt("past23",0);
                }
                //ilk sahneye gec
                break;
            
            default:
                Debug.Log("Geçersiz");
                break;
        }
    }
    
    public int writeToUI()
    {
        if (inputField == null)
            return 0;
        int.TryParse(inputField.text, out var num);
        return num;

    }
    void Update()
    {
        if (check)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                Debug.Log("Enter tuşuna basıldı!");
                _number = inputField.text;
                check = false;
            }
        }
        
    }
}
