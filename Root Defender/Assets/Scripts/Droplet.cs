using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droplet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(LevelSelectMenu.currentLevel == 0)
        {
            Destroy(this.gameObject, 4.0f);
        }
        if (LevelSelectMenu.currentLevel == 1)
        {
            Destroy(this.gameObject, 3.0f);
        }
        if (LevelSelectMenu.currentLevel == 2)
        {
            Destroy(this.gameObject, 2.0f);
        }
    }

    // Update is called once per frame

}
