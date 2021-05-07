using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts.Core.UI
{
    public class MainWindow : Window
    {
        [SerializeField]
        private Button _startButton = null;

        public override bool IsPopup => false;

        protected override void Start()
        {
            base.Start();

            _startButton.onClick.AddListener(OnStartButtonClick);
        }

        private void OnStartButtonClick()
        {
            //SceneManager.LoadSceneAsync("TutorialLevel").completed += (AsyncOperation operation) =>
            {
                UISystem.ShowWindow<GameWindow>();
            };
        }
    }
}