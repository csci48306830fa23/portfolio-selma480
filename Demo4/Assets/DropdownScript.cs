using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownScript : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dropdown(int v) {

        var cubeRenderer = cube.GetComponent<Renderer>();

        if (v == 0) { // default
            cubeRenderer.material.SetColor("_Color", Color.white);
        } else if (v == 1) { // blue
            cubeRenderer.material.SetColor("_Color", Color.blue);
        } else if (v == 2) { // red
            cubeRenderer.material.SetColor("_Color", Color.red);
        } // if

    }
}
