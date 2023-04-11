using System;
using UnityEngine;

namespace Car
{

    public class CarSoundManager : MonoBehaviour
    {
        [SerializeField] private float minSpeed;
        [SerializeField] private float maxSpeed;
        
        private Rigidbody _rigidbody;
        private AudioSource _audioSource;
        
        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            EngineSound();
        }

        private void EngineSound()
        {
            var pitchValue = 3 / 100;
            var velocity = _rigidbody.velocity.z / 100;
            _audioSource.pitch = -pitchValue * -velocity;
        }
    }
}
