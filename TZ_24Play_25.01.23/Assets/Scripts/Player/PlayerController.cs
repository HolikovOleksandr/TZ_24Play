using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 _targetPosition;

    [SerializeField] float _stepSpeed;
    [SerializeField] float _moveSpeed;

    [SerializeField] float _positionOffset;
    [SerializeField] float _sideLinesCount;

    Vector2 _startTouchPosition;
    Vector2 _endTouchPosition;
    Vector2 _currentPosition;

    [SerializeField] float _swipeRange;
    [SerializeField] float _tapRange;

    bool _stopTouch;

    private void Update() 
    {   
        SwipeMovement();
        KeyboardMovement();

        _targetPosition.x = Mathf.Clamp(_targetPosition.x, -_sideLinesCount, _sideLinesCount);
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed);
    }

    private void FixedUpdate()
    {   
        _targetPosition.z = transform.position.z + _stepSpeed;
        _targetPosition.z += _moveSpeed;
    }
    
    public void SwipeMovement()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            _startTouchPosition = Input.GetTouch(0).position;
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            _currentPosition = Input.GetTouch(0).position;                 
            Vector2 distanse = _currentPosition - _startTouchPosition;

            if(!_stopTouch)
            {
                if(distanse.x < -_swipeRange)
                { 
                    _stopTouch = true;
                    LeftStep();
                }
                else if(distanse.x > -_swipeRange)
                { 
                    _stopTouch = true;
                    RightStep();
                }
            }
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            _stopTouch = false;
            _endTouchPosition = Input.GetTouch(0).position;
            Vector2 distance = _endTouchPosition - _startTouchPosition;
        }     
    }

    public void KeyboardMovement()
    {   
        if(Input.GetKeyDown(KeyCode.A)) LeftStep();
        else if(Input.GetKeyDown(KeyCode.D)) RightStep();
    }

    private void LeftStep()
    {
        _targetPosition.x -= _positionOffset;
    }
    private void RightStep()
    {
        _targetPosition.x += _positionOffset;
    }
}
