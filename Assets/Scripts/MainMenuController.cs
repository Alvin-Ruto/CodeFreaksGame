using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;

    void Start()
    {
        playButton.onClick.AddListener(OnPlayClicked);
        exitButton.onClick.AddListener(OnExitClicked);
    }

    void OnPlayClicked()
    {
        AudioManager.Instance.PlayButtonClick(); // Play click sound
        SceneManager.LoadScene("Level01");
    }

    void OnExitClicked()
    {
        AudioManager.Instance.PlayButtonClick(); // Play click sound
        SceneManager.LoadScene("LevelSelect"); // Or Application.Quit() for real exit
    }
}
