using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ClickableObject))]
public class TestClick : MonoBehaviour
{
    private ClickableObject _clickableObject;

    private void Awake()
    {
        _clickableObject = GetComponent<ClickableObject>();
        _clickableObject.OnDrag += Drag;
        _clickableObject.OnDragEnd += DragEnd;
    }

    private void Drag(MouseButton button) => print("drag down :" + button);
    private void DragEnd(MouseButton button) => print("drag end up :" + button);
}
