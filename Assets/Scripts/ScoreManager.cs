using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score { get; private set; }
    [SerializeField] TMP_Text displayCounter;
    [SerializeField] private float _snakeSpeed = 0.3f;

    void Start()
    {
        Time.fixedDeltaTime = _snakeSpeed;
    }

    public void IncreaseScore()
    {
        score++;
        ShowScore();
        _snakeSpeed-=0.005f;
        Time.fixedDeltaTime = _snakeSpeed;
    }

    public void ResetScore()
    {
        score = 0;
        ShowScore();
        _snakeSpeed = 0.3f;
        Time.fixedDeltaTime = _snakeSpeed;
    }

    private void ShowScore()
    {
        displayCounter.text = "Score: " + score;
    }
}
