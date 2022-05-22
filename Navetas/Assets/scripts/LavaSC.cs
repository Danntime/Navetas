using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaSC : MonoBehaviour
{
    public bool isGrowing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isGrowing)
        {
            Vector3 localScale = transform.localScale;
            localScale.y += 0.04f;
            transform.localScale = localScale;
        }
    }
}
