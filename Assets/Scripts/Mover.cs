using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed;

 
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        var normalisedSpeed = speed * Time.deltaTime;
        var xValue = Input.GetAxis("Horizontal") * normalisedSpeed;
        var zValue = Input.GetAxis("Vertical") * normalisedSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}