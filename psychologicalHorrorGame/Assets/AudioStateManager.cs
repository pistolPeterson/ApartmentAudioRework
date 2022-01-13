using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStateManager : MonoBehaviour
{
    public bool creepyState = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Creepy state is " + creepyState);
    }


    public void changeCreepyState()
    {
        creepyState = true;
    }

    public bool getCreepyState()
    {
        return creepyState;
    }
}
