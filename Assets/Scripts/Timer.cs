using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    float timeToCompleteQuestion = 30f;

    [SerializeField]
    float timeToShowCorrectAnswer = 10f;

    //  public is not good approach but this game is small so use public here
    public bool loadNextQuestion;

    public bool isAnsweringQuestion = false;

    public float fillFraction;

    float timerValue;

    void Update()
    {
        updateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void updateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timerValue > 0)
            {
                // 0 / 10 = 0
                // 5 / 10 = 0.5
                // 10 / 10 = 1
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuestion = false;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                timerValue = timeToCompleteQuestion;
                isAnsweringQuestion = true;
                loadNextQuestion = true;
            }
        }

        Debug
            .Log(isAnsweringQuestion +
            " : " +
            timerValue +
            " : " +
            fillFraction);
    }
}
