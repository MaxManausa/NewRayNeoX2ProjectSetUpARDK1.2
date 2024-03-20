using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowColor : MonoBehaviour
{
    [SerializeField] GameObject mainMenuArrowTip;
    [SerializeField] GameObject gameArrowTip;
    [SerializeField] FireBow fireBow;
    [SerializeField] GameObject firedArrowGreen;
    [SerializeField] GameObject firedArrowBlue;
    [SerializeField] GameObject firedArrowPurple;
    [SerializeField] GameObject firedArrowRed;
    [SerializeField] GameObject firedArrowYellow;
    [SerializeField] GameObject firedArrowDiamond;

    [SerializeField] Material green;
    [SerializeField] Material blue;
    [SerializeField] Material purple;
    [SerializeField] Material red;
    [SerializeField] Material yellow;
    [SerializeField] Material diamond;
    [SerializeField] Material brown;


    [SerializeField] GameObject mainMenuBow;
    [SerializeField] GameObject gameBow;
    [SerializeField] GameObject mainMenuBowShaft;
    [SerializeField] GameObject gameBowShaft;

    public bool IsDiamondBowAvailable;

    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        IsDiamondBowAvailable = false;
        mainMenuBow.GetComponent<Renderer>().material = brown;
        gameBow.GetComponent<Renderer>().material = brown;
        mainMenuBowShaft.GetComponent<Renderer>().material = brown;
        gameBowShaft.GetComponent<Renderer>().material = brown;
        mainMenuArrowTip.GetComponent<Renderer>().material = green;
        gameArrowTip.GetComponent<Renderer>().material = green;
        fireBow.arrowPrefab = firedArrowGreen;

        counter = 0;
    }

    public void ColorChanger()
    {
        if (counter == 5)
        {
            counter = 0;
            mainMenuBow.GetComponent<Renderer>().material = brown;
            gameBow.GetComponent<Renderer>().material = brown;
            mainMenuBowShaft.GetComponent<Renderer>().material = brown;
            gameBowShaft.GetComponent<Renderer>().material = brown;
            mainMenuArrowTip.GetComponent<Renderer>().material = green;
            gameArrowTip.GetComponent<Renderer>().material = green;
            fireBow.arrowPrefab = firedArrowGreen;
            return;
        }
        if (counter == 4 && IsDiamondBowAvailable == false) 
        {
            counter = 0;
            mainMenuBow.GetComponent<Renderer>().material = brown;
            gameBow.GetComponent<Renderer>().material = brown;
            mainMenuBowShaft.GetComponent<Renderer>().material = brown;
            gameBowShaft.GetComponent<Renderer>().material = brown;
            mainMenuArrowTip.GetComponent<Renderer>().material = green;
            gameArrowTip.GetComponent<Renderer>().material = green;
            fireBow.arrowPrefab = firedArrowGreen;
            return;
        }
        counter += 1;
        if (counter == 1) 
        {
            mainMenuBow.GetComponent<Renderer>().material = brown;
            gameBow.GetComponent<Renderer>().material = brown;
            mainMenuBowShaft.GetComponent<Renderer>().material = brown;
            gameBowShaft.GetComponent<Renderer>().material = brown;
            mainMenuArrowTip.GetComponent<Renderer>().material = blue;
            gameArrowTip.GetComponent<Renderer>().material = blue;
            fireBow.arrowPrefab = firedArrowBlue;
        }
        if (counter == 2)
        {
            mainMenuBow.GetComponent<Renderer>().material = brown;
            gameBow.GetComponent<Renderer>().material = brown;
            mainMenuBowShaft.GetComponent<Renderer>().material = brown;
            gameBowShaft.GetComponent<Renderer>().material = brown;
            mainMenuArrowTip.GetComponent<Renderer>().material = purple;
            gameArrowTip.GetComponent<Renderer>().material = purple;
            fireBow.arrowPrefab = firedArrowPurple;
        }
        if (counter == 3)
        {
            mainMenuBow.GetComponent<Renderer>().material = brown;
            gameBow.GetComponent<Renderer>().material = brown;
            mainMenuBowShaft.GetComponent<Renderer>().material = brown;
            gameBowShaft.GetComponent<Renderer>().material = brown;
            mainMenuArrowTip.GetComponent<Renderer>().material = red;
            gameArrowTip.GetComponent<Renderer>().material = red;
            fireBow.arrowPrefab = firedArrowRed;
        }
        if (counter == 4)
        {
            mainMenuBow.GetComponent<Renderer>().material = brown;
            gameBow.GetComponent<Renderer>().material = brown;
            mainMenuBowShaft.GetComponent<Renderer>().material = brown;
            gameBowShaft.GetComponent<Renderer>().material = brown;
            mainMenuArrowTip.GetComponent<Renderer>().material = yellow;
            gameArrowTip.GetComponent<Renderer>().material = yellow;
            fireBow.arrowPrefab = firedArrowYellow;
        }
        if (IsDiamondBowAvailable == true && counter == 5)
        {
            mainMenuBow.GetComponent<Renderer>().material = diamond;
            gameBow.GetComponent<Renderer>().material = diamond;
            mainMenuBowShaft.GetComponent<Renderer>().material = diamond;
            gameBowShaft.GetComponent<Renderer>().material = diamond;
            mainMenuArrowTip.GetComponent<Renderer>().material = diamond;
            gameArrowTip.GetComponent<Renderer>().material = diamond;
            fireBow.arrowPrefab = firedArrowDiamond;
        }
    }
}
