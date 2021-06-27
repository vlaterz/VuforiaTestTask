using UnityEngine;

namespace Assets.Assets.Scripts
{
    public class CharacterAnimationController : MonoBehaviour
    {
        private Animator _animator;

        private void Awake() => _animator = GetComponentInChildren<Animator>(); 

        public void PlaySitups() =>_animator.SetTrigger("StartSitups");
        public void PlayJumping() =>_animator.SetTrigger("StartJumping");
        public void PlayDance() =>_animator.SetTrigger("StartDance");
    }
}
