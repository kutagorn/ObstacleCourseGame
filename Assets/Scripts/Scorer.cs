using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int _hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit"))
        {
            _hits++;
            Debug.Log("You've bumped into a thing this many times:" + _hits);
        }
    }
}