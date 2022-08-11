using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] int point;
    public static ScoreManager instantiate;

    int score;
    private void Awake()
    {
        instantiate = this;
    }

    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public  void ScoreIncrement()
    {
        score += point;
        scoreText.text = score.ToString();
    }

}
