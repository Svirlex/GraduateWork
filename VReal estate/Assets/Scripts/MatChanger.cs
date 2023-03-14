using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatChanger : MonoBehaviour
{
    [SerializeField] Dictionary<int, Material[]> _matSets = new Dictionary<int, Material[]>();
    [SerializeField] Material[] _materialSet0;
    [SerializeField] Material[] _materialSet1;
    private int _counter = 0;
    public int chosenSet;
    [SerializeField] int customSetsAmount;

    void Start()
    {
        _matSets.Add(0, _materialSet0);
        _matSets.Add(1, _materialSet1);

        for (int i = 0; i < customSetsAmount; i++)
        {
            _matSets.Add(1 + i, new Material[3]);
        }
    }


    void Update()
    {



        foreach (Transform _material in this.transform)
        {
            Transform oim = transform.Find("Material" + _counter.ToString());

            foreach (Transform _objname in oim)
            {
                _objname.GetComponent<Renderer>().material = _matSets[chosenSet][_counter];
            }
            _counter += 1;
        }
        _counter = 0;


    }
}

