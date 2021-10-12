using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class StructureOnBoard : OnBoard, ITile
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject _taskHUDPrefab;
    [SerializeField] private GameObject _crossPrefab;
    [SerializeField] private GameObject _flagPrefab;
    private List<TaskHUD> _taskHUDs = new List<TaskHUD>();

    public void Place(Structure structure)
    {
        highClass = this;
        // Initialize
        
        _structure = structure;
        _spriteRenderer.sprite = StructureTypeInfo.TileSprites[(int) structure.type];
        foreach (var task in _structure.task)
        {
            TaskHUD newTask = Instantiate(_taskHUDPrefab, transform.position, Quaternion.identity).GetComponent<TaskHUD>();
            newTask.Type = task;
            _taskHUDs.Add(newTask);
        }
        UpdateTasksPosition();
        
        // CompleteTasks
        
        InteractWithAdjacent();
        Turns.OnNextTurn(false);
    }

    public void Interact(StructureType other, bool itself)
    {
        if (_sidesLeft == 0)
            return;
        _sidesLeft--;
        foreach (var task in _structure.task)
        {
            if (!other.Equals(task))
                continue;
            TaskHUD removedTask = _taskHUDs.Find(t => t.Type.Equals(other));
            removedTask.Alpha = 0.3f;
            _structure.task.Remove(other);
            _taskHUDs.Remove(removedTask);
            Destroy(removedTask.gameObject);
            break;
        }
        GameObject result = null;
        if (_structure.task.Count == 0)
        {
            result = _flagPrefab;
            Resources.TilesInDeck++;
        }
        if (_structure.task.Count > _sidesLeft)
        {
            result = _crossPrefab;
        }
        if (result != null)
        {
            Instantiate(result, transform.position + new Vector3(0, 0, -1), Quaternion.identity);
            _sidesLeft = 0;
        }
        UpdateTasksPosition();
    }

    public void UpdateTasksPosition()
    {
        const float distance = 0.45f;
        const float degree = 30;
        const float yOffset = 0.1f;
        for (int i = 0; i < _taskHUDs.Count; i++)
        {
            float offset = (float) i + 0.5f - _taskHUDs.Count * 0.5f;
            Vector3 position = VectorHelper.DegreesToVector2(270 + degree * offset) * distance + new Vector2(0, yOffset);
            position.z = -1;
            _taskHUDs[i].targetPosition = transform.position + position;
        }
    }
}
