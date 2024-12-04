using System.Collections.Generic;
using UnityEngine;

public class Exploder
{
    public void Explode(float radius, float force, Vector3 position, List<Collider> explodeColliders)
    {
        for (int i = 0; i < explodeColliders.Count; i++)
        {
            Rigidbody rigidbody = explodeColliders[i].attachedRigidbody;
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(force, position, radius);
            }
        }
    }

    public void Explode(float radius, float force, Vector3 position)
    {
        Collider[] explodeColliders = Physics.OverlapSphere(position, radius);

        for (int i = 0; i < explodeColliders.Length; i++)
        {
            Rigidbody rigidbody = explodeColliders[i].attachedRigidbody;

            if (rigidbody)
            {
                rigidbody.AddExplosionForce(force, position, radius);
            }
        }
    }
}
