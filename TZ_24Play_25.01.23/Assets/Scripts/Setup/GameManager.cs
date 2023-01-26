using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] platforms;

    bool _gameEnded = false;
    [SerializeField] float _restartWaitingTime;

    public void EndGame()
    {
        if(_gameEnded == false)
        {
            _gameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", _restartWaitingTime);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
