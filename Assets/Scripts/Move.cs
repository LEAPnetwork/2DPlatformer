using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    // Script should go on player

    float move;
    public float maxSpeed = 0.1f;
    public Rigidbody2D playerRigidbody;
    
    // Use this for initialization
    void Start () {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        move = Input.GetAxis("Horizontal") * 0.2f;
        playerRigidbody.velocity = new Vector2(move * maxSpeed, playerRigidbody.velocity.y);
    }

    // Seperate script please
    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.transform == transform.parent)
        {
            transform.parent = null;
        }
    } 

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.tag == "Floor")
        {
            transform.parent = coll.transform;
        }
    }

}
