using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    GameManager _gameManager;

    public GameObject cubePrefab;
    public List<GameObject> listCubes = new List<GameObject>();

    [SerializeField] Vector3 newPrefabPosition;

    private void Start()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        CreateCube();
    }

    private void Update() 
    {
        if(listCubes.Count < 0) _gameManager.LoadLevel();
        // Debug.Log(listCubes.Count);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bonuse")
        { 
            Destroy(other.gameObject);
            CreateCube();
        } 
    }

    // Added cube to list and created one more game object to stuck
    private void CreateCube()
    {
        Vector3 cubePosition = Vector3.zero;

        if(listCubes.Count > 0)
            cubePosition = listCubes[listCubes.Count - 1].transform.position + newPrefabPosition;
                   
        GameObject gameObject = Instantiate(cubePrefab, cubePosition, Quaternion.identity);
        gameObject.transform.SetParent(transform);
        listCubes.Add(gameObject);                  
    }
}
