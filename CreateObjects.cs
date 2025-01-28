using Unity.VisualScripting;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    /*
    Для создания объектов через C# скрипты мы должны создать prefab и дальше этот префаб перебросить в переменную в интерфейсе юнити
    */
    public GameObject[] obj;

    private void Start() {
        // GameObject cubeObj = Instantiate(obj, new Vector3(0, 5, 0), Quaternion.Euler(12f, -15f, 40f)) as GameObject; // Instantiate: Это метод в Unity, который создает экземпляр объекта (например, префаба) в сцене.
        // Паттерн задания: Instantiate(создаваемый объект, где спавнится(координаты), поворот(Quaternion.Euler(float x, y, z)))
        // При заключении в переменную нужно в конце добавить as GameOgject - заключаем как отдельный ировой объект

        // cubeObj.GetComponent<Transform>().position = new Vector3(0.7f, 0.7f, 16f);

        for (int i = 0; i < 5; i++) {
            Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(RandomCoordinate(), RandomCoordinate(), Random.Range(20, 40)), Quaternion.Euler(15f, -20f, 30f));
        }
    }

    private int RandomCoordinate() {
        return Random.Range(0, 10);
    }
}
