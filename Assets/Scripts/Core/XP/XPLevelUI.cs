using UnityEngine;
using UnityEngine.UI;

public class XPLevelUI : MonoBehaviour
{
    [SerializeField]
    private Button pauseButton;
    [SerializeField]
    private GameObject pausePanel;

    [SerializeField]
    private GameObject losePanel;

    [SerializeField]
    private GameObject continuePanel;
    [SerializeField]
    private Button continueButton;

    [SerializeField]
    private GameObject[] hearts;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private Text coinText;

    private Player player;
    private XPLevelGamemanager gamemanager;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        gamemanager = FindObjectOfType<XPLevelGamemanager>();

        SetHeartAmount();
        SetCoinAmount(gamemanager.coins);
        
        ButtonClickAction();
    }

    private void ButtonClickAction()
    {
        if (pauseButton != null)
        {
            pauseButton.onClick.RemoveAllListeners();
            pauseButton.onClick.AddListener(() =>
            {
                PauseGame();
            });
        }

        if (continueButton != null)
        {
            continueButton.onClick.RemoveAllListeners();
            continueButton.onClick.AddListener(() =>
            {
                continuePanel.SetActive(false);
                Time.timeScale = 1;
            });
        }
    }

    public void PlayerStartFly()
    {
        player.fly = true;
    }
    public void PlayerStopFly()
    {
        player.fly = false;
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void ContinueGame()
    {
        losePanel.SetActive(false);
        continuePanel.SetActive(true);
    }

    public void LoseGame()
    {
        Time.timeScale = 0;
        losePanel.SetActive(true);
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

    public void SetCoinAmount(int coin)
    {
        coinText.text = coin.ToString();
    }

    public void SetPointsAmount(int points)
    {
        scoreText.text = points.ToString();
    }
}
