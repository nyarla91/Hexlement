using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Hex : MonoBehaviour
{
    [SerializeField] private AudioClip _placementSound;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject _structurePrefab;
    [SerializeField] private GameObject _towerPrefab;
    [SerializeField] private GameObject _placementParticles;
    private bool active
    {
        get => _spriteRenderer.enabled;
        set => _spriteRenderer.enabled = value;
    }

    private void Awake()
    {
        active = false;
        Turns.OnStructureSelected += Activate;
        Turns.OnStructureCancel += Deactivate;
        OnMouseExit();
    }

    private void Activate() => active = true;
    private void Deactivate() => active = false;

    private float Alpha
    {
        get => _spriteRenderer.color.a;
        set => _spriteRenderer.color = VectorHelper.SetA(_spriteRenderer.color, value);
    }

    private float _targetAlpha;

    private void OnMouseDown()
    {
        if (active && Tutorial.Hidden)
        {
            Resources.TilesInDeck--;
            SoundPlayer.Play(_placementSound, 1);
            GameObject prefab = Turns.NextStructure.type == StructureType.Tower ? _towerPrefab : _structurePrefab;
            ITile newTile = Instantiate(prefab, transform.position, Quaternion.identity).GetComponent<ITile>();
            newTile.Place(Turns.NextStructure);
            Instantiate(_placementParticles, VectorHelper.SetZ(transform.position, -0.5f), Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (Alpha > _targetAlpha)
            Alpha = Mathf.Lerp(Alpha, _targetAlpha, 2 * Time.deltaTime);
        else
            Alpha = Mathf.Lerp(Alpha, _targetAlpha, 10 * Time.deltaTime);
    }

    private void OnMouseOver() => _targetAlpha = 0.75f;

    private void OnMouseExit() => _targetAlpha = 0.3f;

    private void OnDestroy()
    {
        Turns.OnStructureSelected -= Activate;
        Turns.OnStructureCancel -= Deactivate;
    }
}
