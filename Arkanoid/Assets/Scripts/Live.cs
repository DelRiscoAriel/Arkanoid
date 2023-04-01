using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Live : MonoBehaviour
{
    public Text show;
    int lives = 3;
    public GameObject loseText;

    void Update()
    {
        show.text = ("Live: " + lives);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        lives = lives - 1;
        if (lives == 0)
        {
            //Time.timeScale = 0;
            UI.StopTime();
            UI.lose = true;
            loseText.SetActive(true);
        }
            //SceneManager.LoadScene("SampleScene");
        //Application.Quit();
    }
}
