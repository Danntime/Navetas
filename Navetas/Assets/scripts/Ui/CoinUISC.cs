using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using System;

public class CoinUISC : MonoBehaviour
{
    public bool isCoinFound;
    public GameObject CoinSpriteUI;
    private GameObject ActiveCoin;
    public Image CoinImage;
    public Sprite coinSpriteNotFound;
    public Sprite coinSpriteFound;
    void Start()
    {
        isCoinFound = false;
        CoinImage = GetComponent<Image>();
        CoinImage.sprite = coinSpriteNotFound;
        ActiveCoin = GameObject.Find("CoinSC");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCoinFound == true)
        {
            CoinImage.sprite = coinSpriteFound;
        }
        else
        {
            CoinImage.sprite = coinSpriteNotFound;
        }
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        isCoinFound = false;
    }
}
