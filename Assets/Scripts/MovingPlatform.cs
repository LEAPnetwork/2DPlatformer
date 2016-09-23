using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour
{
    // Script should go on the platforms which move. Their movement patterns is set (by coordinates) in the inspector.

    [SerializeField]
    private bool moveSwitch; // trigger movement

    [SerializeField]
    private bool loopSwitch; // trigger loop movement

    [SerializeField]
    private bool backTravelSwitch; // trigger backtravel movement

    [SerializeField]
    private int moveSpeed; // platform speed 

    [SerializeField]
    private Vector3[] positions; // array if vector, platform positions

    // private variables
    private Vector3 nextPosition; // next pointer of sorts
    private int counter; // counts through positions array

    // Use this for initialization
    void Start()
    {
        transform.position = positions[0];
        counter = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (moveSwitch)
        {
            if (transform.position != positions[positions.Length - 1])
            {
                nextPosition = positions[counter];
                transform.position = Vector3.MoveTowards(transform.position, nextPosition, Time.deltaTime * moveSpeed);
                if (transform.position == nextPosition)
                {
                    counter++;
                }
            }
            else if (loopSwitch)
            {
                nextPosition = positions[0];
                transform.position = Vector3.MoveTowards(transform.position, nextPosition, Time.deltaTime * moveSpeed);
                counter = 0;
            }
            else if (backTravelSwitch)
            {
                System.Array.Reverse(positions);
                counter = 1;
                transform.position = positions[0];
            }
            else
            {
                moveSwitch = false;
            } // if pos is not last pos
        } // while (moveSwitch)
    } // void FixedUpdate()
} // class 
