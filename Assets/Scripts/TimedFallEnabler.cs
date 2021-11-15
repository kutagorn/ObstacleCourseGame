using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedFallEnabler : MonoBehaviour
{
   private MeshRenderer _renderer;
   private Rigidbody _rigidBody;
   private float _time = 0f;
   [SerializeField] private float _setTime = 0.0f;

   private void Start()
   {
      _renderer = GetComponent<MeshRenderer>();
      _renderer.enabled = false;
      _rigidBody = GetComponent<Rigidbody>();
      _rigidBody.useGravity = false;
   }

   private void Update()
   {
      _time = Time.time;
      GravityEnabler();
      
   }

   private void GravityEnabler()
   {
      
      if (_time > _setTime)
      {
         _renderer.enabled = true;
         
        _rigidBody.useGravity = enabled;
      }
   }
}
