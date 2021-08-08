using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerInHand : InHand
{
    [SerializeField] private Image _banImage;
    private Structure Structure
    {
        get => _structure;
        set
        {
            _structure = value;
            _banImage.sprite = StructureTypeInfo.TaskSprites[(int) _structure.task[0]];
        }
    }

    protected override void Start()
    {
        base.Start();
        Turns.OnNextTurn += NewTurn;
        NewTurn(true);
    }

    public void NewTurn(bool tower)
    {
        _selected.V = false;
        if (!tower) 
            return;
        Structure = new Structure(true);
        rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, Y_UPON_REROLLED);
    }
}
