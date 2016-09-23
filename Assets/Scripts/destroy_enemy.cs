using UnityEngine;
using System.Collections;

public class destroy_enemy : MonoBehaviour {

    // Script should go on enemies, to destroy them when they are defeated

	// Update is called once per frame
	void Update () {
	
        if (transform.position.y <= -30)
        {
            Destroy(gameObject);
        }
	}
}
