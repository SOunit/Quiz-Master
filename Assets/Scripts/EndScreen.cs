using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI finalScoreText;

    ScoreKeeper scoreKeeper;

    // Start is cal%led before the first frame update
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text =
            "Congratulations!\nYou got a score of " +
            scoreKeeper.CalculateScore() +
            "%";
    }
}
