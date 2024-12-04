using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class CubesCreater : MonoBehaviour
{
    public List<Collider> CreateCubes()
    {
        var cube = GetComponent<Cube>();
        int changeValue = 2;
        int minValue = 2;
        int maxValue = 7;
        int value = Random.Range(minValue, maxValue);
        List<Collider> explodeColliders = new List<Collider>();

        cube.ChangeParameters(changeValue);

        for (int i = 0; i < value; i++)
        {
            Material material = new Material(Shader.Find("Universal Render Pipeline/Lit"));
            material.color = Random.ColorHSV();
            cube.ChangeColor(material);

            if (Instantiate(gameObject).TryGetComponent<Collider>(out Collider collider))
                explodeColliders.Add(collider);
        }

        return explodeColliders;
    }
}
