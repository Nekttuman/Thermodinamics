using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constant_screen_orientation : MonoBehaviour
{
    public bool PortraitOrientetion, LandScapeOrientation;
    void Start()
    {
        if (PortraitOrientetion && LandScapeOrientation)
        {
            Screen.orientation = ScreenOrientation.AutoRotation;
        }
        else if (PortraitOrientetion)
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
        else if (LandScapeOrientation)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
        else
        {
            Debug.LogError("Not set orientation");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
