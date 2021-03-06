using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{
    public Stats player;
    
    private List<string> sceneHistory = new List<string>();  
    
 
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);  
    }
 
    
    public void LoadScene(string newScene)
    {
        sceneHistory.Add(newScene);
        SceneManager.LoadScene(newScene);
    }
 
    
    public bool PreviousScene()
    {
        bool returnValue = false;
        if (sceneHistory.Count >= 2)  
        {
            returnValue = true;
            sceneHistory.RemoveAt(sceneHistory.Count -1);
            SceneManager.LoadScene(sceneHistory[sceneHistory.Count -1]);
        }
 
        return returnValue;
    }


    public void NewGame()
    {
        player.SavePlayer();
        SceneManager.LoadScene("StartingArea");
    }

    public void Load()
    {
        player.LoadPlayer();
        SceneManager.LoadScene("StartingArea");
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}