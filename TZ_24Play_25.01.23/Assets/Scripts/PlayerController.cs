using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _moveSpeed;

    [SerializeField] float _positionOffset;
    [SerializeField] float _sideLinesCount;

    [SerializeField] KeyCode _leftStepKey;
    [SerializeField] KeyCode _rightStepKey;

    private void FixedUpdate()
    {
        Vector3 position = transform.position;

        position.z += _moveSpeed;
        transform.position = position;   
    }

    private void Update() 
    {
        Vector3 position = transform.position;

        if(Input.GetKeyDown(_leftStepKey)) position.x -= _positionOffset;
        else if(Input.GetKeyDown(_rightStepKey)) position.x += _positionOffset;

        position.x = Mathf.Clamp(position.x, -_sideLinesCount, _sideLinesCount);

        transform.position = position;
    }
}
