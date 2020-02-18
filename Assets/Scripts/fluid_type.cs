using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fluid_type : MonoBehaviour
{
    public Material spirt;
    public Material water;
    public Material mercury;

    public ParticleSystem ps;

    public Slider S;
    public Slider T;

    public void Spirt()
    {
        T.minValue = 0.001f;
        T.maxValue = 1f;
        T.value = (T.maxValue + T.minValue) / 2;
        GetComponent<water_minimize>().evaporationSpeed = 1f;
        GetComponent<Renderer>().material = spirt;
        ps.GetComponent<Renderer>().material = spirt;
    }
    public void Water()
    {
        T.minValue = 0.001f;
        T.maxValue = 0.5f;
        T.value = (T.maxValue + T.minValue) / 2;
        GetComponent<water_minimize>().evaporationSpeed = 0.5f;
        GetComponent<Renderer>().material = water;
        ps.GetComponent<Renderer>().material = water;
    }
    public void Mercury()
    {
        T.minValue = 0.001f;
        T.maxValue = 0.2f;
        T.value = (T.maxValue + T.minValue) / 2;
        GetComponent<water_minimize>().evaporationSpeed = T.value;
        GetComponent<Renderer>().material = mercury;
        ps.GetComponent<Renderer>().material = mercury;
    }
    private void Update()
    {
        GetComponent<water_minimize>().evaporationSpeed = T.value;
        Debug.Log(ps.emission.rateOverTime);
    }
}
