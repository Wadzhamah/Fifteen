using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinGamePopup : BaseScreen
{
    [SerializeField]
    private Button _replayButton;

    private GameController _gameController;

    private void GameController_OnGameFinish()
    {
        Open();
    }

    private void OnReplayButtonClick()
    {
        _gameController.StartNewGame();
        this.Close();
    }

    public override void Init()
    {
        _gameController = GameController.Instance;
        _gameController.OnGameFinish += GameController_OnGameFinish;
        _replayButton.onClick.AddListener(OnReplayButtonClick);
    }
}
