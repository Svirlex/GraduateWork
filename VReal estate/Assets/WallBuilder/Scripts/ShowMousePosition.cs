using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ShowMousePosition : MonoBehaviour
{
    public GameObject mousePointer;
    [SerializeField] float stepSize = 1;



    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        mousePointer.transform.position = snapPosition(getWorldPoint());
    }
    public Vector3 getWorldPoint()
    {
        int layerMask = ~(1 << 3);
        Camera cam = GetComponent<Camera>();
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            return hit.point;
        }
        return Vector3.zero;
    }

    public Vector3 snapPosition(Vector3 original)
    {
        Vector3 snapped;
        snapped.x = Mathf.Floor(original.x + stepSize);
        snapped.y = Mathf.Floor(original.y + 0.5f);
        snapped.z = Mathf.Floor(original.z + stepSize);
        return snapped;
    }
}