using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructureTypeInfo : MonoBehaviour
{
    private static StructureTypeInfo _instance;

    public static Sprite[] TileSprites => _instance._tileSprites;
    public static Sprite[] TaskSprites => _instance._taskSprites;
    
    [SerializeField] private Sprite[] _tileSprites;
    [SerializeField] private Sprite[] _taskSprites;

    [SerializeField] private List<StructureType> _tilePool = new List<StructureType>();
    [SerializeField] private List<StructureType> _taskPool = new List<StructureType>();
    [SerializeField] private List<StructureType> _banPool = new List<StructureType>();

    private void Awake()
    {
        _instance = this;
        AddAllTypesToPool(ref _taskPool);
        AddAllTypesToPool(ref _tilePool);
        AddAllTypesToPool(ref _banPool);
    }

    public static StructureType PickTypeForTile() => PickTypeFromPool(ref _instance._tilePool);
    public static StructureType PickTypeForTask() => PickTypeFromPool(ref _instance._taskPool);
    public static StructureType PickTypeForBan() => PickTypeFromPool(ref _instance._banPool);

    private static StructureType PickTypeFromPool(ref List<StructureType> pool)
    {
        StructureType type = CollectionHelper.ChooseRandomElement(pool);
        pool.Remove(type);
        if (!pool.Contains(type))
            AddAllTypesToPool(ref pool);
        return type;
    }

    private static void AddAllTypesToPool(ref List<StructureType> pool)
    {
        pool.Add(StructureType.Blacksmith);
        pool.Add(StructureType.Farm);
        pool.Add(StructureType.Lumber);
        pool.Add(StructureType.Windmill);
        pool.Add(StructureType.Church);
    }
}