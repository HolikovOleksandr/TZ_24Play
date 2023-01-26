using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    GameManager _gameManager;

    [SerializeField] float _nextSpawnPlatformRange;

    private void Start()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Vector3 spawnPosition = transform.position;
            spawnPosition.z += _nextSpawnPlatformRange;

            Instantiate
            (
                _gameManager.platforms[Random.Range(0, _gameManager.platforms.Length)], 
                spawnPosition, 
                Quaternion.identity, 
                null
            );
            Destroy(gameObject);
        }    
    }
}
