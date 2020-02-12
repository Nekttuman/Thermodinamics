using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(5.0f, 0.0f, 0.0f); перемещает объект на вектор(x,y,z) относительно нач положения
    }

    // Update is called once per frame
    public float speed = 5.0f;
    void Update()
    {
        transform.Translate(new Vector3(0.0f, 0.0f, speed) * Time.deltaTime);
    }
}
