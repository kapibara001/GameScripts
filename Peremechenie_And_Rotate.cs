using System;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class Peremechenie_And_Rotate : MonoBehaviour
{
    // public GameObject cubeObj; // С помощью GameObject создали возомжность заключить объект в переменную в интерфейсе unity через Main Camera. cabeobj - имя объекта, может быть вообще любым
    // public GameObject SecondGameObj;
    // public GameObject Sphere;


    // public Transform Target; // Создаем поле, которое сразу берет данные из компонента Transform в определенном игровом объекте и заключается сюда. Можно будет обращаться к нему как Target.position, Target.rotate
    // То есть в это поле(именно Transform) нельзя подставить объект, где нет данных из интерфейса Transform
    
    // public Light _lighttt; // Хранит все поля из интерфейса Light, то есть _light.type, _light.range и прочие. То есть когда мы определенный объект подставляем под эту переменную в unity, этот объект
    // просто берет все те параметры, которые мы дальше установили по ходу формирования игры. Просто набор характеристик 


    // public GameObject[] objs = new GameObject[3]; // Создание целого списка из объектов


    // private void Start() {
    //     // cubeObj.SetActive(false); // При старте игры объект становится неактивным(исчезает)

    //     Sphere.GetComponent<Transform>().position = new Vector3(2.83f, 0.374f, 7.71f); /* Обращение к полю интерфейса Transform, где содержится строка position. В нее надо 
    //     Передать 3 координаты, с чем нам помогает специальный объект на основе класса Vector3. Идет перемещение на такую-то координату */
   
    //     // cubeObj.GetComponent<Transform>().rotation = new Vector3(5.971f, -46.748f, -44.654f); почему то не работает

    //     // Target.position = new Vector3(15, 2, 5); // Взаимодействие с компонентом Transform нужного нам объекта
    //     _lighttt.intensity = 5; 
    //     _lighttt.range = 7.12f;

    //     objs[2] = cubeObj;
    //     for (int i = 0; i<objs.Length; i++) { // Перебор элементов
    //         // objs[i].SetActive(false);
    //     }     
    //     // foreach (GameObject obj in objs) { 
    //     //     obj.SetActive(false);
    // }


    public Transform[] objsTransforms = new Transform[3];
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float speedRotate = 50.0f;
    

    public void Start() {
        Debug.Log("Игра запущена.");
    }

    public void Update() { // Какие-то действия надо делать в этом блоке т.к мы же меняем игру каждый кадр, и каждое изменение происходит эта функция 
        for (int i = 0; i < objsTransforms.Length; i+=2) {
            if (objsTransforms[i] != null) { // Проверка на то, существует ли этот объект вообще (не равен null)
                objsTransforms[i].Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime); /* Это паттерн задания скорости перемещения объекта (Translate).
                Метод Transform.Translate используется для перемещения объекта в пространстве на 
                заданное расстояние. Этот метод изменяет положение объекта относительно его текущей позиции. Он часто применяется для реализации движения объектов, таких как 
                персонажи, камеры или другие игровые элементы. 
                Для того,чтобы двиаглось плавно, нужно умножить на Time.deltaTime*/
                objsTransforms[i].Rotate(new Vector3(1, 0, 0) * speedRotate * Time.deltaTime); // Метод для вращения объектов. Задается как .Translate
            
                float posX = objsTransforms[i].position.x; // Заключаем в переменную позицию объекта по X
                if (posX > 10f) {
                    Destroy(objsTransforms[i].gameObject); // Уничтожаем объект не как часть его списка, а превращая его в отдельный игровой объект(.gameObject) и удаляя именно объект
                }
            }
        }

        for (int i = 1; i < objsTransforms.Length; i+=2) {
            if (objsTransforms[i] != null) {
                objsTransforms[i].Translate(new Vector3(-1,0,0) * speed * Time.deltaTime);
                objsTransforms[i].Rotate(new Vector3(-1, 0, 0) * speedRotate * Time.deltaTime); // Вращение предмета
            
                float posX = objsTransforms[i].position.x;
                // if ( posX > 10f && objsTransforms[i].gameObject.name == "Sphere" || posX < -10f && objsTransforms[i].gameObject.name == "Sphere") {
                if ( posX < -10f && objsTransforms[i].gameObject.name == "Sphere")
                    Destroy(objsTransforms[i].gameObject);
            }
        }
    }
}
