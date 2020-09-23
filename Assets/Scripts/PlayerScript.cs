using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float elapsed = 0f; //used for time-based score
    public int score = 0;
    public TMPro.TextMeshProUGUI scoreText;

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

        scoreText.text = "Score:\n " + score;
    }
}
