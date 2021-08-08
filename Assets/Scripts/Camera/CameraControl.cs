using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CameraControl : Transformer
{
    private const float DRAG_SPEED = 0.003f;
    private const float MOVE_SPEED = 0.02f;
    private const float ZOOM_SPEED = 0.002f;

    public static List<Transform> points = new List<Transform>();

    private bool _drag;
    private Transform _idle;
    
    private void Awake()
    {
        Controls.Map.All.Enable();
        Controls.Map.All.Drag.started += ctx => { _drag = CursorControl.Camera = true; };
        Controls.Map.All.Drag.canceled += ctx => { _drag = CursorControl.Camera = false; };
    }

    private void Update()
    {
        float size = CameraProperties2D.Main.orthographicSize;
        Vector3 deltaPosition = Vector3.zero;
        // Drag
        if (_drag)
            deltaPosition += DRAG_SPEED * size * -(Vector3) Controls.Map.All.Delta.ReadValue<Vector2>();
        // WASD
        deltaPosition += MOVE_SPEED * size * (Vector3) Controls.Map.All.Move.ReadValue<Vector2>();
        // Move
        transform.position += (Vector3) deltaPosition;
        // Zoom
        float zoom = -Controls.Map.All.Zoom.ReadValue<float>();
        CameraProperties2D.Main.orthographicSize = Mathf.Clamp(size + zoom * ZOOM_SPEED, 1, 7);
        // Return
        if (deltaPosition.magnitude == 0 && !_drag && _idle == null)
        {
            points = points.OrderBy(t => Vector2.Distance(transform.position, t.position)).ToList();
            if (Vector2.Distance(transform.position, points[0].position) > 4)
                _idle = points[0];
        }
        else if (deltaPosition.magnitude > 0)
        {
            _idle = null;
        }
        else if (_idle != null)
        {
            Vector3 newPosition = Vector2.Lerp(transform.position, _idle.position, 2 * Time.deltaTime);
            newPosition.z = -10;
            transform.position = newPosition;
        }
    }
}
