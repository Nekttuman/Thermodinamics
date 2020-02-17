using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public Button CurrButton;
    public string sceneName;

    void Start()
    {
        Button btn = CurrButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Application.LoadLevel(sceneName);
    }
    public void ChangeOrientationToLandscape()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
    public void changeOrientationToPortrait()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }
    public void ChangeOrientationToAuto()
    {
        Screen.orientation = ScreenOrientation.AutoRotation;
    }
}
