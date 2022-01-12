using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVInteractable : Interactable
{
    public Transform spawnpoint;
    public GameObject prefab;


    public override void OnInteract()
    {
        print("Interacted with " + gameObject.name + " Time to make a layer of white stuff appear");
        Instantiate(prefab, spawnpoint.position, spawnpoint.rotation);

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
