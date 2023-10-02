using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    [SerializeField]
    SpawnedObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Key inputs for spawning will be detected here
        if (Input.GetKeyDown(KeyCode.S)) {
            GameObject.Instantiate(sphere);
        } 
    }
}
