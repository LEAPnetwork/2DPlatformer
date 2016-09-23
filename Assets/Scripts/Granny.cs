using UnityEngine;
using System.Collections;

public class Granny : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D coll) {
		if(coll.transform.tag == "Player" && pickUpTheBasket.basketIsPickedUp == true){
			Debug.Log ("Hello, my dear. I love baskets");
		}
	}
}
