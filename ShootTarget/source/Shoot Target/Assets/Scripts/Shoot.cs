using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	// Rocket Prefab
    public GameObject rocketPrefab;
	public GameObject GunShot;

	// Update is called once per frame
	void Update () {
	    // left mouse clicked?
        if (Input.GetMouseButtonDown(0)) {
           
            GameObject g = (GameObject)Instantiate(rocketPrefab,
                                                   transform.position,
                                                   transform.parent.rotation);
			GameObject gunshot = Instantiate (GunShot, this.transform.position, this.transform.rotation) as GameObject;

            
            float force = g.GetComponent<Rocket>().speed;
            g.GetComponent<Rigidbody>().AddForce(g.transform.forward * force);
        }
	}
}
