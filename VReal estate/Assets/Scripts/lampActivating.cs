using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampActivating : MonoBehaviour
{
    [SerializeField] Light _light;
    [SerializeField] Material offMaterial;
    [SerializeField] Material onMaterial;

    [SerializeField] GameObject _cube;

    public bool isActive;
    void Start()
    {
        
    }


    void Update()
    {
        if (isActive)
        {
            _cube.GetComponent<Renderer>().material = onMaterial;
            _light.enabled = true;
        }
        else
        {
            _cube.GetComponent<Renderer>().material = offMaterial;
            _light.enabled = false;
        }
    }
}
