using UnityEngine;

public class FBMovement : MonoBehaviour
{
    private int _maxMovement = 20;
    private int _step = 1;

    private void FixedUpdate()
    {
        var nextPosition = transform.position;

        nextPosition.z += _step;
        transform.position = nextPosition;

        if (transform.position.z == _maxMovement)
        {
            _maxMovement = -_maxMovement;
            _step = -_step;
        }
    }
}
