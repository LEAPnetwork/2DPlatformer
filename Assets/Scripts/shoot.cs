using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

    // Script should go on player

    public GameObject projectile;

    public float projectileSpeed;
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.LeftControl) && gameObject.GetComponent<CollectCone>().coneCount >=1)
        {
            GameObject firedbullet = Instantiate(projectile, new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity) as GameObject;
       
            if (!GetComponent<Flip>().facingRight)
            {
                firedbullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(-projectileSpeed, 0));
            } else
            {
                firedbullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(projectileSpeed, 0));
            }
            gameObject.GetComponent<CollectCone>().coneCount = gameObject.GetComponent<CollectCone>().coneCount - 1;
        }
	}
}
