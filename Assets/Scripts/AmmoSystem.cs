using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoSystem : MonoBehaviour
{
    public TextMeshProUGUI ammoText;

    public int totalAmmo;
    public int currentAmmo;

    public float endGameTimer;
    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = totalAmmo;
        ammoText.text = "Ammo: " + currentAmmo + "/" + totalAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator EndGame()
    {
        yield return new WaitForSeconds(endGameTimer);
        if (currentAmmo <= 0 && GameManager.instance.fallenBrickAmount < GameManager.instance.fallenBrickNeeded)
        {
            Debug.Log("You Lose");
            GameManager.instance.LosePanel.SetActive(true);
        }
    }

    public int CurrentAmmo
    {
        get
        {
            return currentAmmo;
        }
        set
        {
            currentAmmo = value;
            ammoText.text = "Ammo: " + currentAmmo + "/" + totalAmmo;
            StartCoroutine(EndGame());
        }
    }
}
