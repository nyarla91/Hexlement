using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPoint : Transformer
{
    private void Awake()
    {
        CameraControl.points.Add(transform);
    }

    private void OnDestroy()
    {
        CameraControl.points.Remove(transform);
    }
}
