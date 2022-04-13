using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    public static int CUBES_COUNT { get; private set; }

    private void Update()
    {
        SpawnCube();
    }

    private void SpawnCube()
    {
        GameObject cube = Instantiate(_cubePrefab);
        CUBES_COUNT++;
    }
}
