using UnityEngine;

public class WallDestroy : MonoBehaviour 
{
    CubeSpawner _cubes;

    private void Start()
    {
        _cubes = GameObject.FindGameObjectWithTag("CubeSpawner").GetComponent<CubeSpawner>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wall") 
        {   
            _cubes.listCubes.RemoveAt(_cubes.listCubes.Count - 1);
            Destroy(gameObject);
        };
    }
}
