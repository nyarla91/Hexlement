using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OnBoard : Transformer
{
    # region Adjacency
    private const float VER_HEX_OFFSET = 0.87f;
    private const float HOR_HEX_OFFSET = 1;
    private static List<Vector2> _adjacentHexes;
    public static List<Vector2> AdjacentHexes => _adjacentHexes ?? (_adjacentHexes = new[]
    {
        new Vector2(HOR_HEX_OFFSET, 0),
        new Vector2(-HOR_HEX_OFFSET, 0),
        new Vector2(0.5f * HOR_HEX_OFFSET, VER_HEX_OFFSET),
        new Vector2(-0.5f * HOR_HEX_OFFSET, VER_HEX_OFFSET),
        new Vector2(0.5f * HOR_HEX_OFFSET, -VER_HEX_OFFSET),
        new Vector2(-0.5f * HOR_HEX_OFFSET, -VER_HEX_OFFSET)
    }.ToList());
    #endregion
    
    [SerializeField] protected GameObject _hexPrefab;
    protected Structure _structure;

    public ITile highClass;
    [SerializeField] protected int _sidesLeft = 6;
    
    protected void InteractWithAdjacent()
    {
        foreach (var offset in AdjacentHexes)
        {
            Vector2 hex = offset + (Vector2) transform.position;
            Collider2D target = Physics2D.OverlapCircle(hex, 0.45f);
            if (target == null)
            {
                Instantiate(_hexPrefab, hex, Quaternion.identity);
            }
            else if (target.GetComponent<OnBoard>() != null)
            {
                OnBoard other = target.GetComponent<OnBoard>();
                other.highClass.Interact(_structure.type, false);
                highClass.Interact(other._structure.type, true);
            }
        }
    }
}
