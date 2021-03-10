using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubScene_Loader : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("hello");
        FindObjectOfType<SceneSwitcher>().LoadRandom();
    }
}
