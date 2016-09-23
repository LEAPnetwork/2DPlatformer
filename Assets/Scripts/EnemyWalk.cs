using UnityEngine;
using System.Collections;

public class EnemyWalk : MonoBehaviour {

    // This script must go on the enemies. The platforms must have the tag "Floor".

    float xPos;

    float leftEdge;
    float rightEdge;
    float edgeBuffer;

    bool isOnFloor;
    bool hasTurned;

    public float enemySpeed;

    bool facingRight;


    // Use this for initialization
    void Start () {
        isOnFloor = false;
        hasTurned = false;

        edgeBuffer = 0.2f;

        xPos = transform.position.x;

        facingRight = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (isOnFloor)
        {
            transform.position = new Vector2(xPos, transform.position.y);

            xPos += enemySpeed;

            if (transform.position.x <= leftEdge && !hasTurned || transform.position.x >= rightEdge && !hasTurned)
            {
                FlipIt();
                enemySpeed *= -1;
                hasTurned = true;       
            }

            if ( leftEdge < transform.position.x && transform.position.x < rightEdge)
            {
                hasTurned = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Floor" && !isOnFloor)
        {
            isOnFloor = true;
            leftEdge = coll.gameObject.GetComponent<Renderer>().bounds.min.x + edgeBuffer;
            rightEdge = coll.gameObject.GetComponent<Renderer>().bounds.max.x - (edgeBuffer * 2);
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
