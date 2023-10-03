using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public Transform rayOrigin;
    public GameObject cannonball;
    float velocity = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // on left click mouse button
        if (Input.GetButtonDown("Fire1")) {

            // create cannonball and its path
            var ball = Instantiate(cannonball, rayOrigin.position, rayOrigin.rotation);
            ball.GetComponent<Rigidbody>().velocity = rayOrigin.up * velocity; 

            RaycastHit hit;
            if (Physics.Raycast(rayOrigin.position, rayOrigin.forward, out hit)) {
                float distance = hit.distance;
                Debug.DrawLine(rayOrigin.position, rayOrigin.position+rayOrigin.forward*hit.distance, Color.red);
            }

        }

    }
}
