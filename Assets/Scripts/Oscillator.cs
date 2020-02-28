using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent] //<-- Attribute. Only allows one script on the game object
public class Oscillator : MonoBehaviour
{

    [SerializeField] Vector3 movementVector = new Vector3(10f, 10f, 10f); //Vector3 = Transform 'postions' X, Y, Z
    [SerializeField] float period = 4f;
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
        //set movement factor automatically
        if (period <= Mathf.Epsilon) { return; };
        float cycles = Time.time / period;
        const float tau = Mathf.PI * 2; //about 6.28 radians
        float rawSinWave = Mathf.Sin(cycles * tau); //goes from -1 to +1


        movementFactor = rawSinWave / 2f + 0.5f;
        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPos + offset;
    }
}
