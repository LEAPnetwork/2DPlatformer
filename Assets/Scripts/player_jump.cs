using UnityEngine;
using System.Collections;

public class player_jump : MonoBehaviour {

    // Script should go on the player

    bool onGround;

    bool hasJumped;

    public float jumpPower;

    Animator playerAnim;

	// Use this for initialization
	void Start () {
        onGround = false;
        hasJumped = false;
        playerAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            onGround = false;
            hasJumped = true;
            playerAnim.SetBool("Jumping", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpPower));
        }

        if (!onGround && !hasJumped)
        {
            playerAnim.Play("falling");
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Floor")
        {
            onGround = true;
            hasJumped = false;
            playerAnim.SetBool("Jumping", false);
            playerAnim.SetBool("Landing", true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Floor")
        {
            onGround = false;
            playerAnim.SetBool("Landing", false);
        }
    }
}
