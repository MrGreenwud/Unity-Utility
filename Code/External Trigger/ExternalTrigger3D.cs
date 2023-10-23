using UnityEngine;
using UnityEngine.Events;

namespace Green.Tool.Utility.Trigger
{
    [RequireComponent(typeof(Collider))]
    public class ExternalTrigger3D : MonoBehaviour
    {
        public UnityEvent<Collider> OnEnter;
        public UnityEvent<Collider> OnStay;
        public UnityEvent<Collider> OnExit;

        private void OnTriggerEnter(Collider other)
        {
            OnEnter?.Invoke(other);
        }

        private void OnTriggerStay(Collider other)
        {
            OnStay?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            OnExit?.Invoke(other);
        }
    }
}
