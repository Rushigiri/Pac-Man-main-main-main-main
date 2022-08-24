using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManagement : MonoBehaviour
{
    public static ScoreManagement instance;
    public TextMeshProUGUI text;
    int score;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void simpleCoinScore(int totalScore)
    {
        score += totalScore;
        text.text = score.ToString();
    }
}
