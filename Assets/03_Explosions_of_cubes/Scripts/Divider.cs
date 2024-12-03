using UnityEngine;

[RequireComponent(typeof(Exploder))]
[RequireComponent(typeof(CubesCreater))]
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
            GetComponent<Exploder>().Explode(Radius, Force, GetComponent<CubesCreater>().CreateCubes());
        else
            GetComponent<Exploder>().Explode(Radius, Force);
    }    
}
