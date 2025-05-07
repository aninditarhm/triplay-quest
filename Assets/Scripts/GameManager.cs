using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int lives = 3;
    public int score = 0;
    public Text scoreText;
    public Text livesText;
    public Text timerText;
    public float timer = 60f;
    public GameObject gameOverPanel;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        // Timer countdown
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.text = " " + Mathf.Round(timer);
        }
        else
        {
            GameOver();
        }

        // Update UI untuk nyawa dan skor
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;
    }

    public void LoseLife()
    {
        lives--;
        if (lives <= 0)
        {
            GameOver();
        }
    }

    public void AddScore()
    {
        score++;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0; // Stop game
    }
}