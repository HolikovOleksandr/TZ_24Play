using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    GameManager _gameManager;

    public GameObject cubePrefab;
    public List<GameObject> listCubes = new List<GameObject>();

    [SerializeField] float _newCubeOffsetY;

    private void Start()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        CreateCube();
    }

    private void Update() 
    {
        if(listCubes.Count == 0) _gameManager.LoadLevel();
        Invoke("DebugGameScore", 2.5f);

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bonuse")
        { 
            Destroy(other.gameObject);
            CreateCube();
        }
        else if(other.gameObject.tag == "Wall") DestroyCube();
    }

    private void CreateCube()
    {
        Vector3 cubePosition = Vector3.zero;
        if(listCubes.Count > 0) 
        {
            cubePosition = listCubes[listCubes.Count - 1].transform.position + new Vector3(0f, _newCubeOffsetY, 0f);
        }

        GameObject gameObject = Instantiate(cubePrefab, cubePosition, Quaternion.identity);
        gameObject.transform.SetParent(transform);
        listCubes.Add(gameObject);                 
    }

    private void DestroyCube()
    {
        Destroy(listCubes[listCubes.Count - 1].gameObject);
        listCubes.RemoveAt(listCubes.Count - 1);
    }

    private void DebugGameScore()
    {
        Debug.Log(listCubes.Count);
    }
}
