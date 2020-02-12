using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject); //уничтожит объект, к которому привязан скрипт
        Destroy(GameObject.Find("Name"), 4); //Уничтожит объект с именем Name через 4 секунды
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
