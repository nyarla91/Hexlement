using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : Transformer
{
    public static bool Watched { get; private set; }
    
    [SerializeField] private CanvasGroup _pageGroup;
    [SerializeField] private Image _illustration;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private List<TutorialIPage> _pages;

    private Coroutine _fadeCoroutine;
    private int _currentPage;

    private void Start()
    {
        if (Watched)
            Destroy(gameObject);
        StartCoroutine(FadeToNext(0));
    }

    public void NextPage() => SwitchPage(1);
    public void PreviousPage() => SwitchPage(-1);
    private void SwitchPage(int modifier)
    {
        if (_fadeCoroutine == null)
            _fadeCoroutine = StartCoroutine(FadeToNext(_currentPage + modifier));
    }

    private IEnumerator FadeToNext(int nextPage)
    {
        const float fadeSpeed = 5;
        if (nextPage < 0 || nextPage >= _pages.Count)
            yield break;
        _currentPage = nextPage;
        // Fade out
        _pageGroup.alpha = 1;
        for (float i = 0; i < 1; i += fadeSpeed * Time.deltaTime)
        {
            _pageGroup.alpha = 1 - i;
            yield return null;
        }
        _pageGroup.alpha = 0;

        // Switch page
        _illustration.sprite = _pages[nextPage].illustration;
        _text.text = Localization.Translate(_pages[nextPage].text);

        // Fade in
        for (float i = 0; i < 1; i += fadeSpeed * Time.deltaTime)
        {
            _pageGroup.alpha = i;
            yield return null;
        }
        _pageGroup.alpha = 1;

        _fadeCoroutine = null;
    }

    public void Close() => StartCoroutine(CloseIE());

    private IEnumerator CloseIE()
    {
        Watched = true;
        const float yPosition = 1500;
        const float lerpSpeed = 5;
        
        while (rectTransform.anchoredPosition.y < yPosition - 1)
        {
            rectTransform.anchoredPosition = Vector2.Lerp(rectTransform.anchoredPosition, new Vector2(0, yPosition), lerpSpeed * Time.deltaTime);
            yield return null;
        }
        Destroy(gameObject);
    }
}

[Serializable]
public class TutorialIPage
{
    public Sprite illustration;
    [TextArea(10, 20)] public string[] text;
}
