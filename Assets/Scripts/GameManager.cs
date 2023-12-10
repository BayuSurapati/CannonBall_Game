using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Transform wallOfBrick;
    public int fallenBrickAmount, fallenBrickNeeded;

    public GameObject LosePanel;
    public GameObject WinPanel;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        fallenBrickNeeded = wallOfBrick.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BrickFall()
    {
        fallenBrickAmount++;

        if(fallenBrickAmount >= fallenBrickNeeded)
        {
            Debug.Log("You Win");
            WinPanel.SetActive(true);
        }
    }
}
