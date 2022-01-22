using System.Collections;
using System.Collections.Generic;
using TopDownFunk.PlayerInput;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TopDownFunk.UI
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private Canvas _mainMenuCanvas;
        [SerializeField] private Canvas _instructionsCanvas;
        [SerializeField] private Canvas _startScreenCanvas;

        public void StartGame()
        {
            _mainMenuCanvas.gameObject.SetActive(false);
            _startScreenCanvas.gameObject.SetActive(false);
            SceneManager.LoadScene(1);
        }


        public void QuitGame()
        {
            Application.Quit();
        }

        public void InstructionMenu()
        {
            _mainMenuCanvas.gameObject.SetActive(false);
            _instructionsCanvas.gameObject.SetActive(true);
        }

        public void MainMenu()
        {
            _mainMenuCanvas.gameObject.SetActive(true);
            _instructionsCanvas.gameObject.SetActive(false);
        }
    }
}
