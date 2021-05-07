using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Scripts.Core.UI
{
    public class UISystem : MonoBehaviour
    {
        public static Action<Window> OnShown = delegate { };

        [SerializeField]
        private GameObject _windowsContainer = null;

        [SerializeField]
        private Camera _camera = null;

        private Window[] _windows = null;

        private Window _current = null;
        private Stack<Window> _stack = new Stack<Window>();

        private static UISystem _instance = null;

        public Window CurrentWindow => _current;
        public Camera Camera => _camera;
        public static UISystem Instance => _instance;

        private void Awake()
        {
            _instance = this;

            _windows = _windowsContainer.GetComponentsInChildren<Window>(true);
            _windows.Do(wind => wind.Preload());

            DontDestroyOnLoad(gameObject);
        }

        public static void ShowWindow<T>()
            where T : Window
        {
            var window = GetWindow<T>();

            if (!ReferenceEquals(Instance._current, null))
            {
                Instance._current.OnHide();
            }

            window.OnShow();
            window.Refresh();

            OnShown(window);

            Instance._current = window;
        }

        private static Window GetWindow<T>()
            where T : Window
        {
            var window = Instance._windows.FirstOrDefault(w => w is T);

            if (!window)
            {
                Debug.LogException(new Exception($"{typeof(T)} not found!"));
            }

            return window;
        }

        public static void ReturnToPreviousWindow()
        {
            if (Instance._stack.Count > 1)
            {
                var prev = Instance._stack.Pop();
            }
            else
            {

            }
        }
    }
}