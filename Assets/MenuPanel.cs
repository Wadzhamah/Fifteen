using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPanel : MonoBehaviour
{
    [SerializeField]
    private Button _playButton;
    [SerializeField]
    private Button _infoButton;
    [SerializeField]
    private Button _exitButton;

    private void Awake()
    {
        _playButton.onClick.AddListener(OnPlayButtonClick);
        _infoButton.onClick.AddListener(OnInfoButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
    }

    
    private void OnPlayButtonClick()
    {
        SceneManager.LoadScene("Game");
    }

    private void OnInfoButtonClick()
    {
        throw new NotImplementedException();
    }

    private void OnExitButtonClick()
    {
        Application.Quit();
    }
}
