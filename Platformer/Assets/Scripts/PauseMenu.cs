using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private Shooting shooter;
    private bool isPaused;

    private void Start()
    {
        isPaused = false;
    }

    void Update()
    {
        if (shooter == null)
        {
            shooter = GameObject.FindObjectOfType<Shooting>();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        shooter.enabled = true;
        isPaused = false;
    }

    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        shooter.enabled = false;
        isPaused = true;
    }

}
