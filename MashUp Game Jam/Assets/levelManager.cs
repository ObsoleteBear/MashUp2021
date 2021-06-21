using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    public Scene activeScene;
    public int activeSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        activeScene = SceneManager.GetActiveScene();
        activeSceneIndex = activeScene.buildIndex;
    }
    public void loadLevel()
    {
        if (activeSceneIndex == 0)
        {
            SceneManager.LoadScene(1);
        }
        if (activeSceneIndex == 1)
        {
            SceneManager.LoadScene(0);
        }
    }
}
