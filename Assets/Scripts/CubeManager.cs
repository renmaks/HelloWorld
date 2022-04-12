using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _cubesList;
    [SerializeField] private List<GameObject> _cubesToRemove;
    private CubeSpawner _cubeSpawner;
    private GameObject _cube;

    public static int CUBES_COUNT { get; private set; }

    private void Awake()
    {
        _cubesList = new List<GameObject>();
        _cubeSpawner = GetComponent<CubeSpawner>();
    }

    private void LateUpdate()
    { 
        AddCubeToCubesToRemoveListAndDestroy();
    }

    private void OnSpawned()
    {
        CUBES_COUNT++;
        AddCubeToCubesList();
    }

    private void AddCubeToCubesList()
    {
        _cube = GameObject.FindGameObjectWithTag("Cube");
        _cubesList.Add(_cube);
    }

    private void AddCubeToCubesToRemoveListAndDestroy()
    {
        foreach (var cube in _cubesList)
        {
            if (cube != null && cube.transform.localScale.x <= 0.1f)
                _cubesToRemove.Add(cube);
            else
                continue;
        }

        foreach (var cube in _cubesToRemove)
        {
            _cubesList.Remove(cube);
            Destroy(cube);
        }
    }

    private void OnEnable()
    {
        _cubeSpawner.Spawned += OnSpawned;

    }

    private void OnDisable()
    {
        _cubeSpawner.Spawned -= OnSpawned;
    }
}
