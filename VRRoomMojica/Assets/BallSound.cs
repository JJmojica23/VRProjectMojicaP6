using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour
{
    public AudioClip ballimpact;
    private Rigidbody rb;
    AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
       float volumeball = rb.velocity.magnitude;
       if (volumeball > 1)
           volumeball = 1;
       audioSource.PlayOneShot(ballimpact, volumeball / 20);
    }
}
