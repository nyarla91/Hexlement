using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reroll : Transformer
{
    [SerializeField] private StructureInHand _structure;
    [SerializeField] private TowerInHand _tower;
    [SerializeField] private AudioClip _rerollSound;
    
    public void MakeReroll()
    {
        _structure.NewTurn(false);
        SoundPlayer.Play(_rerollSound, 1);
        Resources.Coins--;
        rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, InHand.Y_UPON_REROLLED);
    }
}
