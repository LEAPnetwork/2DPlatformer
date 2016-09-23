using UnityEngine;
using System.Collections;

public class Flip : MonoBehaviour {

    // Script should go on player, to flip the sprite

    public bool facingRight;

    // Use this for initialization
    void Start () {
        facingRight = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") > 0 && !facingRight)
        {
            FlipIt();
        }
        else if (Input.GetAxis("Horizontal") < 0 && facingRight)
        {
            FlipIt();
        }
    }

    void FlipIt()
    {
        facingRight = !facingRight;
        Vector3 playerScale = transform.localScale;
        playerScale.x *= -1;
        transform.localScale = playerScale;
    }
}
