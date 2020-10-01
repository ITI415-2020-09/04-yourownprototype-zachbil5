using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI level, score, lives;
    public int livesCount = 3, levelNumber = 1;
    private int scoreCount = 0;
    void Awake()
    {
        level.text = "Level: " + levelNumber;
        score.text = "Score: " + 0;
        lives.text = "Lives: " + livesCount;
    }

    public void SetLevel(string nexLevel)
    {
        level.text = "Level: " + levelNumber++;
        SceneManager.LoadScene(nexLevel);
    }

    public void AddScore(int points)
    {
        scoreCount += points;
        score.text = "Score: " + scoreCount;
    }

    public void SetLives(int amount)
    {
        livesCount += amount;
        lives.text = "Lives: " + livesCount;
        if (livesCount <= 0)
        {
            //end game or go back to start
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
