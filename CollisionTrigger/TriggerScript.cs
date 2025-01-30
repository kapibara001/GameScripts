using Unity.VisualScripting;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Тригеры обычно делают невидимыми(убирают галочку с MeshRenderer). Нужны они для того, чтобы вызвать какое-то событие при достижении тригера(враги начнут гнаться и прочее)
    // Тригеры тоже имеют функции отслеживания событий (касание, убирание касания и прочие) и имеют такой же функционал, только называются они чуть-чуть по-другому
    private void OnTriggerEnter(Collider other) {// Когда только спорикоснемся
        if (other.gameObject.name == "EnemyTrigger") Debug.Log("RUUUUN!!!!! Enemy is BEHIND YOU!!!");
    }

    private void OnTriggerExit(Collider other) { // Когда только отойдем от триггера
        Destroy(gameObject); // Так как мы поместили скрипт на самого игрока, чтобы его удалить, надо просто обратиться к gameObject. Если бы мы хотели удалить тригер, надо было бы прописать other.gameObject
        Debug.Log("You Died. Try Again, if you want...");
    }

    private void OnTriggerStay(Collider other) { // Все время, пока соприкасаемся с тригером
        if (other.gameObject.name == "EnemyTrigger") Debug.Log("RUUUN!!! WHY YOU STAYING?");
    }


}
