using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporterSC : MonoBehaviour
{
    [SerializeField] private Transform destination;
    public Transform GetDestination()
    {
        return destination;
    }
}
