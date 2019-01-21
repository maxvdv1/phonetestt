using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class toManage : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unAnsweredQuestions;

    private GameObject cube;


    //private Answer currentAnswers;
    private Question currentQuestion;

    [SerializeField]
    private Text factText;
    [SerializeField]
    private Text answerone;
    [SerializeField]
    private Text answertwo;
    [SerializeField]
    private Text answerthree;
    [SerializeField]
    private float timeBetweenQuestions = 1f;



    void Start()
    {
        if(unAnsweredQuestions == null || unAnsweredQuestions.Count == 0 )
        {
            unAnsweredQuestions = questions.ToList<Question>();
        }


       

    }
    public void GetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unAnsweredQuestions.Count);
        currentQuestion = unAnsweredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;

        answerone.text = currentQuestion.answerone;
        answertwo.text = currentQuestion.answertwo;
        answerthree.text = currentQuestion.answerthree;
        unAnsweredQuestions.RemoveAt(randomQuestionIndex);

    }
    IEnumerator TransitionToNextQuestion()
    {
        unAnsweredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestions);
        GetCurrentQuestion();

    }
    public void buttonOne()
    {
        if (currentQuestion.rightAnswer == "answerone")
        {
            Debug.Log("right answer");
        }else if(currentQuestion.rightAnswer == "answertwo")
        {
            Debug.Log("no");
        }
        else if(currentQuestion.rightAnswer == "answerthree")
        {
            Debug.Log("no");
        }
        //StartCoroutine(TransitionToNextQuestion());
    }
    public void buttonTwo()
    {

        if (currentQuestion.rightAnswer == "answerone")
        {
            Debug.Log("no");
        }
        else if (currentQuestion.rightAnswer == "answertwo")
        {
            Debug.Log("yeah");
        }
        else if (currentQuestion.rightAnswer == "answerthree")
        {
            Debug.Log("no");
        }
     //  StartCoroutine(TransitionToNextQuestion());

    }
    public void buttonThree()
    {

        if (currentQuestion.rightAnswer == "answerone")
        {
            Debug.Log("no");
        }
        else if (currentQuestion.rightAnswer == "answertwo")
        {
            Debug.Log("no");
        }
        else if (currentQuestion.rightAnswer == "answerthree")
        {
            Debug.Log("yeah");
        }
      // StartCoroutine(TransitionToNextQuestion());
    }

    private void OnTriggerEnter(Collider other)
     {
         if (gameObject.name == "messagepop")
         {
             Debug.Log("mogge");
            GetCurrentQuestion();
        }
     }
    


}
