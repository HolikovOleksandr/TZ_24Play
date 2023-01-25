using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Vector3 _targetPosition;
    [SerializeField] float _stepSpeed;

    [SerializeField] float _moveSpeed;

    [SerializeField] float _positionOffset;
    [SerializeField] float _sideLinesCount;

    [SerializeField] KeyCode _leftStepKey;
    [SerializeField] KeyCode _rightStepKey;

    private void FixedUpdate()
    {   
        _targetPosition.z = transform.position.z + _stepSpeed;
        _targetPosition.z += _moveSpeed;
    }

    private void Update() 
    {
        if(Input.GetKeyDown(_leftStepKey)) 
            _targetPosition.x -= _positionOffset;

        else if(Input.GetKeyDown(_rightStepKey)) 
            _targetPosition.x += _positionOffset;

        _targetPosition.x = Mathf.Clamp(_targetPosition.x, -_sideLinesCount, _sideLinesCount);

        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed);
    }
}
