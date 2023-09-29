using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPanel : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField _userNameInput;

    [SerializeField]
    private Button _playButton;
    [SerializeField]
    private Button _infoButton;
    [SerializeField]
    private Button _exitButton;

    [SerializeField]
    private int maxUsernameLength = 10;

    private void Awake()
    {
        _playButton.onClick.AddListener(OnPlayButtonClick);
        _infoButton.onClick.AddListener(OnInfoButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);

        _userNameInput.onEndEdit.AddListener(OnEndUsernameEdit);
        _userNameInput.characterLimit = maxUsernameLength;
    }

    private void OnEndUsernameEdit(string arg0)
    {
        //if (arg0.Length > maxUsernameLength)
        //{
        //    _userNameInput.text = arg0.Substring(0, maxUsernameLength);
        //    arg0 = _userNameInput.text;
        //}

        GlobalVariables.USER_NAME = arg0;

        Debug.Log(GlobalVariables.USER_NAME);
    }

    private void OnPlayButtonClick()
    {
        SceneManager.LoadScene("Game");
    }

    private void OnInfoButtonClick()
    {
        Application.OpenURL("https://unity.com/unity-hub");
    }

    private void OnExitButtonClick()
    {
        Application.Quit();
    }
}
