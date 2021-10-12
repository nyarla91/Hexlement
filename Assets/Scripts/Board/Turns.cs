using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Turns : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _turnsCounter;
    
    private static Structure _nextStructure;
    public static Structure NextStructure
    {
        get => _nextStructure;
        set
        {
            if (value == null && OnStructureCancel != null)
                OnStructureCancel();
            else if (OnStructureSelected != null)
            {
                OnStructureSelected();
            }
            _nextStructure = value;
        }
    }

    public static int TurnsMade { get; private set; }

    public delegate void StructureSelectedHandler();
    public static StructureSelectedHandler OnStructureSelected;
    public static StructureSelectedHandler OnStructureCancel;
    public delegate void TurnHandler(bool tower);
    public static TurnHandler OnNextTurn;

    private void Awake()
    {
        NextStructure = null;
        OnNextTurn += tower =>
        {
            TurnsMade++;
            _turnsCounter.text = TurnsMade.ToString();
            StartCoroutine(CheckDefeat());
        };
    }

    private IEnumerator CheckDefeat()
    {
        yield return new WaitForSeconds(0.1f);
        if (Resources.TilesInDeck <= 0)
        {
            LoseScreen.Show();
        }
    }
}
