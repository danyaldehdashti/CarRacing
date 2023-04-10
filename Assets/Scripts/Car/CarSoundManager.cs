using System;
using UnityEngine;

namespace Car
{

    public class CarSoundManager : MonoBehaviour
    {
        [SerializeField] private float minSpeed;
        [SerializeField] private float maxSpeed;

        [SerializeField] private float minPitch;
        [SerializeField] private float maxPitch;
        
        private Rigidbody _rigidbody;
        private AudioSource _audioSource;
        private float _pitchFromCar;
        private float _currentSpeed;

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
            _currentSpeed = _rigidbody.velocity.z;
            _pitchFromCar = _rigidbody.velocity.y / 50;

            if (_currentSpeed < minSpeed)
            {
                _audioSource.pitch = minPitch;
            }

            if (_currentSpeed > minSpeed && _currentSpeed < maxSpeed)
            {
                _audioSource.pitch = minPitch + _pitchFromCar;
            }

            if (_currentSpeed > maxSpeed)
            {
                _audioSource.pitch = maxPitch;
            }
        }
    }
}
