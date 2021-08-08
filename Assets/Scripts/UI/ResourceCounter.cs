using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceCounter : Transformer
{
    
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Gradient _gradient;

    private int _value;
    public int Value
    {
        get => _value;
        set
        {
            if (value > _value)
                Plus();
            else if (value < _value)
                Minus();
            _value = value;
            _text.text = _value.ToString();
        }
    }

    private float scale = 1;
    private float color = 0.5f;

    private void Update()
    {
        rectTransform.localScale = Vector3.one * scale;
        _text.color = _gradient.Evaluate(color);

        scale = Mathf.Lerp(scale, 1, Time.deltaTime * 3);
        color = Mathf.Lerp(color, 0.5f, Time.deltaTime * 3);
    }

    private void Minus()
    {
        scale = 0.7f;
        color = 0;
    }

    private void Plus()
    {
        scale = 1.3f;
        color = 1;
    }
}
