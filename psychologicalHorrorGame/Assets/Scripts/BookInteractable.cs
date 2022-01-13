using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookInteractable : Interactable
{
    //make sure layer is interactable as well
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override void OnInteract()
    {
        print("Interacted with " + gameObject.name );
       
        



    }
    public override void OnFocus()
    {
        print("LOOKING AT " + gameObject.name);

    }
    public override void OnLoseFocus()
    {
        print("STOPPED LOOKING AT " + gameObject.name);

    }
}
