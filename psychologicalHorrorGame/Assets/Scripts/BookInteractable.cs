using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInteractable : Interactable
{
    //this script is for the package

    public AK.Wwise.RTPC myBox;
    public AK.Wwise.State stateGang;

    AudioStateManager asm; 
    //make sure layer is interactable as well
    // Start is called before the first frame update
    void Start()
    {
        asm = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioStateManager>();
        myBox.SetGlobalValue(0);
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public override void OnInteract()
    {
        //change state mehtod here
        asm.changeCreepyState();

        myBox.SetGlobalValue(100);
        // print("Interacted with " + gameObject.name );

        gameObject.SetActive(false);

        stateGang.SetValue();

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
