using System.Collections.Generic;
using UnityEngine;

public class Divider : MonoBehaviour
{
    public float Radius = 100f;
    public float Force = 250f;
    public float ChanceSeparation = 100;

    public void UseActions()
    {
        Destroy(gameObject);
        Separation();
    }

    private void Separation()
    {
        int minValue = 0;
        int maxValue = 101;
        int value = Random.Range(minValue, maxValue);

        if (value < ChanceSeparation)
            CreateCubes();
        else
            Explode();
    }

    private void CreateCubes()
    {
        int minValue = 2;
        int maxValue = 7;
        int value = Random.Range(minValue, maxValue);
        List<Collider> explodeColliders = new List<Collider>();        

        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x / 2f, gameObject.transform.localScale.y / 2f, gameObject.transform.localScale.z / 2f);
        gameObject.GetComponent<Divider>().ChanceSeparation /= 2;
        gameObject.GetComponent<Divider>().Radius *= 2;
        gameObject.GetComponent<Divider>().Force *= 2;

        for (int i = 0; i < value; i++)
        {
            Material material = new Material(Shader.Find("Universal Render Pipeline/Lit"));
            material.color = Random.ColorHSV();
            gameObject.GetComponent<Renderer>().material = material;
            explodeColliders.Add(Instantiate(gameObject).GetComponent<Collider>());
        }

        Explode(explodeColliders);
    }

    private void Explode(List<Collider> explodeColliders)
    {
        for (int i = 0; i < explodeColliders.Count; i++)
        {
            Rigidbody rigidbody = explodeColliders[i].attachedRigidbody;
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(Force, transform.position, Radius);
            }
        }
    }

    private void Explode()
    {
        Collider[] explodeColliders = Physics.OverlapSphere(transform.position, Radius);

        for (int i = 0; i < explodeColliders.Length; i++)
        {
            Rigidbody rigidbody = explodeColliders[i].attachedRigidbody;

            if (rigidbody)
            {
                rigidbody.AddExplosionForce(Force, transform.position, Radius);
            }
        }
    }
}
