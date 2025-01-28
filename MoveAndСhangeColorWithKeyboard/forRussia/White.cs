using UnityEngine;

public class White : MonoBehaviour
{
    public MeshRenderer _mRend;

    private void Awake() {
        _mRend = GetComponent<MeshRenderer>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            _mRend.material.color = Color.white;
        }
    }
    
}
