using UnityEngine;
using System.Collections;

public class PlayerPortal : MonoBehaviour {

    // Script should go on the player

    private bool portalReady = true;
    public AudioClip portalSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Portal" && portalReady)
        {
            portalReady = false;
            Vector2 targetPosition = other.GetComponent<ConnectedPortal>().connectedPortal.transform.position;
            transform.position = targetPosition;
            StartCoroutine("PortalReset");
            other.GetComponentInChildren<AudioSource>().PlayOneShot(portalSound,1f);
        }
    }

    IEnumerator PortalReset()
    {
        portalReady = false;
        yield return new WaitForSeconds(0.5f);
        portalReady = true;
    }
}
