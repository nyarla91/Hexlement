using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossFlag : Transformer
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private float _alpha
    {
        get
        {
            return _spriteRenderer.color.a;
        }
        set
        {
            _spriteRenderer.color = VectorHelper.SetA(_spriteRenderer.color, value);
        }
    }

    private void Start()
    {
        transform.localScale = 1 * Vector3.one;
        _alpha = 0;
        StartCoroutine(Animation());
    }

    private IEnumerator Animation()
    {
        float delta = 2;
        while (_alpha < 1)
        {
            transform.localScale = (transform.localScale.x - delta * 0.5f * Time.deltaTime) * Vector3.one;
            _alpha += delta * Time.deltaTime;
            yield return null;
        }
        transform.localScale = 0.5f * Vector3.one;
        _alpha = 1;
    }
}
