using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    int lastScene = 1;
    int scene;
    List<int> loadedScenes = new List<int>();

    private void Awake()
    {
        Load(1);
    }

    public void Load (int sceneBuildIndex)
    {
        if (!SceneManager.GetSceneByBuildIndex(sceneBuildIndex).isLoaded)
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Additive);
    }

    public void Unload(int sceneBuildIndex)
    {
        if (SceneManager.GetSceneByBuildIndex(sceneBuildIndex).isLoaded)
            SceneManager.UnloadSceneAsync(sceneBuildIndex);
    }

    public void UnloadByName(string sceneName)
    {
        if (SceneManager.GetSceneByName(sceneName).isLoaded)
            SceneManager.UnloadSceneAsync(sceneName);
    }

    public void RandomScene()
    {
        scene = Random.Range(3, SceneManager.sceneCountInBuildSettings);

        if (loadedScenes.Count == SceneManager.sceneCountInBuildSettings - 3)
        { 
            Unload(lastScene);
            Load(2);
        }
        else if (loadedScenes.Contains(scene))
        {
            RandomScene();
        }
        else
        {
            Unload(lastScene);

            Load(scene);

            loadedScenes.Add(scene);

            lastScene = scene;
        }
    }

    public void LoadRandom()
    {
        scene = Random.Range(3, SceneManager.sceneCountInBuildSettings);

        if (loadedScenes.Count == SceneManager.sceneCountInBuildSettings - 3)
        {
            Load(2);
        }
        else if (loadedScenes.Contains(scene))
        {
            LoadRandom();
        }
        else
        {
            Load(scene);

            loadedScenes.Add(scene);

            lastScene = scene;
        }
    }

    public void LoadLastScene()
    {
        Load(2);
    }

}