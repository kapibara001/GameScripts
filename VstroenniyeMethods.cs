// using System.Xml.Serialization;
using UnityEngine;

public class VstroenniyeMethods : MonoBehaviour 
{
    private void Awake() { // Awake() {} очень схож с методом старт, но выполняется он ДО метода Start() {}
        Debug.Log("Awake");
    }

    private void Start() {
        Debug.Log("Start");
    }

    private void Update() { // Метод вызывается каждый frame, пока игра запущена, на протяжении всего периода игры, очень много раз в секунду. Применим в том случае, если надо передвинуть предмет и тд
        Debug.Log("Update");
    }

    private void LateUpdate() { // Что-то в духе метода Start, то есть сначала срабатывает Update, а потом LateUpdate, то есть когда заканчиваетсяч сам Frame
        Debug.Log("LateUpdate");
    }
    
    private void FixedUpdate() { // Как Update, но разница в том, что Update вызывется каждый фрейм, а fixedUpdate не зависит от фреймов, а выполняется через определеныое количество времени(200мс)
        Debug.Log("FixedUpdate");
    }

    private void OnEnable() { // Отслеживание включения и выключения игры. Тоже сработает до Start, но после Awake, и в конце, когда игра будет выключена
        Debug.Log("OnEnable. Game started");
    }

    private void OnDestroy() { // Выполняется, когда какой-либо объект уничтожается, или по-другому игра выключается
        Debug.Log("Game stopped");
    }
}