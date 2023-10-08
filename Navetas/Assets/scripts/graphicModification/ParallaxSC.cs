using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxSC : MonoBehaviour
{
    private float length;
    private float startpos;
    public float parallaxEffect;
    public GameObject cam;
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
    }
}
