using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] platforms; // Migrate this to platform spawner

    CubeSpawner _cubes;

    private void Start()
    {
        _cubes = GameObject.FindGameObjectWithTag("CubeSpawner").GetComponent<CubeSpawner>();    
    }

    public void RestartLevel()
    {
        Debug.Log("YOU LOSE!");
    }
}
