using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_text : MonoBehaviour
{
    public GameObject t;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(t.GetComponent<TextAlignment>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
