using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOption : MonoBehaviour
{
    

    public void StartOption(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void SceneExit()
    {
        Application.Quit();
        Debug.Log("Exit");
    } 
}
