using UnityEngine;

public class Expander : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {        
        transform.localScale = new Vector3(transform.localScale.x + _speed, transform.localScale.y + _speed, transform.localScale.z + _speed);
    }
}
