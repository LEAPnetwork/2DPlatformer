using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinLoss : MonoBehaviour {

    // Script should go on player
    //win loose script that displays the UI for when reaching granny or when you die.  
    private Text w;
    private Text lo;
    private Text almost;

    public Button btn; 
    // Use this for initialization
    void Start () {
        btn = GameObject.Find("Restart").GetComponent<Button>();
        btn.gameObject.SetActive(false);
        lo = GameObject.Find("Win").GetComponent<Text>();
        w = GameObject.Find("Win").GetComponent<Text>();
        almost = GameObject.Find("Win").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        //When you die! 
        if (gameObject.GetComponent<death>().dead == true) {
            btn.gameObject.SetActive(true); 
            lo.text = "YOU DIED!";
        }
    }

 //when you reach granny and win 
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Granny")
        {

            if (pickUpTheBasket.basketIsPickedUp == true)
            {
                w.text = "YOU WIN \n Granny is very happy for the food! \n Good job Red Hood";

                GameObject.FindGameObjectWithTag("Player").GetComponent<Move>().enabled = false; //freeze position 
                GameObject.FindGameObjectWithTag("Player").GetComponent<Flip>().enabled = false;//freeze position 
            }
            else {
                almost.text = "Where is my food RED!!";
            }
        }
    }

    void OnCollisionExit2D(Collision2D co) {
        almost.text = ""; 
    }
}
