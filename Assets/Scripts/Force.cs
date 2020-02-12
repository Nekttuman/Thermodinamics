using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    // Start is called before the first frame update
    public float power = 500.0f;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 0.0f, power));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
