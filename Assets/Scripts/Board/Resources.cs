using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Resources : MonoBehaviour
{
    private static Resources _instance;

    [SerializeField] private ResourceCounter _tilesCounter;
    [SerializeField] private ResourceCounter _coinsCounter;

    private int _tilesInDeck;
    public static int TilesInDeck
    {
        get => _instance._tilesInDeck;
        set
        {
            _instance._tilesInDeck = value;
            _instance._tilesCounter.Value = value;
        }
    }
    
    private int _coins;
    public static int Coins
    {
        get => _instance._coins;
        set
        {
            _instance._coins = value;
            _instance._coinsCounter.Value = value;
        }
    }

    private void Awake()
    {
        _instance = this;
        TilesInDeck = 20;
        Coins = 10;
    }
}
