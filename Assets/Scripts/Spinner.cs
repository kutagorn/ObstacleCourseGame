using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    private float _normalisedSpeed;
   
    void Update()
    {
        _normalisedSpeed = _speed * Time.deltaTime;
        transform.Rotate(0, _normalisedSpeed, 0);
    }
}
