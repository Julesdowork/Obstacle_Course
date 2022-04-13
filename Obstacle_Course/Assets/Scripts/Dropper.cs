using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 5f;

    MeshRenderer meshRenderer;
    Rigidbody rb;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        meshRenderer.enabled = false;
        rb.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
