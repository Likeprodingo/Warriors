using UnityEngine;

namespace Scripts.Core.UI
{
    public abstract class Window : MonoBehaviour
    {
        public abstract bool IsPopup
        {
            get;
        }

        protected virtual void Start()
        {

        }

        protected virtual void OnEnable()
        {
            
        }

        protected virtual void OnDisable()
        {
            
        }

        public virtual void Preload()
        {
            gameObject.SetActive(false);
        }

        public virtual void OnShow()
        {
            gameObject.SetActive(true);
        }

        public virtual void Refresh()
        {

        }

        public virtual void OnHide()
        {
            gameObject.SetActive(false);
        }
    }
}