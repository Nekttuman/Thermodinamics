using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dianmometer_position : MonoBehaviour
{
    GameObject pointer;
    const float nullPosition = 4.83f;
    const float onePosition = -7.97f;

    const float minPosition = 5.43f;
    const float maxPosition = -8.22f;

    public float setPosition = 0f;

    float error = 0;
    
    void Start()
    {
        pointer = GameObject.Find("pointer");
        pointer.transform.localPosition = new Vector3(pointer.transform.localPosition.x, nullPosition, pointer.transform.localPosition.z);
        error = UnityEngine.Random.Range(0, 0.02f);
        Debug.Log(error);
    }

    // Update is called once per frame
    void Update()
    {
// Debug.Log(pointer.transform.localPosition.y);

        if (setPosition < 0)
        {
            pointer.transform.localPosition = new Vector3(pointer.transform.localPosition.x, minPosition, pointer.transform.localPosition.z);
            Debug.Log("Out of range < 0");
        }
        else if (setPosition > 1)
        {
            pointer.transform.localPosition = new Vector3(pointer.transform.localPosition.x, maxPosition, pointer.transform.localPosition.z);
            Debug.Log("Out of range > 1");
        }
        else
        {
            
            pointer.transform.localPosition = new Vector3(pointer.transform.localPosition.x, nullPosition - 1.28f * 10 * (setPosition + error), pointer.transform.localPosition.z);
        }


    }
}
