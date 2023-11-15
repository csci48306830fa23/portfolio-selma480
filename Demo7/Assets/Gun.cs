using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject bullet;
    public GameObject shootPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void fire() {
        Instantiate(bullet, shootPoint.transform.position, Quaternion.identity);
    }
}
