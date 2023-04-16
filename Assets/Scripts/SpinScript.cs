using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    public Transform cubeRef;
    [SerializeField] private float speed;
    private Vector3 center;
    private void Start()
    {
        center = cubeRef.position;
        transform.LookAt(center);
    }
    void FixedUpdate()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.RotateAround(center, new Vector3(0.0f, 1.0f, 0.0f), speed);
    }
}
