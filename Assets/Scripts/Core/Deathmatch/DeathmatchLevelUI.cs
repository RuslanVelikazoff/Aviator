using System;
using UnityEngine;
using UnityEngine.UI;

public class DeathmatchLevelUI : MonoBehaviour
{
    [SerializeField] 
    private Button pauseButton;
    [SerializeField] 
    private GameObject pausePanel;

    [SerializeField] 
    private GameObject[] hearts;

    [SerializeField] 
    private Text scoreText;

    [SerializeField] 
    private Text coinText;

    private Player player;

    private void Awake()
    {
        //player = FindObjectOfType<Player>();
        
        //SetHeartAmount();
        
        ButtonClickAction();
    }

    private void ButtonClickAction()
    {
        if (pauseButton != null)
        {
            pauseButton.onClick.RemoveAllListeners();
            pauseButton.onClick.AddListener(() =>
            {
                Time.timeScale = 0;
                pausePanel.SetActive(true);
            });
        }
    }

    public void SetHeartAmount()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < player.lifes)
            {
                hearts[i].SetActive(true);
            }
            else
            {
                hearts[i].SetActive(false);
            }
        }
    }
}
