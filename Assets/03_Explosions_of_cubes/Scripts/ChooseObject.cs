using UnityEngine;

public class ChooseObject : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Ray _ray;
        
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject objectHit = FindObject();

            if (objectHit.GetComponent<Divider>())
            {
                objectHit.GetComponent<Divider>().UseActions();
            }
        }
    }

    private GameObject FindObject()
    {
        GameObject objectHit = null;

        _ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.DrawRay(_ray.origin, _ray.direction);
        if (Physics.Raycast(_ray, out hit, Mathf.Infinity))
        {
            objectHit = hit.transform.gameObject;
        }

        return objectHit;
    }
}
