using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    Rigidbody rigidBody;

    AudioSource audioSource;
    bool m_ToggleChange;
    


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();

    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space)) //space bar == thrust key
        {
            rigidBody.AddRelativeForce(Vector3.up);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }

        else 
        {
            audioSource.Stop();
        }

        if (Input.GetKey(KeyCode.A)) //pivot left
        {
            transform.Rotate(Vector3.forward);
        }

        else if (Input.GetKey(KeyCode.D)) // pivot right
        {
            transform.Rotate(-Vector3.forward);
        }

        
    }

}