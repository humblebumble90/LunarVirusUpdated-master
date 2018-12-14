using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    [Header("UI Settings")]
    public Text scoreText;
    public Text gameOverText;
    public Text restartText;
    public Text hpText;

    private int score;
    private int hp;
    private bool gameOver;
    private bool restart;




    // Use this for initialization
    void Start()
    {
        hp = 100;
        score = 0;
        gameOver = false;
        restart = false;
        UpdateScore();
        hpTextnumber();
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

    }

    // Update is called once per frame
    void Update()
    {

        // Check whether you are restarting
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            { 
             // Restart our game
                // THE OLD WAY. DON'T USE THIS.
                // Application.LoadLevel("Level1");
                // THE NEW WAY. USE THIS!
                // SceneManager.LoadScene("Level1");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
        }
        
        if (gameOver)
        {
            
            // Active the Restart UI text
            restartText.enabled = true;
            // (Optional) Set Restart UI text
            // restartText.text = "YOUR SUPER SECRET CUSTOM MESSAGE HERE";
            // Set restart boolean value to true
            restart = true;
            Debug.Log(restart);
        
        }
       


    }
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue; // score = score + newScoreValue
        // Debug.Log("Score: " + score);
        UpdateScore();
    }
    public void AddHp()
    {
        hp = hp + 30;
    }

    void hpTextnumber()
    {
        hpText.text = "Hp : " + hp;
    }
    public void hpNumber(int newHpValue2)
    {
        hp -= newHpValue2;
        hpTextnumber();
    }
    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
    public void GameOver()
    {
        // What happens when my game is over?
        gameOver = true;

        gameOverText.enabled = true;
       
    }
}
    


