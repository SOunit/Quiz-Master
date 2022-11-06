using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    float timeToCompleteQuestion = 30f;

    [SerializeField]
    float timeToShowCorrectAnswer = 10f;

    public bool isAnsweringQuestion = false;

    float timerValue;

    void Update()
    {
        updateTimer();
    }

    void updateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timerValue <= 0)
            {
                timerValue = timeToShowCorrectAnswer;
                isAnsweringQuestion = false;
            }
        }
        else
        {
            if (timerValue <= 0)
            {
                timerValue = timeToCompleteQuestion;
                isAnsweringQuestion = true;
            }
        }
    }
}
