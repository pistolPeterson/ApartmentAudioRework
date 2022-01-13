using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string firstLevel;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Debug.Log("Starting Game");
        SceneManager.LoadScene(firstLevel);
    }

    public void OpenOptions()
    {
        Debug.Log("Attempting to open Game Options");
    }

    public void CloseOptions()
    {

    }
    public void QuitOptions()
    {
        Debug.Log("Attempting to quit game");
        Application.Quit();
    }
}
