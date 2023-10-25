using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSC : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    private readonly float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
