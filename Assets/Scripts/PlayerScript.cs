using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private float elapsed = 0f; //used for time-based score
    public int score = 0;
    public TMPro.TextMeshProUGUI scoreText;
    public TMPro.TextMeshProUGUI livesText;
    public int lives = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //add 100 points every second
        elapsed += Time.deltaTime;
        if (elapsed >= 1f)
        {
            score += 100;
            elapsed = 0;
        }

        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;

        if (lives <= 0)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        int finalScore = score;
        PlayerPrefs.SetInt("finalScore", finalScore);
        SceneManager.LoadScene("GameOver");
    }
}
