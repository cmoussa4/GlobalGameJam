using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource source;
    public AudioClip audioClip;
    public void Quit()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        source.PlayOneShot(audioClip);
        StartCoroutine(BackToMenuLoad());
    }
    public void LevelSelect()
    {
        source.PlayOneShot(audioClip);
        StartCoroutine(LevelSelectLoad());
        
    }



    public void OnLevelComplete(int ticksGained)
    {
        if(LevelSelectMenu.currentLevel == LevelSelectMenu.unlockedLevels)
        {
            LevelSelectMenu.unlockedLevels++;
            PlayerPrefs.SetInt("unlockedLevels", LevelSelectMenu.unlockedLevels);
        }
        if(ticksGained > PlayerPrefs.GetInt("ticks" + LevelSelectMenu.currentLevel.ToString(), 0))
        {
            PlayerPrefs.SetInt("ticks" + LevelSelectMenu.currentLevel.ToString(), ticksGained);
        }
        
        SceneManager.LoadScene(0);
    }

    private IEnumerator LevelSelectLoad()
    {
        yield return new WaitForSeconds(audioClip.length);
        SceneManager.LoadScene(1);
    }

    private IEnumerator BackToMenuLoad()
    {
        yield return new WaitForSeconds(audioClip.length);
        SceneManager.LoadScene(0);
    }
}
