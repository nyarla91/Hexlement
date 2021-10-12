using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InHand : Transformer
{
    public const float Y_UPON_REROLLED = -170;

    [SerializeField] protected AudioClip _clickSound;
    [SerializeField] protected AnchoredTile _anchoredTile;
    protected static List<InHand> tiles = new List<InHand>();
    
    protected Structure _structure;
    protected Watch<bool> _selected;

    protected virtual void Start()
    {
        tiles.Add(this);
        _selected.OnChanged += OnSelectedChanged;
    }

    public void Click()
    {
        foreach (var tile in tiles)
        {
            tile._selected.V = false;
        }
        if (!_selected.V)
            SoundPlayer.Play(_clickSound, 1);
        _selected.V = true;
    }

    private void OnSelectedChanged(bool newSelected)
    {
        Turns.NextStructure = newSelected ? _structure : null;
        _anchoredTile.targetPosition =  new Vector2(rectTransform.anchoredPosition.x, newSelected ? 60 : 0);
        _anchoredTile.targetScale = newSelected ? 1.2f : 1;
    }

    private void Cancel(InputAction.CallbackContext ctx)
    {
        _selected.V = false;
    }
}
