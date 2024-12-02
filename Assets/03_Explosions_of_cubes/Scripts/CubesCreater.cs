using System.Collections.Generic;
using UnityEngine;

public class CubesCreater : MonoBehaviour
{
    public List<Collider> CreateCubes()
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

        return explodeColliders;
    }
}
