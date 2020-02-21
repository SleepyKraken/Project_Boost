using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    Rigidbody rigidBody;
    AudioSource audioSource;
    bool m_ToggleChange;
    [SerializeField] float rcsThrust = 500f;
    [SerializeField] float mainThrust = 500f;



    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Rotation(); 
        Thrusting();
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                print("Ok");//do nothing
                break;
            case "Fuel Station":
                print("Fueling");
                break;
            default:
                print("Dead");
                break;

        }

    }
    private void Rotation()
        {
        
        rigidBody.freezeRotation = true; //take manual control of rotation
        if (Input.GetKey(KeyCode.A)) //pivot left
            {
            float rotationThisFrame = rcsThrust * Time.deltaTime;    
            transform.Rotate(Vector3.forward * rotationThisFrame);
            }

            else if (Input.GetKey(KeyCode.D)) // pivot right
            {
            float rotationThisFrame = rcsThrust * Time.deltaTime;
            transform.Rotate(-Vector3.forward * rotationThisFrame);
            }
        rigidBody.freezeRotation = false; // resume normal physics
        }

        private void Thrusting()
        {
            if (Input.GetKey(KeyCode.Space)) //space bar == thrust key
            {
                rigidBody.AddRelativeForce(Vector3.up * mainThrust);
                if (!audioSource.isPlaying)
                {
                    audioSource.Play();
                }
            }

            else
            {
                audioSource.Stop();
            }
        }
}