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

    private bool checkDialogue3 = false ;
    private string Dialogue3 = "I should have just bought netflix";

    private bool checkDialogue4 = false;
    private string Dialogue4 = "*sarcastically* hmmm, maybe if I open it again for 356th time, it will work… I suck at sarcasm";

    private bool checkDialogue5 = false;
    private string Dialogue5 = "Why doesn't this sound as calm as my clock?" ;

   



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
   
   public void playDialogue1()
    {
        //event will be played here 
        checkDialogue1 = true;
        Debug.Log(Dialogue1);
    }


    public bool getDialogue2State()
    {
        return checkDialogue2;
    }
    
    public void playDialogue2()
    {
         
        checkDialogue2 = true;
        Debug.Log(Dialogue2);
    }

    public bool getDialogue3State()
    {
        return checkDialogue3;
    }

    public void playDialogue3()
    {
        
        checkDialogue3 = true;
        Debug.Log(Dialogue3);
    }

    public bool getDialogue4State()
    {
        return checkDialogue4;
    }

    public void playDialogue4()
    {

        checkDialogue4 = true;
        Debug.Log(Dialogue4);
    }

    public bool getDialogue5State()
    {
        return checkDialogue5;
    }

    public void playDialogue5()
    {

        checkDialogue5 = true;
        Debug.Log(Dialogue5);
    }



}
