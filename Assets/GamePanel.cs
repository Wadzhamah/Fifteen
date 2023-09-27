using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePanel : BaseScreen
{
    [SerializeField]
    private Button _exitButton;
    [SerializeField]
    private Button _replayButton;
    [SerializeField]
    private Button _infoButton;

    private void Awake()
    {
        _exitButton.onClick.AddListener(OnExitButtonClick);
        _replayButton.onClick.AddListener(OnReaplyButtonClick);
        _infoButton.onClick.AddListener(OnInfoButtonClick);
    }

    private void OnExitButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }

    private void OnReaplyButtonClick()
    {
        GameController.Instance.StartNewGame();
    }

    private void OnInfoButtonClick()
    {
        Application.OpenURL("https://unity.com/unity-hub");
    }
}
