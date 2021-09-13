using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{
    public float elevationSpeed;
    private Vector3 startPosition;
    private Vector3 endPosition;

    void Start()
    {
        //startPosition = GameObject.transform.position;
        startPosition.x = -7;
        startPosition.y = 2;
    }

    void Update()
    {
        if(startPosition.x < 10)
        startPosition.x++;
    }
}
