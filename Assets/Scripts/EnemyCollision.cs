using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

    // Script should go on player, to knock player back if enemy is walked into

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            if (other.transform.position.x < transform.position.x)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(5000, 100));
            } else
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-5000, 100));
            }           
        }
    }
}
