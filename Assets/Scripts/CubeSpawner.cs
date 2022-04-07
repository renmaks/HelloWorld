using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    public event Action Spawned = default;

    private void Update()
    {
        SpawnCube();
    }

    private void SpawnCube()
    {
        GameObject cube = Instantiate(_cubePrefab);
        if (Spawned != null)
            Spawned();
    }
}
