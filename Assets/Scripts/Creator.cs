using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Creator : MonoBehaviour
{
    public GameObject thePrefab;
    // Start is called before the first frame update
    void Start()
    {
        GameObject instance = new GameObject();
        instance = Instantiate(thePrefab,
                               transform.position,
                               transform.rotation) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
