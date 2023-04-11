using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Car
{
    public class CarController : MonoBehaviour
    {   
        [SerializeField] private float maxVelocity;
        
        [SerializeField] private float speedToStop;
        
        [SerializeField] private float speedToRun;
        
        [SerializeField] private List<GameObject> tiers;
        
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Move();
            
            if (_rigidbody.velocity.z < 0)
            {
                TireAnimation();
            }

        }

        private void Move()
        {
            if (Input.GetMouseButton(0))
            {
                if (_rigidbody.velocity.z > -maxVelocity)
                {
                    _rigidbody.AddForce(new Vector3(0, 0, -speedToRun));
                }
            }
            else
            {
                if (_rigidbody.velocity.z < -1)
                {
                    _rigidbody.AddForce(new Vector3(0,0,speedToStop));
                }
                else
                {
                    _rigidbody.velocity = Vector3.zero;
                }
                
            }
        }

        private void TireAnimation()
        {
            foreach (var tire in tiers)
            {
                tire.transform.Rotate(0,0,_rigidbody.velocity.z);
            }
        }
    }
}
