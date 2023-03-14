using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatChanger : MonoBehaviour
{


    [SerializeField] Material[] _materialSet1;
    [SerializeField] Material[] _materialSet2;
    public SerializeReference[] choosenMSet;
    private int _counter = 0;

    


    void Start()
    {
        
        foreach (Transform _material in this.transform)
        {
            Transform oim = transform.Find("Material" + _counter.ToString());

            foreach (Transform _objname in oim)
            {
                _objname.GetComponent<Renderer>().material = this.GetComponent<MatChanger>()._materialSet2[_counter] ;
            }
            _counter += 1;
        }


        
    }
    

}

