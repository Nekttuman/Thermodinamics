using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSphere : MonoBehaviour
{
    Animator ANIM;
    private void Start()
    {
        ANIM = GetComponent<Animator>();
            
    }
    public void PlayForward()
    {
        ANIM.SetFloat("Offset",ANIM.GetFloat("Offset")+0.05f);
    }
    public void PlayBackward()
    {
        ANIM.SetFloat("Offset", ANIM.GetFloat("Offset") - 0.05f);
    }
}
