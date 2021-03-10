using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubScene_Unloader : MonoBehaviour
{
    public string thisScene;
    private void OnEnable()
    {
        Debug.Log("bye");
        FindObjectOfType<SceneSwitcher>().UnloadByName(thisScene);
    }
}
