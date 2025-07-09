using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chickenAppear : MonoBehaviour
{
    public GameObject[] chickenPrefabs;  // Префаб курицы
    public GameObject[] buttonPrefabs;   // Префаб кнопки (Image + Button)
    public Transform chickenParent;  // Куда спавнить куриц
    public Transform buttonParent;  // Куда размещать кнопки

    public Transform[] spawnPoints;

    // void Start()
    // {
    //     SpawnAllChickens();
    // }

    // void SpawnAllChickens()
    // {
    //     for (int i = 0; i < 6; i++)
    //     {
    //         GameObject chicken = Instantiate(chickenPrefabs[i], spawnPoints[i].position, i>=3 ? Quaternion.Euler(180, 0, 0):Quaternion.identity,chickenParent);
    //         chicken.GetComponent<Rigidbody2D>().gravityScale = i>=3 ? -1 : 1;
    //         GameObject button = Instantiate(buttonPrefabs[i], buttonParent);
    //         button.GetComponent<Button>().onClick.AddListener(() => chicken.GetComponent<run>().jumpButton());
    //     }
    // }
}
