using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public LevelObject[] levelObjects;
    public Sprite tickSprite;
    public static int currentLevel;
    public static int unlockedLevels;
    // Start is called before the first frame update
    public void Level(int LevelNum)
    {
        currentLevel = LevelNum;
        SceneManager.LoadScene(2);
    }

    private void Start()
    {
        //
        unlockedLevels = PlayerPrefs.GetInt("unlockedLevels", 0);
        for (int i = 0; i < levelObjects.Length; i++)
        {
            if(unlockedLevels>= i)
            {
                levelObjects[i].levelButton.interactable = true;
                int ticks = PlayerPrefs.GetInt("ticks" + i.ToString(), 0);
                for (int j = 0; j < ticks; j++)
                {
                    if(unlockedLevels >= i + 1)
                    {
                        levelObjects[i].ticks.sprite = tickSprite;
                    }
                    
                }
            }
        }
    }
}
