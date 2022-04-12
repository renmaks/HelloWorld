using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private GameObject _cube;

    public static int CUBES_COUNT { get; private set; }

    private void Awake()
    {
        CubeSpawner.ON_SPAWNED.AddListener(CubeSpawned);
    }

    private void CubeSpawned(GameObject cube)
    {
        CUBES_COUNT++;
    }

    private void OnDisable()
    {
        CubeSpawner.ON_SPAWNED.RemoveListener(CubeSpawned);
    }
}
