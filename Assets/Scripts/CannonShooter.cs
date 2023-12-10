using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooter : MonoBehaviour
{
    public AmmoSystem cannonAmmo;

    public GameObject cannonBallPrefab;
    public Transform cannonShootPoint, cannonBody;
    public float shootForce;

    private void Awake()
    {
        cannonAmmo = GetComponent<AmmoSystem>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CannonShoot();
        }
    }

    void CannonShoot()
    {
        if(cannonAmmo.CurrentAmmo <= 0)
        {
            return;
        }

        GameObject cannonBall = Instantiate(cannonBallPrefab, cannonShootPoint.position, cannonShootPoint.rotation);
        cannonBall.GetComponent<Rigidbody>().AddForce(cannonBall.transform.forward * shootForce, ForceMode.Impulse);

        cannonAmmo.CurrentAmmo--;
    }
}
