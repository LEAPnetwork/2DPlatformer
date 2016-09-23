using UnityEngine;
using UnityEngine.UI; 
using System.Collections;


public class CollectCone : MonoBehaviour
{
    // Script should go on player

    public int coneCount;
    private Text t; 

    // Use this for initialization
    void Start()
    {
        coneCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t = GameObject.Find("ConeCounter").GetComponent<Text>();
        t.text         = coneCount.ToString();  
    }
    
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Cone")
        {
            Destroy(coll.gameObject);
            coneCount = coneCount + 1;
        }
    }
}
