using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CameraProperties2D
{
    private static Camera _main;

    public static Camera Main => _main ?? (_main = Camera.main);

    private static Transform _transform;
    public static Transform Transform => _transform ?? (_transform = Main.transform);
    
    public static Vector3 mousePosition => Main.ScreenToWorldPoint(Input.mousePosition);

    public static Vector3 PercentToWorldPoint(Vector2 percent)
    {
        percent += Vector2.one;
        percent /= 2;
        percent *= new Vector2(Screen.width, Screen.height);
        return Main.ScreenToWorldPoint(percent);
    }
}
