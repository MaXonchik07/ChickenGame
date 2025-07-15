using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSceneLoad : MonoBehaviour
{
    public void Load1Level()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void Load2Level()
    {
        SceneManager.LoadScene("LevelDesert");         
    }
}
