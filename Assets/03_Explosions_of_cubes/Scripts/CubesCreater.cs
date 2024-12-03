using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Divider))]
[RequireComponent(typeof(Collider))]
public class CubesCreater : MonoBehaviour
{
    public List<Collider> CreateCubes()
    {
        var dividerComponent = GetComponent<Divider>();
        int minValue = 2;
        int maxValue = 7;
        int value = Random.Range(minValue, maxValue);
        List<Collider> explodeColliders = new List<Collider>();

        transform.localScale = new Vector3(gameObject.transform.localScale.x / 2f, gameObject.transform.localScale.y / 2f, gameObject.transform.localScale.z / 2f);
        dividerComponent.ChanceSeparation /= 2;
        dividerComponent.Radius *= 2;
        dividerComponent.Force *= 2;

        for (int i = 0; i < value; i++)
        {
            Material material = new Material(Shader.Find("Universal Render Pipeline/Lit"));
            material.color = Random.ColorHSV();
            GetComponent<Renderer>().material = material;

            if (Instantiate(gameObject).TryGetComponent<Collider>(out Collider collider))
                explodeColliders.Add(collider);
        }

        return explodeColliders;
    }
}
