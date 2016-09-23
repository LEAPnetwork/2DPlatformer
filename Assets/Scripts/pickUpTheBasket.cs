using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pickUpTheBasket : MonoBehaviour {

    // Script should go on the item which should be picked up

	public static bool basketIsPickedUp; // this bool can be called in other scripts using, pickUpTheBasket.basketIsPickedUp.

	private GameObject basketUI;
	
	void Start(){
		basketUI = GameObject.Find("BasketImage");
		basketUI.SetActive(false);
	}
	
	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.transform.tag == "Player"){
			basketIsPickedUp = true;
			Debug.Log ("Uh! a basket for granny");
			basketUI.SetActive(true);
			GameObject.Destroy(gameObject);
		} 
	} // void OnCollisionEnter2D
}
