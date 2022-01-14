using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInteractable : Interactable
{
    //this script is for the package

    AudioStateManager asm; 
    //make sure layer is interactable as well
    // Start is called before the first frame update
    void Start()
    {
        asm = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioStateManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public override void OnInteract()
    {
        //change state mehtod here
        asm.changeCreepyState();


       // print("Interacted with " + gameObject.name );

        gameObject.SetActive(false);

       

    }
    public override void OnFocus()
    {
      // print("LOOKING AT " + gameObject.name);

    }
    public override void OnLoseFocus()
    {
      //  print("STOPPED LOOKING AT " + gameObject.name);

    }
}
