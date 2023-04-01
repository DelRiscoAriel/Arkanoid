using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 150.0f;
    public float numberOfBlocks = 0;
    public GameObject winText;

    public Text totalBlocks,
        blocksBlue,
        blocksGreen,
        blocksPurple,
        blocksYellow,
        blocksRed;

    public int blocks = 0,
        blueBlocks = 0,
        greenBlock = 0,
        purpleBlock = 0,
        yellowBlock = 0,
        redBlock = 0;


    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    void Update()
    {
        totalBlocks.text = ("Total Blocks: " + blocks);
        blocksBlue.text = ("Blue Blocks: " + blueBlocks);
        blocksGreen.text = ("Green Blocks: " + greenBlock);
        blocksPurple.text = ("Purple Blocks: " + purpleBlock);
        blocksRed.text = ("Red Blocks: " + redBlock);
        blocksYellow.text = ("Yellow Blocks: " + yellowBlock);

        if (blocks == numberOfBlocks)
        {
            //Time.timeScale = 0;
            UI.StopTime();
            UI.lose = true;
            winText.SetActive(true);
        }
        else
            winText.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "BlueBlock")
        {
            blocks++;
            blueBlocks++;
        }
        if (col.gameObject.tag == "GreenBlock")
        {
            blocks++;
            greenBlock++;
        }
        if (col.gameObject.tag == "PurpleBlock")
        {
            blocks++;
            purpleBlock++;
        }
        if (col.gameObject.tag == "YellowBlock")
        {
            blocks++;
            yellowBlock++;
        }
        if (col.gameObject.tag == "RedBlock")
        {
            blocks++;
            redBlock++;
        }

        if (col.gameObject.name == "racket")
        {
            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

            Vector2 dir = new Vector2(x, 1).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
        {
            return (ballPos.x - racketPos.x) / racketWidth;
        }
    }
}
