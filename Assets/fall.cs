using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    private Rigidbody rigidBody;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        count++;


        if(count>400 && Input.touchCount>0)
            rigidBody.useGravity = true;


    }
}
