using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseContr : MonoBehaviour
{
    public GameObject pauseOption;

    
        void Pause()
        {
            pauseOption.SetActive(true);
            Time.timeScale = 0f;
        }
        void Resume()
        {
            pauseOption.SetActive(false);
            Time.timeScale = 1f;
        }

    public void PauseUpd()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }
}
