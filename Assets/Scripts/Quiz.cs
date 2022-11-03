using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI questionText;

    [SerializeField]
    QuestionSO question;

    // Start is called before the first frame update
    void Start()
    {
        questionText.text = question.GetQuestion();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
