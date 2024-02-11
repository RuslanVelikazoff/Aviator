using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathmatchGamemanager : MonoBehaviour
{
    public int coins;
    public float points;
    
    [SerializeField]
    private DeathmatchLevelUI levelUI;
    
    private Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void FixedUpdate()
    {
        CollectedPoints();
        CollectedPoints();
    }

    public void CollectedCoin(int amount)
    {
        coins += amount;
        levelUI.SetCoinAmount(coins);
    }

    public void CollectedPoints()
    {
        points += .04f;
        levelUI.SetPointsAmount((int)points);
        
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 0)
        {
            if (points >= PlayerPrefs.GetInt(Constants.DATA.RECORD_WINTER))
            {
                PlayerPrefs.SetInt(Constants.DATA.RECORD_WINTER, (int)points);
            }
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 1)
        {
            if (points >= PlayerPrefs.GetInt(Constants.DATA.RECORD_VOLCANO))
            {
                PlayerPrefs.SetInt(Constants.DATA.RECORD_VOLCANO, (int)points);
            }
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 2)
        {
            if (points >= PlayerPrefs.GetInt(Constants.DATA.RECORD_FOREST))
            {
                PlayerPrefs.SetInt(Constants.DATA.RECORD_FOREST, (int)points);
            }
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 3)
        {
            if (points >= PlayerPrefs.GetInt(Constants.DATA.RECORD_CITY))
            {
                PlayerPrefs.SetInt(Constants.DATA.RECORD_CITY, (int)points);
            }
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 4)
        {
            if (points >= PlayerPrefs.GetInt(Constants.DATA.RECORD_SPACE))
            {
                PlayerPrefs.SetInt(Constants.DATA.RECORD_SPACE, (int)points);
            }
        }
    }

    public void DamagePlayer()
    {
        player.lifes -= 1;
        levelUI.SetHeartAmount();
        
        if (player.lifes <= 0)
        {
            levelUI.LoseGame();
            Debug.Log("Death");
        }
        else
        {
            player.gameObject.transform.position = new Vector3(-1.7f, 0f, 0f);
        }
    }

    public void SaveGameProgress()
    {
        PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) + coins);
        PlayerPrefs.SetInt(Constants.DATA.EXP, PlayerPrefs.GetInt(Constants.DATA.EXP) + (int)points);
    }

    public void ExitGame()
    {
        SaveGameProgress();
        SceneManager.LoadScene(1);
    }

    public void RestartGame()
    {
        SaveGameProgress();

        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 0)
        {
            SceneManager.LoadScene(3); //Winter deathmatch 
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 1)
        {
            SceneManager.LoadScene(4); //Volcano deathmatch
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 2)
        {
            SceneManager.LoadScene(5); //Forest deathmatch
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 3)
        {
            SceneManager.LoadScene(6); //City deathmatch
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 4)
        {
            SceneManager.LoadScene(7); //Space deathmatch
        }
    }

    public void ContinueGame()
    {
        if (PlayerPrefs.GetInt(Constants.DATA.COIN) - 2000 >= 0)
        {
            PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) - 2000);
            player.RefilLifes();
            levelUI.SetHeartAmount();
            levelUI.ContinueGame();
        }
    }
}
