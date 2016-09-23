using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour {

    // Script should go on player

    public float fallDist = -20f;
    public float xdie = -200f;
    public float ydie = 200f;

    public bool dead = false; 

    private bool rotate = false;
    public float counter = 10;
    
    Collider2D[] playerCollider;
    
    // Use this for initialization
    void Start () {
        playerCollider = GetComponents<Collider2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y <= fallDist)
        {
            dead = true; 
        }

        counter = counter - Time.deltaTime;

        if (rotate == true)
        {
            transform.Rotate(Vector3.forward * counter);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Spikes" || other.gameObject.tag == "Enemy")
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(xdie,ydie));
            rotate = true;
            dead = true; // Boolean to call the UI when dead. 

            for (int i = 0; i < playerCollider.Length; i++)
            {
                playerCollider[i].enabled = false;
            }
        }
    }
}
