using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float _speed;
    private Rigidbody _rb;
    private uint _score = 0;
    public TMP_Text _textScore; // Поле для управления надписью с количеством забранных монеток

    private void Awake() {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        float v = Input.GetAxis("Vertical") * _speed * Time.fixedDeltaTime;
        float h = Input.GetAxis("Horizontal") * _speed * Time.fixedDeltaTime;

        _rb.velocity = new Vector3(h, 0, v); // Без энерции
        // _rb.AddForce(new Vector3(h, 0, v)); // С "энерцией"
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "CoinArray") {
            Destroy(other.gameObject);

            _score += 1;
            if (_score != 5) _textScore.text = $"Score: {_score}"; // Измнение надписи
            else _textScore.text = $"Вы собрали {_score} очков! Вы выиграли!";
        }
    }
}
