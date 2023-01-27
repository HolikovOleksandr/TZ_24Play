using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject _target;
    
    [Header("Position Offset")]
    [SerializeField] float _yPositionOffset;
    [SerializeField] float _zPositionOffset;
    
    [Header("Rotation Offset")]
    [SerializeField] float _xRotationOffset;
    [SerializeField] float _yRotationOffset;

    private void Start()
    {
        _target = GameObject.FindWithTag("CubeSpawner");    
    }

    private void Update()
    {        
        transform.position = new Vector3
        (
            transform.position.x, 
            _target.transform.position.y + _yPositionOffset,
            _target.transform.position.z + _zPositionOffset
        ); 

        Vector3 rotationOffset = new Vector3
        (
            _target.transform.rotation.x + _xRotationOffset,
            _target.transform.rotation.y + _yRotationOffset
        );    

        transform.rotation = Quaternion.Euler(rotationOffset);
    }
}
