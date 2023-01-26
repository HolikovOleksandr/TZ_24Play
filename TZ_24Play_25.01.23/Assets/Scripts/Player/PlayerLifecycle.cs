using UnityEngine;

public class PlayerLifecycle : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;

    [SerializeField] int _healthPoints;
    [SerializeField] int _healthBonuse;
    [SerializeField] int _healthDamage;
    int _currentHealthPoints;

    private void Start() 
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();    

        _currentHealthPoints = _healthPoints;
    }

    private void Update()
    {
        Death();  
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bonus")
        { 
            _currentHealthPoints += _healthBonuse;
            // _currentHealthPoints += 1;
            Debug.Log("Health: " + _currentHealthPoints);
        } 
        else if(other.gameObject.tag == "Barrier")
        { 
            _currentHealthPoints -= _healthDamage;
            // _currentHealthPoints -= 1;
            Debug.Log("Health: " + _currentHealthPoints);
        }       
    }

    private void Death()
    {
       if(_currentHealthPoints == 0) _gameManager.EndGame();
    }
}
