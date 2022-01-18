using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVTriggerScript : MonoBehaviour
{

    AudioStateManager asm;
    DialogueManager dm;
    TVInteractable ti; 

    private float timer = 0.0f;
    private float waitTimeDialogue = 3.5f;
    //private float waitTimeMusic = 4.0f;





    // Start is called before the first frame update
    void Start()
    {
        asm = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioStateManager>();
        dm = GameObject.FindGameObjectWithTag("Player").GetComponent<DialogueManager>();
        ti = GameObject.FindGameObjectWithTag("TV").GetComponent<TVInteractable>();
    }

    // Update is called once per frame
    void Update()
    {

       
    }


    void OnTriggerStay(Collider other)
    {

        timer += Time.deltaTime;
        // Debug.Log(timer);
        if (other.CompareTag("Player")) //If player is in tv trigger zone 
        {

            if (ti.checkTvIsOn() == true) //checking if tv is on state
            {
                if ((timer > waitTimeDialogue) && (dm.getDialogue3State() == false) && (asm.getCreepyState() == false))
                {
                    dm.playDialogue3();
                  //  timer = 0;
                }

                if ((timer > waitTimeDialogue) && (dm.getDialogue5State() == false) && (asm.getCreepyState() == true))
                {
                    dm.playDialogue5();
                  //  timer = 0;
                }



            }
            else
            {
                if ((timer > waitTimeDialogue) && (dm.getDialogue4State() == false) && (asm.getCreepyState() == false))
                {
                    dm.playDialogue4();
                    timer = 0;
                }
            }

          




        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            timer = 0; //reset timer
    }
}
