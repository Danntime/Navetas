using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    private void OnLevelWasLoaded(int level)
    {
        isCoinFound = false;
    }
}
