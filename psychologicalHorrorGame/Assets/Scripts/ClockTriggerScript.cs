using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTriggerScript : MonoBehaviour
{
    private bool checkDialogue1 = false;


    private float timer = 0.0f;
    private float waitTimeDialogue = 3.0f;
    private float waitTimeMusic = 4.0f;


    private string Dialogue1 = "well todays the big day.I hope Dr.K is a good shrink.I should get the books he recommended me to read"; 
    //make two seperate strings to check for game state? 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
      
    }


    void OnTriggerStay(Collider other)
    {
        timer += Time.deltaTime;
        if (other.CompareTag("Player"))
        {
            if((timer > waitTimeDialogue) && (checkDialogue1 == false))
            {
                checkDialogue1 = true;
                Debug.Log("Time passed in trigger is " + timer);
            }
           
        }
    }

}
