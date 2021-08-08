using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    private static LoseScreen _instance;

    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private TextMeshProUGUI _turnsCounter;

    private void Awake()
    {
        _instance = this;
    }

    public static void Show()
    {
        _instance._turnsCounter.text = Turns.TurnsMade.ToString();
        _instance._canvasGroup.blocksRaycasts = _instance._canvasGroup.interactable = true;
        _instance._canvasGroup.DOFade(1, 0.5f);
    }

    public static void Restart()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
}
