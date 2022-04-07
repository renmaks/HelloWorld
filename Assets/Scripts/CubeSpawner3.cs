using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner3 : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefabVar;

    private List<GameObject> gameObjectList; // Будет хранить все кубики
    private float scalingFactor = 0.95f; // Коэффицент изменения масштаба каждого кубика в каждом кадре
    private int numCubes = 0; // Общее кол-во кубиков

    void Start()
    {
        // Инициализация списка List<GameObject>
        gameObjectList = new List<GameObject>();

    }

    void Update()
    {
        numCubes++; // Увеличить кол-во кубиков
        GameObject gObj = Instantiate<GameObject>(cubePrefabVar);

        // Следующие строки устанавливают некоторые значения в новом кубике
        gObj.name = "Cube " + numCubes;
        Color c = new Color(Random.value, Random.value, Random.value);
        gObj.GetComponent<Renderer>().material.color = c; // Получить компонент Renderer из gObj и назначить случайный цвет
        gObj.transform.position = Random.insideUnitSphere;

        gameObjectList.Add(gObj); // Добавить gObj в список кубиков

        List<GameObject> removeList = new List<GameObject>(); // Список removeList будет хранить кубики, подлежащию удалению из списка gameObjectList

        // Обход кубиков в gameObjectList
        foreach(GameObject goTemp in gameObjectList)
        {
            // Получить масштаб кубика
            float scale = goTemp.transform.localScale.x;
            scale *= scalingFactor; // Умножить на коэффицент scalingFactor
            goTemp.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1f) // Если масштаб меньше чем 0.1f...
                removeList.Add(goTemp); // добавить кубик в removeList
        }

        foreach (GameObject goTemp in removeList)
        {
            gameObjectList.Remove(goTemp); // Удалить кубик из gameObjectList
            Destroy(goTemp); // Удалить игровой объект кубика
        }
    }
}
