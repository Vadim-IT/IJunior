using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    public void Explode(float radius, float force, List<Collider> explodeColliders)
    {
        for (int i = 0; i < explodeColliders.Count; i++)
        {
            Rigidbody rigidbody = explodeColliders[i].attachedRigidbody;
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(force, transform.position, radius);
            }
        }
    }

    public void Explode(float radius, float force)
    {
        Collider[] explodeColliders = Physics.OverlapSphere(transform.position, radius);

        for (int i = 0; i < explodeColliders.Length; i++)
        {
            Rigidbody rigidbody = explodeColliders[i].attachedRigidbody;

            if (rigidbody)
            {
                rigidbody.AddExplosionForce(force, transform.position, radius);
            }
        }
    }
}
