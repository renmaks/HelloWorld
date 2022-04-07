using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private List<GameObject> _cubesList;
    private CubeSpawner _spawner;

    public static int CUBES_COUNT { get; private set; }

    private void Awake()
    {
        _cubesList = new List<GameObject>();
        _spawner = GetComponent<CubeSpawner>();
    }

    private void OnSpawned()
    {
        CUBES_COUNT++;
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
