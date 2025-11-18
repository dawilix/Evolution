using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    // Имя сцены для загрузки (задаётся в Инспекторе)
    public string map;

    // Метод, вызываемый при входе в триггер
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что в триггер вошёл объект с тегом "Player"
        if (other.CompareTag("Player"))
        {
            // Загружаем новую сцену
            SceneManager.LoadScene(map);
        }
    }
}
