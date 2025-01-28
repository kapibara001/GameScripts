using UnityEngine;


// Так как мы повесили данный скрипт прямо на объект, в нем мы можем напрямую обращаться к его "характеристикам"
public class Changecolor : MonoBehaviour
{
    private MeshRenderer _meshRenderer;

    private void Awake() {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update() {
        if (Input.GetKeyUp(KeyCode.A)) {
            /* _meshRenderer.GetComponent<MeshRenderer>().material.color = Color.cyan; Если бы мы не создали переменную в 10 строке, куда поместили 
            "путь" до нужной характеристики, надо было бы писать так. Подключения как в 10 строке лучше создавать в методе Awake, чтобы все подключения происходили при запуске игры */
            _meshRenderer.material.color = Color.red; 
        } else if(Input.GetKeyUp(KeyCode.S)) {
            _meshRenderer.material.color = Color.white;
        } else if (Input.GetKeyDown(KeyCode.D)) {
            _meshRenderer.material.color = Color.blue;
        }
    }
}