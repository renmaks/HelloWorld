using UnityEngine;

public class CubeRedactor : MonoBehaviour
{
    private float _scalingFactor = 0.95f;
    private GameObject _cube;
    private Renderer _cubeRend;

    private void Awake()
    {
        _cube = this.gameObject;
        _cubeRend = this.GetComponent<Renderer>();
    }

    private void Start()
    {
        _cube.name = "Cube " + CubeManager.CUBES_COUNT;
        ChangeColorOfCube();
        ChangePositionOfCube();
    }

    private void Update()
    {
        ChangeScaleOfCube();
    }

    private void ChangeColorOfCube()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        _cubeRend.material.color = c;
    }

    private void ChangePositionOfCube()
    {
        _cube.transform.position = Random.insideUnitSphere;
    }

    private void ChangeScaleOfCube()
    {
        float tScale = _cube.transform.localScale.x;
        tScale *= _scalingFactor; 
        _cube.transform.localScale = Vector3.one * tScale;

        if (tScale <= 0.1f)
        {
            Destroy(gameObject);
        }
    }
}
