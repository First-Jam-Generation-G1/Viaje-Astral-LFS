using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    public Quiz quizManager;
    public void Answ()
    {
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Worng Answer");
        }
    }
    // Start is called before the first frame update

}
