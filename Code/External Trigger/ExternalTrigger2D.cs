﻿using UnityEngine;
using UnityEngine.Events;

namespace Green.Tool.Utility.Trigger
{
    [RequireComponent(typeof(Collider2D))]
    public class ExternalTrigger2D : MonoBehaviour
    {
        public UnityEvent<Collider2D> OnEnter;
        public UnityEvent<Collider2D> OnStay;
        public UnityEvent<Collider2D> OnExit;

        private void OnTriggerEnter2D(Collider2D other)
        {
            OnEnter?.Invoke(other);
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            OnStay?.Invoke(other);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            OnExit?.Invoke(other);
        }
    }
}
