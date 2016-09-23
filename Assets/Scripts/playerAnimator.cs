using UnityEngine;
using System.Collections;

public class playerAnimator : MonoBehaviour {

    // Script should go on the player

    private Animator playerAnim;
    private Rigidbody2D playerRigidbody;
    bool test;

    // Use this for initialization
    void Start () {
        playerAnim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate() {

        if (playerRigidbody.velocity.x > 0.1)
        {
            playerAnim.SetBool("Running", true);
        }
        else if (playerRigidbody.velocity.x < -0.1)
        {
            playerAnim.SetBool("Running", true);
        }
        else if (playerRigidbody.velocity.x < 0.1 && playerRigidbody.velocity.x > -0.1)
        {
            playerAnim.SetBool("Running", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            playerAnim.Play("ridinghood_shoot");
        }
    }
}
