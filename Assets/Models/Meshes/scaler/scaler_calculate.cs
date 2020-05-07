using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.iOS;

public class scaler_calculate : MonoBehaviour
{
    public Renderer[] digits;

    public Material E;
    public Material R;

    public float value = 0f;

    public Material[] mat;
    void Start()
    {
        foreach(var temp in digits)
        {
            temp.material = mat[0];
        }
        
    }

  
    void Update()
    {
        digits[0].material = mat[1];
        value = Mathf.Round(value*100)/100f;
        if (value >= 1000f || value < 0)
        {
            Debug.LogError("INPUT ERROR OVERAGE");
            DisplayError();
        }

        //int val = (int)Mathf.Round(value * 100);
        else
        {
            for (int i = 0; i < 5; i++)
            {
                int val = (int)(value * 100);
                int ind = (val % (int)Math.Pow(10, i + 1)) / (int)Math.Pow(10, i);
                //Debug.Log();
                digits[i].material = mat[ind];
            }
        }
    }

    void DisplayError()
    {
        digits[0].material = R;
        digits[1].material = mat[0];
        digits[2].material = R;
        digits[3].material = R;
        digits[4].material = E;

    }
}
