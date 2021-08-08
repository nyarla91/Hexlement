using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskHUD : Transformer
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    
    private StructureType _type;
    public StructureType Type
    {
        get => _type;
        set
        {
            _type = value;
            _spriteRenderer.sprite = StructureTypeInfo.TaskSprites[(int) value];
        }
    }

    public Vector2 targetPosition;

    private void Update()
    {
        transform.position = Vector2.Lerp(transform.position, targetPosition, Time.deltaTime * 5);
        transform.position = VectorHelper.SetZ(transform.position, -1);
    }
}
