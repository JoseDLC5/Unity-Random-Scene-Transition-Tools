using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubScene_Switcher : MonoBehaviour
{
    public string thisScene;
    private void OnEnable()
    {
        Debug.Log("hello");
        FindObjectOfType<SceneSwitcher>().LoadRandom();
    }

    
    private void OnDisable()
    {
        Debug.Log("bye");
        FindObjectOfType<SceneSwitcher>().UnloadByName(thisScene);
    }
}