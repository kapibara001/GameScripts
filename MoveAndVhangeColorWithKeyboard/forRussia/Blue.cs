using UnityEngine;

public class Blue : MonoBehaviour
{
    private MeshRenderer _mRend;

    private void Awake() {
        _mRend = GetComponent<MeshRenderer>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.W)) {
            _mRend.material.color = Color.blue;
        }
    }
}
