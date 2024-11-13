using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField][Range (0, 2)] private float _speed = 1;

    private float _maxScaling = 15;
    private float _step = 1;

    private void FixedUpdate()
    {
        transform.localScale = new Vector3(transform.localScale.x + _speed * _step, transform.localScale.y + _speed * _step, transform.localScale.z + _speed * _step);

        if (transform.localScale.x > _maxScaling && _maxScaling > 0)
        {
            _maxScaling = -_maxScaling;
            _step = -_step;
        }
        else if (transform.localScale.x < _maxScaling && _maxScaling < 0)
        {
            _maxScaling = -_maxScaling;
            _step = -_step;
        }
    }
}
