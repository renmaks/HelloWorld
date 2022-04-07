using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRedactor : MonoBehaviour
{
    private float _scalingFactor = 0.95f;
    private GameObject cube;

    private void Awake()
    {
        cube = this.gameObject;
    }

    private void Start()
    {
        cube.name = "Cube " + CubeManager.CUBES_COUNT;
    }
}
