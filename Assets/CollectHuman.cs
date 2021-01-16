using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHuman : MonoBehaviour

{
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(this.gameObject);
            source.Play();
        }
    }
}
