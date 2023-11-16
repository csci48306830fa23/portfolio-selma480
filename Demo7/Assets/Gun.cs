using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public GameObject bullet;
    public Transform shootPoint;
    private float force = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fire() {
        var bulletInstance = Instantiate(bullet, shootPoint.transform.position, Quaternion.identity);
        bulletInstance.GetComponent<Rigidbody>().velocity = shootPoint.forward * force;
    }

}
