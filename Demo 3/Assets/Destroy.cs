using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    float lifetime = 8; // lifetime of cannonballs
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // destroy object once lifetime is reached
        lifetime -= Time.deltaTime;
        if (lifetime < 0) {
            GameObject.Destroy(gameObject);
        }

    }

   
}
