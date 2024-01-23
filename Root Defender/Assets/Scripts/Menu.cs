using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene(1);
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
}
