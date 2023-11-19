using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class test : MonoBehaviour
{
    public TMP_Text inputField;
    private int _number;
    

    public void InputYazdir()
    {
        Debug.Log("bisiler yazdiiiiiii   "+ inputField.text);
        int.TryParse(inputField.text, out var num);
        _number = num;
        Debug.Log(_number);
    }

    void Update()
    {
        // Eğer "Enter" tuşuna basıldıysa
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            // Konsola bir mesaj yazdır
            Debug.Log("Enter tuşuna basıldı!");
            InputYazdir();
        }
    }
}