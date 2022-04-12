using UnityEngine;
using UnityEngine.Events;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    public static UnityEvent<GameObject> ON_SPAWNED = new UnityEvent<GameObject>();

    private void Update()
    {
        SpawnCube();
    }

    private void SpawnCube()
    {
        GameObject cube = Instantiate(_cubePrefab);
        ON_SPAWNED.Invoke(cube);
    }
}
