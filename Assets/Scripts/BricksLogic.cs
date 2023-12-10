using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksLogic : MonoBehaviour
{
    public bool hasFallen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasFallen) return;

        if (other.GetComponent<WallFallenDetector>())
        {
            hasFallen = true;
            GameManager.instance.BrickFall();
        }
    }
}
