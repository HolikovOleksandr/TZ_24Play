using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] platforms; // Migrate this to platform spawner

    public void LoadLevel()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void EndLevel()
    {
        SceneManager.LoadScene("EndGame");
    }
}
