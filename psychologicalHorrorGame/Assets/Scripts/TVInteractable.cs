using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVInteractable : Interactable
{
    public Transform spawnpoint;
    public GameObject prefab;
    public bool tvIsOn = false;

    //TODO add a little bit of delay so user cant spam it 
    void Start()
    {
       
        prefab = Instantiate(prefab, spawnpoint.position, spawnpoint.rotation);
        //  prefab.SetActive(false);

       // prefab.SetActive(!prefab.activeSelf);
        //prefab.SetActive(!prefab.activeSelf);
    }

    public override void OnInteract()
    {
        print("Interacted with " + gameObject.name + " Time to make a layer of white stuff appear");
        prefab.SetActive(!prefab.activeSelf);
        if (tvIsOn == false)
        {
            Debug.Log("tv is turned on");
            prefab.SetActive(true);
            tvIsOn = true;
        } else
        {
            Debug.Log("tv is turned off");
            tvIsOn =false;
        }

     

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
