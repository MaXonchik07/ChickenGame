using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chickenAppear : MonoBehaviour
{
    public GameObject[] chickenPrefabs; 
    public GameObject[] buttonPrefabs;  
    public Transform chickenParent;  
    public Transform buttonParent;  
    public Transform[] spawnPoints;
    public int countOfChicken;
    void Start()
    {
        SpawnAllChickens();
    }
    
    void SpawnAllChickens()
    {
        for (int i = 0; i < countOfChicken; i++)
        {
            GameObject chicken = Instantiate(chickenPrefabs[i], spawnPoints[i].position, i%2==0 ? Quaternion.identity:Quaternion.Euler(180, 0, 0),chickenParent);
            chicken.GetComponent<Rigidbody2D>().gravityScale = i%2==0 ? 5 : -5;
            GameObject button = Instantiate(buttonPrefabs[i], buttonParent);
            button.GetComponent<Button>().onClick.AddListener(() => chicken.GetComponent<run>().jumpButton());
        }
    }
}
