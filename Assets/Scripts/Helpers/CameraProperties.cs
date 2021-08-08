using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CameraProperties
{
    private static Camera _main;
    public static Camera Main => _main ?? (_main = Camera.main);
    
    private static Transform _transform;
    public static Transform Transform => _transform ?? (_transform = Main.transform);
    public static float RotationOffset => Transform.rotation.eulerAngles.y;
}
