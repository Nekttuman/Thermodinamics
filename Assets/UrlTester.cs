using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class UrlTester : MonoBehaviour
{
    
    public void Targets()
    {
       // Help.BrowseURL("https://drive.google.com/drive/folders/1jKKVLRCxv5E-3vnko9oapndXl3IfJQ6Y?usp=sharing");
        Application.OpenURL("https://drive.google.com/drive/folders/1jKKVLRCxv5E-3vnko9oapndXl3IfJQ6Y?usp=sharing");
    }


}