using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class OpenTrivia : MonoBehaviour
{
    public GameObject triviaScreen;
    public TextMeshProUGUI TextQuestionPro;
    public TextMeshProUGUI TextOptionA;
    public TextMeshProUGUI TextOptionB;
    public TextMeshProUGUI TextOptionC;
    public TextMeshProUGUI TextOptionD;
    //public string Question;
    //public string[] Answer;
    public int a;
    public int b;
    public int d;
    public int CorrectAnswer;
    public bool aproved;
    public bool triviaIsOpen;
    public GameObject[] options;
    //public bool Trivia
    // Start is called before the first frame update
    //public List<Questions> QnA;
    public bool already;
    public string[] questions;

    public string[] answer;
    public string[] randomAnswers;
    public int currentRandom;
    public int lastRandom;
    public int currentRandomAnswer;
    public int currentQuestion;


    public EnemyMove enemyMove;

    public int index;

    void Start()
    {
        triviaScreen.SetActive(false);
        triviaIsOpen = false;
        already = false;
        if (triviaIsOpen)
        {
            //TextQuestionPro.text = string.Empty;
            //generateQuestion();
            //StartDialogue();
        }
        //TriviaIs(false);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            enemyMove.canMove = false;
            //instanc = other.gameObject;
            Open();
            //isActive = false;






        }


    }

    // Update is called once per frame
    void Update()
    {
        if (triviaIsOpen && !already)
        {
            generateQuestion();
            already = true;

            //TextQuestionPro.text = questions[0];
            //TextOptionA.text = answer[1];
            TextOptionA.text = "a la vivora vivora de la mar";
            TextOptionB.text = "el silencio";
            TextOptionD.text = "por el clima";
            //Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.A) && triviaIsOpen)
        {
            BadAnswer();
        }
        if (Input.GetKeyDown(KeyCode.B) && triviaIsOpen)
        {
            BadAnswer();
        }
        if (Input.GetKeyDown(KeyCode.C) && triviaIsOpen)
        {
            Correct();
        }
        if (Input.GetKeyDown(KeyCode.D) && triviaIsOpen)
        {
            BadAnswer();
        }


    }
    public void Open()
    {
        triviaScreen.SetActive(true);
        triviaIsOpen = true;

        //Time.timeScale = 0;
        //isPaused = true;
    }
    public void ResumeTrivia()
    {
        triviaScreen.SetActive(false);
        triviaIsOpen = false;

        //Time.timeScale = 1;
    }

    /* public void StartDialogue()
     {
         index = 0;
         StartCoroutine(WriteLine());
     }
     IEnumerator WriteLine()
     {
         foreach (char letter in lines[index].ToCharArray())
         {
             TextQuestionPro.text += letter;
             yield return new WaitForSeconds(textSpeed);
         }
     }*/
    void generateQuestion()
    {



        currentQuestion = Random.Range(0, questions.Length);
        //QuestionTxt.text = QnA[currentQuestion].Question;
        TextQuestionPro.text = questions[currentQuestion];
        TextOptionC.text = answer[currentQuestion];





        //SetAnswers();


    }
    void Correct()
    {
        SceneManager.LoadScene("Credits");
    }
    void BadAnswer()
    {

    }

}

