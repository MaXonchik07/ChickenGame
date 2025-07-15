using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            WinnerManager win = GameObject.Find("levelMove").GetComponent<WinnerManager>();
            run namee = other.GetComponent<run>();
            win.ShowWinner(namee.ChickenName);
            win.WinnerMenuu.SetActive(true);
            win.StopGame();
            namee.ToDest();
        }
    }
}
