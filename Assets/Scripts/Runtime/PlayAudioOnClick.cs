
using UnityEngine;
using UnityEngine.UI;

namespace Runtime
{
    public class PlayAudioOnClick : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;
        
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(audioSource.Play);
        }
    }
}