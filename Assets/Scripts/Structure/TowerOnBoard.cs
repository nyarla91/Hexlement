using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerOnBoard : OnBoard, ITile
{

    private StructureType _ban;

    public void Place(Structure structure)
    {
        highClass = this;
        _structure = structure;
        _ban = _structure.task[0];
        InteractWithAdjacent();
        Turns.OnNextTurn(true);
    }

    public void Interact(StructureType other, bool itslef)
    {
        if (other == _ban || other == StructureType.Tower || !itslef) 
            return;
        Resources.Coins += 3;
    }
}
