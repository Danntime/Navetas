using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class OpacityMidSC : MonoBehaviour
{
    [SerializeField] private Color _color;
    private void Update()
    {
        GetComponent<SpriteRenderer>().color = _color;

    }
}
