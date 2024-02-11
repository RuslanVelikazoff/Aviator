using System;
using UnityEngine;

public class DeathmatchGamemanager : MonoBehaviour
{
    public int coins;
    public int points;
    
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
    }

    public void CollectedCoin(int amount)
    {
        coins += amount;
        levelUI.SetCoinAmount(coins);
    }

    public void CollectedPoints()
    {
        points++;
        levelUI.SetPointsAmount(points);
        
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 0)
        {
            if (points >= PlayerPrefs.GetInt(Constants.DATA.RECORD_WINTER))
            {
                PlayerPrefs.SetInt(Constants.DATA.RECORD_WINTER, points);
            }
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 1)
        {
            if (points >= PlayerPrefs.GetInt(Constants.DATA.RECORD_VOLCANO))
            {
                PlayerPrefs.SetInt(Constants.DATA.RECORD_VOLCANO, points);
            }
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 2)
        {
            if (points >= PlayerPrefs.GetInt(Constants.DATA.RECORD_FOREST))
            {
                PlayerPrefs.SetInt(Constants.DATA.RECORD_FOREST, points);
            }
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 3)
        {
            if (points >= PlayerPrefs.GetInt(Constants.DATA.RECORD_CITY))
            {
                PlayerPrefs.SetInt(Constants.DATA.RECORD_CITY, points);
            }
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 4)
        {
            if (points >= PlayerPrefs.GetInt(Constants.DATA.RECORD_SPACE))
            {
                PlayerPrefs.SetInt(Constants.DATA.RECORD_SPACE, points);
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
}
