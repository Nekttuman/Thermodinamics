using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterLevel : MonoBehaviour
{
    public float value = 0f;
    public Renderer sh;

    void Start()
    {
        sh.material.SetFloat("_FillAmount", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (value < 0)
        {
            sh.material.SetFloat("_FillAmount",0);
            Debug.LogError("VALUE ERROR");
        }
        else if (value > 250)
        {
            sh.material.SetFloat("_FillAmount", -4);
        }
        else
        {
            float v = value * -0.0128f + 0.4f;
            sh.material.SetFloat("_FillAmount", v);
        }
        

    }
}
