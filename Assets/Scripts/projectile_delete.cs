using UnityEngine;
using System.Collections;

public class projectile_delete : MonoBehaviour {

    // Script should go on the projectiles, to destroy them after 3 seconds

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
