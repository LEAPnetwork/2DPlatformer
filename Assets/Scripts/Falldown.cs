using UnityEngine;
using System.Collections;

public class Falldown : MonoBehaviour {

    // Script should go on the platforms which fall down

    public float counter;
    private bool fall;
    public Rigidbody2D rbs; 

    // Use this for initialization
    void Start () {
        fall = false;
        rbs = GetComponent<Rigidbody2D>(); 
    }
	
	// Update is called once per frame
	void Update () {
        if (fall == true)
        {
            counter = counter - Time.deltaTime;
        }
        if (counter <= 0) {
            rbs.isKinematic = false;
            Destroy(GetComponent<BoxCollider2D>());
        }

        if (transform.position.y <= -100)
        {
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            fall = true;
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
