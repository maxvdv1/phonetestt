using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    List<string> questions = new List<string>() { "Where are you? ", "answer1", "answer2", "answer3" };
  //  List<string> answers = new List<string>() { "answeras " };
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = questions[0];
        //GetComponent<TextMesh>().text = answers[0];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
