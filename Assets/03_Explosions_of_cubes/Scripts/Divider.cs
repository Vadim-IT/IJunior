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
            gameObject.GetComponent<Exploder>().Explode(Radius, Force, gameObject.GetComponent<CubesCreater>().CreateCubes());
        else
            gameObject.GetComponent<Exploder>().Explode(Radius, Force);
    }    
}
