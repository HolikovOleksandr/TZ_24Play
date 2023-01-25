using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] Transform _player;
    
    [Header("Position Offset")]
    [SerializeField] float _xPositionOffset;
    [SerializeField] float _yPositionOffset;
    [SerializeField] float _zPositionOffset;
    
    [Header("Rotation Offset")]
    [SerializeField] float _xRotationOffset;
    [SerializeField] float _yRotationOffset;

    private void Update()
    {        
        transform.position = new Vector3
        (
            _player.position.x + _xPositionOffset, // Not happy with it
            _player.position.y + _yPositionOffset,
            _player.position.z + _zPositionOffset
        ); 

        Vector3 rotationOffset = new Vector3
        (
            _player.rotation.x + _xRotationOffset,
            _player.rotation.y + _yRotationOffset
        );    

        transform.rotation = Quaternion.Euler(rotationOffset);
    }
}
