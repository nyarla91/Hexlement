using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchoredTile : Transformer
{
    private const float LERP_SPEED = 10;
    
    public Vector2 targetPosition;
    public float targetScale;

    private void Awake()
    {
        targetPosition = rectTransform.anchoredPosition;
        targetScale = rectTransform.localScale.x;
    }

    private void Update()
    {
        rectTransform.anchoredPosition = Vector2.Lerp(rectTransform.anchoredPosition, targetPosition, LERP_SPEED * Time.deltaTime);
        rectTransform.localScale = Mathf.Lerp(rectTransform.localScale.x, targetScale, LERP_SPEED * Time.deltaTime) * Vector3.one;
    }
}
