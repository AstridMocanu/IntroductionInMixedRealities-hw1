using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    private Rigidbody rigidBody;
    private MeshRenderer sphereMesh;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        sphereMesh = GetComponent<MeshRenderer>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
 
            if (Input.touchCount > 0)
           // if (Input.GetKeyDown("space")) //-utilizat doar pt testare pe computer
            {
                sphereMesh.material.SetColor("_Color", Color.red);
                StartCoroutine(FallCoroutine());
                
               
            }
    }

    IEnumerator FallCoroutine()
    {
            yield return new WaitForSeconds(3);
            rigidBody.useGravity = true;

    }



}
