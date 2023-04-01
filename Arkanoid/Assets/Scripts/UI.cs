using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    bool pause = false;
    public Text button;
    public static bool lose = false;

    void Start()
    {
        Time.timeScale = 1;
        lose = false;
    }

    void Update()
    {
        if (!lose)
        {
            if (pause)
            {
                Time.timeScale = 0;
                button.text = "Play";
            }
            else
            {
                Time.timeScale = 1;
                button.text = "Pause";
            }
        }                
    }

    public void PausePlay()
    {
        pause = !pause;
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public static void StopTime()
    {
        Time.timeScale = 0;
    }
}
