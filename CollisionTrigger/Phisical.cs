using UnityEngine;

public class Phisical : MonoBehaviour
{
    // За физику объектов отвечают такие компоненты на объекте, как Box Colider(кго колизия) и Rigidbody(сама физика падения и прочего)
    // Так как мы используем физику объектов, лучше использовать метод FixedUpdate(). Он вызывается через определенные промежутки времени

    public float speed = 100f, hSpeed = 100f, _trust = 1000;
    private Rigidbody _rBody;

    private void Awake() {
        _rBody = GetComponent<Rigidbody>();
    }                                                           

    private void FixedUpdate() {
    // Благодаря тому, что мы прописали двжиние именно таким образом(через компоненты RigidBody), теперь объект двигается не из-за изменения platform, а при помощи Rigidbody, что открывает нам возможности проверок на какие либо соприкосовения и прочее
        float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime; // fixedDeltaTime стоит использовать если мы работает в fixedUpdate()
        float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;

        _rBody.velocity = transform.TransformDirection(new Vector3(h, 0, v)); // velocity - Что-то в духе position в модуле Platform
    }

    private void OnCollisionEnter(Collision other) { // Метод, который срабатывает в тот момент, когда объект чего-то касается. other - объект, с которым соприкоснулись. Collision - его тип
        if (other.gameObject.name != "Platform") {
            Debug.Log("You collided");
            if (other.gameObject.name == "Wall") { // Если мы касаемся объекта с именеем Wall(стена) - мы ничтожаем этот объект
                other.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
                // Destroy(other.gameObject);
                Debug.Log("Стена покрашена");

                _rBody.AddForce(new Vector3(0, 1, 0) * _trust);
            }
        }
    }

    private void OnCollisionStay(Collision other) { // Тоже метод, связанный с касаниями, колизией. Вызывается все время, пока объект чего-то касается
        if (other.gameObject.name != "Platform") Debug.Log("You colliding");
    }

    private void OnCollisionExit(Collision other) { // Сработает тогда, когда мы перестанет касаться предмета
        if (other.gameObject.name != "Platform") Debug.Log("You stoped");
    }
}
