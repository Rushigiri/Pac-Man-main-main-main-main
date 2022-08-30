using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManagement : MonoBehaviour
{
    public static ScoreManagement instance;
    public TextMeshProUGUI text;
    public int score;
    public TextMeshProUGUI levelComText;
    public TextMeshProUGUI gameOverText;

    private void Awake()
    {
        
            instance = this;
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void simpleCoinScore(int totalScore)
    {
        score += totalScore;
        gameOverText.text = score.ToString();
        levelComText.text = score.ToString();
        text.text = score.ToString();
    }

    public int GetTotalScore()
    {
        return score;
    }
}
