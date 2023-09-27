using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingPanel : MonoBehaviour
{
    [SerializeField]
    private Image _loadingBar;

    [SerializeField]
    private bool _isFakeLoading = false;
    [SerializeField]
    private float _fakeLoadingTimeMin = 2f;
    [SerializeField]
    private float _fakeLoadingTimeMax = 4f;


    private void Start()
    {
        if (_isFakeLoading)
        {
            StartCoroutine(FakeLoadNextLevel());
        }
        else
        {
            StartCoroutine(LoadNextLevel());
        }
    }

    IEnumerator LoadNextLevel()
    {
        AsyncOperation loadLevel = SceneManager.LoadSceneAsync("Menu");

        while (!loadLevel.isDone)
        {
            _loadingBar.fillAmount = Mathf.Clamp01(loadLevel.progress / .9f);
            yield return null;
        }
    }

    IEnumerator FakeLoadNextLevel()
    {
        float fakeLoadTime = Random.Range(_fakeLoadingTimeMin, _fakeLoadingTimeMax);
        float elapsedTime = 0f;

        while (elapsedTime < fakeLoadTime)
        {
            _loadingBar.fillAmount = Mathf.Clamp01(elapsedTime / fakeLoadTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        SceneManager.LoadScene("Menu");
    }
}
