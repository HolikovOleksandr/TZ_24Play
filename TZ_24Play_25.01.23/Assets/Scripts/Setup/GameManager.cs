using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] platforms; // Migrate this to platform spawner

    public void LoadLevel()
    {
        SceneManager.LoadScene("GameScene");
        Debug.Log("Load new scene");    
    }

    public void Exit()
    {
        Application.Quit();
    }
}
