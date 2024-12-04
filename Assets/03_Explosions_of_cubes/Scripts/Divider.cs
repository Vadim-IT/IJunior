using UnityEngine;

[RequireComponent(typeof(CubesCreater))]
[RequireComponent(typeof(Cube))]
public class Divider : MonoBehaviour
{
    private Exploder _exploder;

    public void UseActions()
    {
        Destroy(gameObject);
        Separation();
    }

    private void Separation()
    {
        var cube = GetComponent<Cube>();
        int minValue = 0;
        int maxValue = 100;
        int value = Random.Range(minValue, maxValue);
        _exploder = new Exploder();

        if (value < cube.ChangeSeparation)
            _exploder.Explode(cube.Radius, cube.Force, cube.Position, GetComponent<CubesCreater>().CreateCubes());
        else
            _exploder.Explode(cube.Radius, cube.Force, cube.Position);
    }    
}
