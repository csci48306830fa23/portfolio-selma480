using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedObject : MonoBehaviour
{
    float timeSeconds = 2; // life time of spawned objects 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // if the spawned object has reached its life time (3s), destroy the object 
        timeSeconds -= Time.deltaTime;
        if (timeSeconds < 0) {
            GameObject.Destroy(gameObject);
        } // if

    }
}
