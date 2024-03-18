using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWon : MonoBehaviour
{
    [SerializeField] private GameObject inGameMenu;
    [SerializeField] private GameObject headtrackedUIdisplay;
    [SerializeField] private GameObject bowAndArrow;
    [SerializeField] private GameObject mainmenuUIdisplay;
    [SerializeField] private GameObject prizeRoomButton;
        
    // Start is called before the first frame update
    void Awake()
    {
        inGameMenu.SetActive(false);
        headtrackedUIdisplay.SetActive(false);
        bowAndArrow.SetActive(false);
        prizeRoomButton.SetActive(true);
        mainmenuUIdisplay.SetActive(true);
    }

    private void Update()
    {
        inGameMenu.SetActive(false);
        headtrackedUIdisplay.SetActive(false);
        bowAndArrow.SetActive(false);
        mainmenuUIdisplay.SetActive(true);
    }
}
