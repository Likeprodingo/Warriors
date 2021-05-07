using System;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts.Core.UI
{
    public class ResultPopup : Window
    {
        public static event Action ContinueClicked = delegate { };

        [SerializeField]
        private Button _continueButton = null;

        [SerializeField]
        //private TextMeshProUGUI _levelLabel = null;

        public override bool IsPopup => true;

        protected override void Start()
        {
            base.Start();

            _continueButton.onClick.AddListener(OnContinueButtonClick);
        }

        public override void OnShow()
        {
            base.OnShow();

            //_levelLabel.text = $"LEVEL {LocalConfig.LevelIndex + 1}";
        }

        private void OnContinueButtonClick()
        {
            UISystem.ShowWindow<GameWindow>();

            ContinueClicked();
        }
    }
}