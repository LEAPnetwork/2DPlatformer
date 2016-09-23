using UnityEngine;
using System.Collections;

public class BackgroundFollow : MonoBehaviour {

    // Script should be attached to background elements which should have an parallax effect
    // Follow speed is relative to the followTarget speed (so 1 is a matched speed)

	public Transform followTarget;

	public float followSpeed;

    float startOffset;

	// Use this for initialization
	void Start () {
        startOffset = transform.position.x;
		followTarget = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(startOffset + followTarget.transform.position.x * followSpeed, transform.position.y, transform.position.z);
	}
}
