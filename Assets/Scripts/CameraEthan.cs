using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEthan : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;
    private Vector3 mouseOriginPoint;
    private bool dragging;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}