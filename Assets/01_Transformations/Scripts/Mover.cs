using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        var nextPosition = transform.position;

        nextPosition.x += _speed;
        transform.Translate(Vector3.forward * _speed);
    }
}
