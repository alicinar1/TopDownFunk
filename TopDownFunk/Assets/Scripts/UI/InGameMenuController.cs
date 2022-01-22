using System.Collections;
using System.Collections.Generic;
using TopDownFunk.PlayerInput;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TopDownFunk.UI
{
    public class InGameMenuController : MonoBehaviour
    {
        [SerializeField] private Canvas _pauseGameCanvas;
        [SerializeField] private Canvas _activeGameCanvas;
        [SerializeField] private AbstractInputData _escButton;

        public void StopGame()
        {
            _activeGameCanvas.gameObject.SetActive(false);
            _pauseGameCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        public void ResumeGame()
        {
            _activeGameCanvas.gameObject.SetActive(true);
            _pauseGameCanvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        public void BackToMainMenuScene()
        {
            SceneManager.LoadScene(0);
            _activeGameCanvas.gameObject.SetActive(false);
            _pauseGameCanvas.gameObject.SetActive(false);
        }

        private void Update()
        {
            if (_escButton.Horizontal > 0 && SceneManager.GetActiveScene().buildIndex != 0)
            {
                StopGame();
            }
        }
    }
}
