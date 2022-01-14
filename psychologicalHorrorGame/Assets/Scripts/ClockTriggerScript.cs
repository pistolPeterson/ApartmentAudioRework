using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockTriggerScript : MonoBehaviour
{
    

    AudioStateManager asm;
    DialogueManager dm; 


    private float timer = 0.0f;
    private float waitTimeDialogue = 3.0f;
    private float waitTimeMusic = 4.0f;


   
    

    // Start is called before the first frame update
    void Start()
    {
        asm = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioStateManager>();
        dm = GameObject.FindGameObjectWithTag("Player").GetComponent<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {

       // Debug.Log(timer);
    }


    void OnTriggerStay(Collider other)
    {
       
        timer += Time.deltaTime;
       // Debug.Log(timer);
        if (other.CompareTag("Player")) //If player is in clock trigger zone 
        {
            if((timer > waitTimeDialogue) && (dm.getDialogue1State() == false) && (asm.getCreepyState() == false)) 
            {
              
                dm.playDialogue1();
               
            }
            //Debug.Log(timer);
            if ((timer > waitTimeDialogue) && (dm.getDialogue2State() == false)  && (asm.getCreepyState() == true)) 
            {
               
                dm.playDialogue2();

            }




        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            timer = 0; //reset timer
    }


}
