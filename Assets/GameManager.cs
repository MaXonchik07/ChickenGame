using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int playerCount;        
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);  
    }
    public void SetPlayerCount(int c)
    {
        playerCount = c;
        Debug.Log($"Игроков установлено {playerCount}");
    }
}
