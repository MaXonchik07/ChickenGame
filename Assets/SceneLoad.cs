using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{   
    public void Two()
    {
        GameManager.Instance.SetPlayerCount(2);
        SceneManager.LoadScene("LevelsOption");
    }
    public void Three()
    {
        GameManager.Instance.SetPlayerCount(3);
        SceneManager.LoadScene("LevelsOption");
    }
        public void Four()
    {
        GameManager.Instance.SetPlayerCount(4);   
        SceneManager.LoadScene("LevelsOption");
    }
}
