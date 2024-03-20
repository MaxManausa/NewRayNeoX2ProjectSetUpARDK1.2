using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondBow : MonoBehaviour
{
    [SerializeField] GameObject DiamondBowNowAvailable;
    [SerializeField] ArrowColor arrowColorScript;

    public int prizeDiamondCounter = 0;

    public void DiamondBowAvailable()
    {
        prizeDiamondCounter += 1;
        if (prizeDiamondCounter == 2)
        {
            arrowColorScript.IsDiamondBowAvailable = true;
            DiamondBowNowAvailable.SetActive(true);
        }
    }
}
