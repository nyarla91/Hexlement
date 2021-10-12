using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControl : MonoBehaviour
{
    private static CursorControl _instance;
    
    [SerializeField] private CursorInfo _regularCursor;
    [SerializeField] private CursorInfo _placementCursor;
    [SerializeField] private CursorInfo _cameraCursor;

    private bool _camera;
    public static bool Camera
    {
        get => _instance._camera;
        set
        {
            _instance._camera = value;
            ChangeCursor();
        }
    }
    private bool _placement;
    public static bool Placement
    {
        get => _instance._placement;
        set
        {
            _instance._placement = value;
            ChangeCursor();
        }
    }

    private void Awake()
    {
        _instance = this;
        Turns.OnStructureSelected += () => { Placement = true; };
        Turns.OnStructureCancel += () => { Placement = false; };
    }

    private static void ChangeCursor()
    {
        if (Camera)
            SetCursorFromInfo(_instance._cameraCursor);
        else
            SetCursorFromInfo(_instance._regularCursor);
    }

    private static void SetCursorFromInfo(CursorInfo info) =>
        Cursor.SetCursor(info._cursor, info.offset, CursorMode.Auto);

}

[Serializable]
public class CursorInfo
{
    public Texture2D _cursor;
    public Vector2 offset;
}
