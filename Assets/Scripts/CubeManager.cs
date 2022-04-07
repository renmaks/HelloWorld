using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private List<GameObject> _cubesList;
    private CubeSpawner _spawner;

    private void Awake()
    {
        _cubesList = new List<GameObject>();
        _spawner = GetComponent<CubeSpawner>();
    }

    private void OnSpawned()
    {
        Debug.Log("popka");
    }

    private void OnEnable()
    {
        _spawner.Spawned += OnSpawned;

    }

    private void OnDisable()
    {
        _spawner.Spawned -= OnSpawned;

    }
}
