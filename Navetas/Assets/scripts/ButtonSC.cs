using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ButtonSC : MonoBehaviour
{
    [SerializeField] private Sprite buttonPushed;
    [SerializeField] private BoxCollider2D ButtonPusher;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = buttonPushed;


    }
    

}
