using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Squad_shange : MonoBehaviour
{
    public Slider S;
    public float koef;
    Vector3 startScale;
    Vector3 startPosition;
    void Start()
    {
        startScale = transform.localScale;
        startPosition = transform.localPosition;
    }

    // Update is called once per frame
    public void SquadChange()
    {
        transform.localScale = startScale + new Vector3(S.value,-S.value * koef, S.value);
        transform.localPosition = startPosition + new Vector3(S.value, 0, 0);
    }
}
