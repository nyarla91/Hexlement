using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class Structure
{

    //public static StructureType RandomType => (StructureType) Random.Range(1, 6);
    
    public List<StructureType> task;
    public StructureType type;

    public Structure(bool tower)
    {
        type = tower ? StructureType.Tower : StructureTypeInfo.PickTypeForTile();
        task = new List<StructureType>();
        if (type == StructureType.Tower)
        {
            task.Add(StructureTypeInfo.PickTypeForBan());
        }
        else
        {
            task.Add(type);
            StructureType nextTasks = StructureTypeInfo.PickTypeForTask();
            for (int i = 0; i < 2; i++)
            {
                task.Add(nextTasks);
            }
        }
    }
}

public enum StructureType
{
    Tower = 0,
    Blacksmith = 1,
    Lumber = 2,
    Church = 3,
    Windmill = 4,
    Farm = 5,
}
