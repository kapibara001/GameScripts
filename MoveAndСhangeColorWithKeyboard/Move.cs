using UnityEngine;
using UnityEngine.UIElements;

public class Move : MonoBehaviour
{
    public float speed = 5.0f;
    private void Update() {
        // if (Input.GetKey(KeyCode.UpArrow)){
        //     transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
        // }
        // if (Input.GetKey(KeyCode.DownArrow)) {
        //     transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.RightArrow)){
        //     transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        // }
        // if (Input.GetKey(KeyCode.LeftArrow)){
        //     transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        // }

    // 2 способ заставить оюъект двигаться
        float v = Input.GetAxis("Vertical"); // В юнити престь некие предустановленные отслежования, и Vertical является одним их них(отслеживает стрелочку вверх и вниз, W и S). 
        // В результате работы игры сюда(в переменную v) будет постоянно устанавливаться число в диапазоне от -1 до 1, и когда ничего не нажимают - 0
        transform.Translate(new Vector3(2, 0, 0) * v * Time.deltaTime);

        float h = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(0, -2, 0) * h * Time.deltaTime);
    }   
}
