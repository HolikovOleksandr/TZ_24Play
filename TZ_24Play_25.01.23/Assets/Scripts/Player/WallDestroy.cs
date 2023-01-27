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

    // // Remove cube  :(
    // private void OnCollisionEnter(Collision other)
    // {
    //     if(other.gameObject.tag == "Wall" && other.gameObject != null) 
    //     {   
    //         // listCubes.RemoveAt(listCubes.Count - 1);
    //         // Destroy(gameObject.transform.GetChild(listCubes.Count - 1).gameObject);

    //         if (gameObject.transform.GetChild(listCubes.Count - 1).gameObject.tag == "Player")
    //             Destroy(gameObject.transform.GetChild(listCubes.Count - 1).gameObject);

    //         // DestroyCube(gameObject);
    //     };
    // }
}
