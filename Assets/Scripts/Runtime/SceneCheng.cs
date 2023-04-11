using UnityEngine;
using UnityEngine.SceneManagement;

namespace Runtime
{
    public class SceneCheng : MonoBehaviour
    {
        [SerializeField] private Animator animator;

        private int _sceneToLoad;

        public void FadeToLoadScene(int sceneIndex)
        {
            _sceneToLoad = sceneIndex;
            animator.SetTrigger("FadeOut");
        }

        public void OnFadeDone()
        {
            SceneManager.LoadScene(_sceneToLoad);
        }
    }
}
