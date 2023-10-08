using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovingSC : MonoBehaviour
{
    public float amp;
    public float freq;
    Vector3 initPos;

    private void Start()
    {
        initPos = transform.position;
    }

    private void Update()
    {
        Debug.Log(GameObject.Find("player").GetComponent<PlayerSC>().horizontal);
        transform.position = new Vector3(Mathf.Sin(Time.time * freq) * amp + initPos.x, initPos.y, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GameObject.Find("player").GetComponent<PlayerSC>().horizontal == 0)
        {
            collision.transform.SetParent(transform);
        }
        
        if (GameObject.Find("player").GetComponent<PlayerSC>().horizontal != 0)
        {
            collision.transform.SetParent(null);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
