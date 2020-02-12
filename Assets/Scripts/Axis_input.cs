using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis_input : MonoBehaviour
{
    private float horiz;
    private float vert;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horiz, vert, 0.0f));
    }
}
