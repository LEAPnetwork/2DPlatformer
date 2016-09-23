using UnityEngine;
using System.Collections;

public class SoundTrig : MonoBehaviour {

    // Script should go on audio objects

    public AudioClip audio1;
    private AudioSource source;

	// Use this for initialization
	void Awake () {
        source = GetComponent<AudioSource>();
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            source.PlayOneShot(audio1,1f);
    }
}
