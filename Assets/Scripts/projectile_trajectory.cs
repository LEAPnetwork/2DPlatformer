using UnityEngine;
using System.Collections;

public class projectile_trajectory : MonoBehaviour {

    // Script should go on projectile

    public float projectileSpeed;

    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (!player.GetComponent<Flip>().facingRight)
        {
            projectileSpeed *= -1;
        }


        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(projectileSpeed, 0);
    }
}
