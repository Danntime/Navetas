using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SignSC : MonoBehaviour
{
    public string textToDisplay;
    private GameObject test;
       
    private void Awake()
    {
        test = GameObject.Find("TextBoxSprite");
        test.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        test.GetComponent<Image>().enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        test.transform.Find("TextObjet").GetComponent<TextMeshProUGUI>().enabled = true;
        test.GetComponent<Image>().enabled =true;
        test.GetComponent<TextBoxSC>().text = textToDisplay;


    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        test.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        test.GetComponent<Image>().enabled = false;
    }
}
