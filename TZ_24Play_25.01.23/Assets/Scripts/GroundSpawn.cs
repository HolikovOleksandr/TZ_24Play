using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    GameManager _gameManager;

    const float NEXT_PLATFORM_RANGE = 300f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Vector3 spawnPosition = transform.position;
            spawnPosition.z += NEXT_PLATFORM_RANGE;

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
