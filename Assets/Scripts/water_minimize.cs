using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class water_minimize : MonoBehaviour
{
    public ParticleSystem particleSys;
    public float evaporationSpeed = 0.5f;

    public Slider S;
    public Slider T;

    public void changeT()
    {
        evaporationSpeed += T.value;
        Debug.Log(T.value);
    }

    Vector3 psPosition,
            fluidScale;
    private void Start()
    {
        psPosition = particleSys.transform.localPosition;
        fluidScale = transform.localScale;
    }

    void Update()
    {
        
        if (transform.localScale.y > 0)
        {
            transform.localScale -= new Vector3(0.0f, evaporationSpeed, 0.0f) * Time.deltaTime; 
            particleSys.transform.Translate(new Vector3(0.0f, evaporationSpeed, 0.0f) * Time.deltaTime);
        }
        else
            particleSys.Stop();
    }

    public void repeat()
    {
        GetComponent<Squad_shange>().SquadChange();
        particleSys.transform.localPosition = psPosition;
    }
}
