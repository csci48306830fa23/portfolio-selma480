using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    SpawnedObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // Key inputs for spawning will be detected here
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject.Instantiate(cube);
        } 

    }
}
