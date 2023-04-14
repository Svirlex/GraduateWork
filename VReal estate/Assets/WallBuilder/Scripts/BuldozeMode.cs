using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuldozeMode : MonoBehaviour
{
    [SerializeField] bool buldozeMode = false;
    


    void Start()
    {
  
    }


    void Update()
    {
        if (buldozeMode)
        {
            GetComponent<ShowMousePosition>().enabled = false;
            GetComponent<createFence>().enabled = false;

            int layerMask = 1 << 3;
            Camera cam = GetComponent<Camera>();
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Destroy(hit.collider.transform.root.gameObject);
                }
            }

        }
        else
        {
            GetComponent<ShowMousePosition>().enabled = true;
            GetComponent<createFence>().enabled = true;
        }
    }
}
