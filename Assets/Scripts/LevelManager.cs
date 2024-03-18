using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject level1;
    [SerializeField] private GameObject level2;
    [SerializeField] private GameObject level3;
    [SerializeField] private GameObject level4;
    [SerializeField] private GameObject level5;
    [SerializeField] private GameObject level6;
    [SerializeField] private GameObject level7;
    [SerializeField] private GameObject level8;
    [SerializeField] private GameObject level9;
    [SerializeField] private GameObject level10;
    [SerializeField] private GameObject level11;
    [SerializeField] private GameObject level12;
    [SerializeField] private GameObject beatGameScreen;

    [SerializeField] private Text levelTitleText;
    [SerializeField] private Text winningTitleText;

    [SerializeField] private Scoreboard scoreboard;
    [SerializeField] private FireBow fireBow;

    public int levelNumber;

    public void WhatsTheNumber()
    {
        if (level1.activeSelf)
        {
            levelTitleText.text = "Level 1: Hit Targets 3 Times";
            levelNumber = 1;
            WinningScore3();
            return;
        }
        if (level2.activeSelf)
        {
            levelTitleText.text = "Level 2: Hit Targets 5 Times";
            levelNumber = 2;
            WinningScore5();
            return;
        }
        if (level3.activeSelf)
        {
            levelTitleText.text = "Level 3: Hit Targets 10 Times";
            levelNumber = 3;
            WinningScore10();
            return;
        }
        if (level4.activeSelf)
        {
            levelTitleText.text = "Level 4: Hit Targets 10 Times";
            levelNumber = 4;
            WinningScore10();
            return;
        }
        if (level5.activeSelf)
        {
            levelTitleText.text = "Level 5: Hit Targets 10 Times";
            levelNumber = 5;
            WinningScore10();
            return;
        }
        if (level6.activeSelf)
        {
            levelTitleText.text = "Level 6: Hit Targets 10 Times";
            levelNumber = 6;
            WinningScore10();
            return;
        }
        if (level7.activeSelf)
        {
            levelTitleText.text = "Level 7: Hit Diamonds 5 times";
            levelNumber = 7;
            WinningScore5();
            return;
        }
        if (level8.activeSelf)
        {
            levelTitleText.text = "Level 8: Hit Diamonds 10 times";
            levelNumber = 8;
            WinningScore10();
            return;
        }
        if (level9.activeSelf)
        {
            levelTitleText.text = "Level 9: Hit Diamonds 5 times";
            levelNumber = 9;
            WinningScore5();
            return;
        }
        if (level10.activeSelf)
        {
            levelTitleText.text = "Level 10: Hit Monsters 10 Times";
            levelNumber = 10;
            WinningScore10();
            return;
        }
        if (level11.activeSelf)
        {
            levelTitleText.text = "Level 11: Hit Monsters 10 Times";
            levelNumber = 11;
            WinningScore10();
            return;
        }

        if (level12.activeSelf)
        {
            levelTitleText.text = "Level 12: Hit Monsters 10 Times";
            levelNumber = 12;
            WinningScore10();
        }
    }

    public void WinningScore3()
    {
        scoreboard.onelessthanwinningScore = 2;
        fireBow.targetsToHit = 3;
        winningTitleText.text = "Level " + levelNumber + " Completed";
    }
    
    public void WinningScore5()
    {
        scoreboard.onelessthanwinningScore = 4;
        fireBow.targetsToHit = 5;
        winningTitleText.text = "Level " + levelNumber + " Completed";
    }
    
    public void WinningScore10()
    {
        scoreboard.onelessthanwinningScore = 9;
        fireBow.targetsToHit = 10;
        winningTitleText.text = "Level " + levelNumber + " Completed";
    }
    
    public void WinningScore15()
    {
        scoreboard.onelessthanwinningScore = 14;
        fireBow.targetsToHit = 15;
        winningTitleText.text = "Level " + levelNumber + " Completed";
    }

    public void RestartLevel()
    {
        if (levelNumber == 1)
        {
            level1.SetActive(true);
        }
        if (levelNumber == 2)
        {
            level2.SetActive(true);
        }
        if (levelNumber == 3)
        {
            level3.SetActive(true);
        }
        if (levelNumber == 4)
        {
            level4.SetActive(true);
        }
        if (levelNumber == 5)
        {
            level5.SetActive(true);
        }
        if (levelNumber == 6)
        {
            level6.SetActive(true);
        }
        if (levelNumber == 7)
        {
            level7.SetActive(true);
        }
        if (levelNumber == 8)
        {
            level8.SetActive(true);
        }
        if (levelNumber == 9)
        {
            level9.SetActive(true);
        }
        if (levelNumber == 10)
        {
            level10.SetActive(true);
        }
        if (levelNumber == 11)
        {
            level11.SetActive(true);
        }

        if (levelNumber == 12)
        {
            level12.SetActive(true);
        }
    }
    public void NextLevel()
    {
        if (levelNumber == 1)
        {
            level1.SetActive(false);
            level2.SetActive(true);
        }
        if (levelNumber == 2)
        {
            level2.SetActive(false);
            level3.SetActive(true);
        }
        if (levelNumber == 3)
        {
            level3.SetActive(false);
            level4.SetActive(true);
        }
        if (levelNumber == 4)
        {
            level4.SetActive(false);
            level5.SetActive(true);
        }
        if (levelNumber == 5)
        {
            level5.SetActive(false);
            level6.SetActive(true);
        }
        if (levelNumber == 6)
        {
            level6.SetActive(false);
            level7.SetActive(true);
        }
        if (levelNumber == 7)
        {
            level7.SetActive(false);
            level8.SetActive(true);
        }
        if (levelNumber == 8)
        {
            level8.SetActive(false);
            level9.SetActive(true);
        }
        if (levelNumber == 9)
        {
            level9.SetActive(false);
            level10.SetActive(true);
        }
        if (levelNumber == 10)
        {
            level10.SetActive(false);
            level11.SetActive(true);
        }
        if (levelNumber == 11)
        {
            level11.SetActive(false);
            level12.SetActive(true);
        }

        if (beatGameScreen.activeSelf)
        {
            beatGameScreen.SetActive(false);
            level1.SetActive(true);
        }
        
        if (levelNumber == 12)
        {
            level12.SetActive(false);
            beatGameScreen.SetActive(true);
        }
        
        WhatsTheNumber();
    }

    public void SetLevelsInactive()
    {
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
        level6.SetActive(false);
        level7.SetActive(false);
        level8.SetActive(false);
        level9.SetActive(false);
        level10.SetActive(false);
        level11.SetActive(false);
        level12.SetActive(false);
        beatGameScreen.SetActive(false);
        levelNumber = 0;
    }
}