using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    [SerializeField] GameObject pauseMenu;
    Player player;

    // Update is called once per frame

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        Restart();
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        gamePaused = false;
        pauseMenu.SetActive(false);
        if(player!= null)
        {
            player.GetComponent<AudioSource>().Play();
        }
        
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        gamePaused = true;
        pauseMenu.SetActive(true);
        if(player!= null)
        {
            player.GetComponent<AudioSource>().Pause();
        }
        
       
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1f;
        }
        
    }
}
