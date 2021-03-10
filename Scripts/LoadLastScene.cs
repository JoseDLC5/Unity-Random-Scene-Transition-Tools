using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLastScene : MonoBehaviour
{
    private void OnEnable()
    {
        FindObjectOfType<SceneSwitcher>().LoadLastScene();
    }
}