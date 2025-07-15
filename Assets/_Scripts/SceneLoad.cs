using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void Two()
    {
        GameManager.Instance.SetPlayerCount(2);
        SceneManager.LoadScene("Levels");
    }
    public void Three()
    {
        GameManager.Instance.SetPlayerCount(3);
        SceneManager.LoadScene("Levels");
    }
    public void Four()
    {
        GameManager.Instance.SetPlayerCount(4);
        SceneManager.LoadScene("Levels");
    }
    public void Five()
    {
        GameManager.Instance.SetPlayerCount(5);
        SceneManager.LoadScene("Levels");
    }
    public void Six()
    {
        GameManager.Instance.SetPlayerCount(6);   
        SceneManager.LoadScene("Levels");
    }
}
