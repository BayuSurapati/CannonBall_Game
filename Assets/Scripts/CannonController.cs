using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float rotationSpeed;
    public Transform cannonBody;

    public float xDegree, yDegree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CannonMovement();
    }

    void CannonMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        xDegree += horizontalInput * rotationSpeed * Time.deltaTime;

        float verticalInput = Input.GetAxis("Vertical");
        yDegree += verticalInput * rotationSpeed * Time.deltaTime;

        xDegree = Mathf.Clamp(xDegree, -45, 45);
        yDegree = Mathf.Clamp(yDegree, -8, 45);

        cannonBody.localEulerAngles = new Vector3(0, yDegree, xDegree);

    }
}
