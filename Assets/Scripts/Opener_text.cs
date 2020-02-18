using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opener_text : MonoBehaviour
{
    public GameObject panel;
    public void openConsp()
    {
        if (panel != null)
        {
            Animator animator = panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }
        }
    }
}
