using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {
    // The fly speed
    public float speed = 5.0f;

    // explosion prefab (particles)
    public GameObject explosionPrefab;

    // find out when it hit something
    void OnCollisionEnter(Collision c) {
        
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

       
        Destroy(gameObject);
    }
}