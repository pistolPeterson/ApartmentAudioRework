using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private bool checkDialogue1 = false;
    private string Dialogue1 = "Sigh The ticking of the clock always seemed to calmed me down";
   // private string Dialogue1A = "Yes I listen intensely to clocks, oh thats not a normal thing to do? ";/*To be played as well, randomly */

    private bool checkDialogue2 = false ;
    private string Dialogue2 = "Is it just me or is the ticking starting to get louder?";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //check the naming format, make sure each number is in the proper area when copy and pasting 
    public bool getDialogue1State()
    {
        return checkDialogue1;
    }
   public void changeDialogue1State()
    {
        checkDialogue1 = true;
        
    }
   public void playDialogue1()
    {
        //event will be played here 
        Debug.Log(Dialogue1);
    }


    public bool getDialogue2State()
    {
        return checkDialogue2;
    }
    public void changeDialogue2State()
    {
        checkDialogue2 = true;

    }
    public void playDialogue2()
    {
        //event will be played here 
        Debug.Log(Dialogue2);
    }




}
