using UnityEngine;
using System.Collections;

public class KillEnemy : MonoBehaviour {

    // Script should go on player

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Enemy")
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300));

            Collider2D[] enemyCollider = other.GetComponents<Collider2D>();

            for (int i = 0; i < enemyCollider.Length; i++)
            {
                enemyCollider[i].enabled = false;
            }

            other.transform.Rotate(Vector3.forward * 180);
            other.GetComponent<EnemyWalk>().enabled = false;
            other.GetComponentInChildren<Animator>().enabled = false;
        }
    }
}
