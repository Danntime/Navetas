using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpacityMidSC : MonoBehaviour
{
    private void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, .5f);
    }
}
