using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    // Script should be attached to the main camera

    // Player transform, should be set in the inspector
    public Transform followTarget;

    // The camera offsets for the x-axis and the y-axis
    public float cameraOffset = 3.0f;
    public float offsetY = 1.0f;

    private Transform tempTransform;

    public float cameraMoveSpeed = 2.0f;

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(followTarget.position.x + cameraOffset, followTarget.position.y + offsetY, -10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Flip>().facingRight)
        {
            tempTransform = transform;
            transform.position = new Vector3(Mathf.Lerp(tempTransform.position.x, followTarget.transform.position.x + cameraOffset, cameraMoveSpeed * Time.deltaTime), followTarget.position.y + offsetY, -10);
        }

        if (!GameObject.FindGameObjectWithTag("Player").GetComponent<Flip>().facingRight)
        {
            tempTransform = transform;
            transform.position = new Vector3(Mathf.Lerp(tempTransform.position.x, followTarget.transform.position.x - cameraOffset, cameraMoveSpeed * Time.deltaTime), followTarget.position.y + offsetY, -10);
        }
    }
}
