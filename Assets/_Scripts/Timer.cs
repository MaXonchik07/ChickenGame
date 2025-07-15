using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI texTT;
    public GameObject Window;
    private IEnumerator timer()
    {
        texTT.text = "3";
        yield return new WaitForSeconds(1);
        texTT.text = "2";
        yield return new WaitForSeconds(1);
        texTT.text = "1";
        yield return new WaitForSeconds(1);
        Window.SetActive(false);
    }
    void Start()
    {
        StartCoroutine(timer());
    }
   
    void Update()
    {
        
    }
}
