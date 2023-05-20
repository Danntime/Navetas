using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class OpacityMidSC : MonoBehaviour
{
    //Permet de changer une couleur et son opacit� en dehors de l'�diteur Unity.
    [SerializeField] private Color _color;
    private void Update()
    {
        GetComponent<SpriteRenderer>().color = _color;

    }
}
