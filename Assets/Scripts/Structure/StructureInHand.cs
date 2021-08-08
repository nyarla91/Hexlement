using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class StructureInHand : InHand
{
    [SerializeField] private Image _image;
    [SerializeField] private List<Image> _tasks;
    private Structure Structure
    {
        get => _structure;
        set
        {
            _structure = value;
            _image.sprite = StructureTypeInfo.TileSprites[(int) _structure.type];
            for (int i = 0; i < _structure.task.Count; i++)
            {
                _tasks[i].sprite = StructureTypeInfo.TaskSprites[(int) _structure.task[i]];
            }
        }
    }

    protected override void Start()
    {
        base.Start();
        Turns.OnNextTurn += NewTurn;
        NewTurn(false);
    }

    public void NewTurn(bool tower)
    {
        _selected.V = false;
        if (tower) 
            return;
        Structure = new Structure(false);
        rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, Y_UPON_REROLLED);
    }
}
