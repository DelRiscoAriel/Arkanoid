using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interface : MonoBehaviour
{
    public Text time;
    public int timeLeft = 180;
    public GameObject loseText;

    float minutes = 0f;
    float seconds = 0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        minutes = timeLeft / 60;
        seconds = timeLeft % 60;

        time.text = "Time Reamening: " + (int)minutes + "m : " + seconds + "s";//("Time Reamening: " + timeLeft);

        if (timeLeft == 0)
        {
            //Time.timeScale = 0;
            UI.StopTime();
            UI.lose = true;
            loseText.SetActive(true);
        }
            //SceneManager.LoadScene("SampleScene");
        //Application.Quit();
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
