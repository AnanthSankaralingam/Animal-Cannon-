using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarTilt : MonoBehaviour
{
    Vector3 vector3;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        vector3 = new Vector3(0.0f, 0.5f, 0.0f);
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        //if(rb.rotation.x <25)
        if (Input.GetKey(KeyCode.RightArrow))
            transform.RotateAround(vector3, Vector3.right, 15 * Time.deltaTime);
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.RotateAround(vector3, Vector3.left, 15 * Time.deltaTime);
    }
}
