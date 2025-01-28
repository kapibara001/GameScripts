using UnityEngine;

public class OtslejivaniyeSobitiy : MonoBehaviour
{
    public Light _mainLight;

    public GameObject _sphere;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) { // Отслеживание действий игрока.
        //Если нажата кнопка Space(пробел) ...; Аналогичные GetKeyDown функции: GetKeyUp(когда клавиша отпускается), GetKeyDown(когда клавиша нажата), GetKey(когда клавиша зажата) и т.д
            _mainLight.enabled = !_mainLight.enabled; // Меняем значение на противоложное, каким бы оно не было
        }
    }

}
