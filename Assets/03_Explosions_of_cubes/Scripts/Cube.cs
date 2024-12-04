using UnityEngine;

public class Cube : MonoBehaviour
{
    [field: SerializeField] public float Force { get; private set; }
    [field: SerializeField] public float Radius { get; private set; }
    [field: SerializeField] public float ChangeSeparation { get; private set; }

    public Vector3 Position { get; private set; }

    public void ChangeParameters(int value)
    {
        Force *= value;
        Radius *= value;
        ChangeSeparation /= value;
        transform.localScale /= value;
    }

    public void ChangeColor(Material material)
    {
        GetComponent<Renderer>().material = material;
    }

    private void Awake()
    {
        Position = transform.position;
    }
}
