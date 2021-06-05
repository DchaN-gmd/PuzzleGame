using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField] private KeyCode _keyOne;
    [SerializeField] private KeyCode _keyTwo;
    [SerializeField] private Vector3 _moveDeriction;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(_keyOne))
        {
            _rigidbody.velocity += _moveDeriction;
        }
        if (Input.GetKey(_keyTwo))
        {
            _rigidbody.velocity -= _moveDeriction;
        }
    }

}
