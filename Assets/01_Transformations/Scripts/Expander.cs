using UnityEngine;

public class Expander : MonoBehaviour
{
    [SerializeField] private float _rateIncrease;

    private void FixedUpdate()
    {        
        transform.localScale = new Vector3(transform.localScale.x + _rateIncrease, transform.localScale.y + _rateIncrease, transform.localScale.z + _rateIncrease);
    }
}
