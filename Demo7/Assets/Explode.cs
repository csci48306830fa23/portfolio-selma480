using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{

    public ParticleSystem explosion;
    public GameObject target;

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.CompareTag("Bullet")) {
            explode();
        }
    }

    public void explode() {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(target);
    }

}
