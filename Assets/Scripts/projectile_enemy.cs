using UnityEngine;
using System.Collections;

public class projectile_enemy : MonoBehaviour {

    // Script should go on projectiles

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Collider2D[] enemyCollider = other.GetComponents<Collider2D>();

            for (int i = 0; i < enemyCollider.Length; i++)
            {
                enemyCollider[i].enabled = false;
            }

            other.transform.Rotate(Vector3.forward * 180);
            other.GetComponent<EnemyWalk>().enabled = false;
            other.GetComponentInChildren<Animator>().enabled = false;
            Destroy(gameObject);
        }
    }
}
