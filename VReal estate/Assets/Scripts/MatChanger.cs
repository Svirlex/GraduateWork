using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatChanger : MonoBehaviour
{


    [SerializeField] Material[] _materialSet1;
    [SerializeField] Material[] _materialSet2;
    [SerializeField] int chosenMatSet;
    
    private int _counter = 0;
    Dictionary<int, Material[]> matSets = new Dictionary<int, Material[]>();


    

    void Start()
    {
        
        matSets.Add(0, _materialSet1);
        matSets.Add(1, _materialSet1);
        
    }

    private void Update()
    {
        foreach (Transform _material in this.transform)
        {
            Transform oim = transform.Find("Material" + _counter.ToString());

            foreach (Transform _objname in oim)
            {
                _objname.GetComponent<Renderer>().material = this.GetComponent<MatChanger>().matSets[chosenMatSet][_counter];
            }
            _counter += 1;
        }
        _counter = 0;

    }

}

