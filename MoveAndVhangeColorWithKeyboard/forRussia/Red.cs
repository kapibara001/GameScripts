using UnityEngine;

public class Red : MonoBehaviour
{
    private MeshRenderer _mRend;

    private void Awake() {
        _mRend = GetComponent<MeshRenderer>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            _mRend.material.color = Color.red;
        }
    }
}
