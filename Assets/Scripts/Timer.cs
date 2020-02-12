using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float myTimer = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myTimer > 0)
        {
            myTimer -= Time.deltaTime;
        }
        else if (myTimer <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }
}
