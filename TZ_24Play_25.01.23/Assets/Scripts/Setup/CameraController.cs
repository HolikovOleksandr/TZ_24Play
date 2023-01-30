using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform _target;

    [SerializeField] Vector3 _offsetPosition; 
    [SerializeField] Vector3 _offsetRotation;

    private void Update()
    {
        transform.position = _target.position + _offsetPosition;
        transform.rotation = Quaternion.Euler( _offsetRotation);
    }
    
}
