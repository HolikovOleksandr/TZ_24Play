using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    [SerializeField] GameObject _platformPrefab;

    const float NEXT_PLATFORM_RANGE = 120f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        // if(other.gameObject.CompareTag("Player"))
        {
            Vector3 spawnPosition = transform.position;
            spawnPosition.z += NEXT_PLATFORM_RANGE;
            Instantiate(_platformPrefab, spawnPosition, Quaternion.identity, null);

            Destroy(gameObject);
        }    
    }
}
