using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonManager : MonoBehaviour
{
    public Animator TransitionAnimator;
    public GameObject canvas;
    public GameObject pause;
    public bool isPaused;
    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
        canvas = GameObject.FindWithTag("Transition");
        TransitionAnimator = canvas.GetComponentInChildren<Animator>();
        pause = GameObject.FindWithTag("Pause");
        if (pause == null)
        {

        }
        else
        {
            pause.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToLevel()
    {
        FindObjectOfType<AudioManager>().Play("Select");
        TransitionAnimator.SetBool("LevelEnd", true);

    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit the game");
    }
    public void PanelSortingOrder()
    {
        canvas.GetComponent<Canvas>().sortingOrder = 1;
    }
    public void PanelSortingOrder2()
    {
        canvas.GetComponent<Canvas>().sortingOrder = 3;
    }
    public void Pause()
    {
        if (isPaused == true)
        {
            Time.timeScale = 1;
            pause.SetActive(false);
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            pause.SetActive(true);
            isPaused = true;
        }
    }
    public void unPause()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
    }
}
