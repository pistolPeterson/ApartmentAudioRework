using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVInteractable : Interactable
{
    public Transform spawnpoint;
    public GameObject prefab;
    public bool tvIsOn = false;

    [Header("Wwise Events")]
    public AK.Wwise.Event playTV;
    public AK.Wwise.Event stopTV;

    //TODO add a little bit of delay so user cant spam it 
    void Start()
    {
        stopTV.Post(gameObject);
        prefab = Instantiate(prefab, spawnpoint.position, spawnpoint.rotation);
      
    }

    public override void OnInteract()
    {
        //print("Interacted with " + gameObject.name + " Time to make a layer of white stuff appear");
        prefab.SetActive(!prefab.activeSelf);
        if (tvIsOn == false)
        {
            // Debug.Log("tv is turned on");
            playTV.Post(gameObject); //turn on tv sound event 
            prefab.SetActive(true);
            tvIsOn = true;
        } else
        {
            //Debug.Log("tv is turned off");
            stopTV.Post(gameObject);//stop tv sound event 
            tvIsOn =false;
        }

     

    }
    public override void OnFocus()
    {
       // print("LOOKING AT " + gameObject.name);
        
    }
    public override void OnLoseFocus()
    {
       //print("STOPPED LOOKING AT " + gameObject.name);
       
    }


    public bool checkTvIsOn()
    {
        return tvIsOn;
    }

   

}
