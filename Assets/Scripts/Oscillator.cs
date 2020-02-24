using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Oscillator : MonoBehaviour


{

    [SerializeField] Vector3 movementVector;

    //todo remove from inspector later
    [SerializeField] [Range(0,1)]
    float movementFactor;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
