using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    private void FixedUpdate()
    {
        var nextPosition = transform.position;

        nextPosition.x += _speed;
        transform.Translate(Vector3.forward * _speed);
    }
}
