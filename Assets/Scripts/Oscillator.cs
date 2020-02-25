using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent] //<-- Attribute. Only allows one script on the game object
public class Oscillator : MonoBehaviour


{

    [SerializeField] Vector3 movementVector; //Vector3 = Transform 'postions' X, Y, Z
    
    //todo remove from inspector later
    [SerializeField] [Range(0,1)] //0 for not moved, 1 for full movement
    float movementFactor;

    Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPos + offset;
    }
}
