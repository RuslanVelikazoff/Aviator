using UnityEngine;
using UnityEngine.UI;

public class MainPanelManager : MonoBehaviour
{
    [SerializeField]
    private Text coinText;
    [SerializeField]
    private Text levelText;
    [SerializeField]
    private Text expText;

    [SerializeField]
    private Button[] levelButtons;
    [SerializeField]
    private Button shopButton;

    [SerializeField]
    private Button donateButton;

    [SerializeField]
    private GameObject mainPanel;
    [SerializeField]
    private GameObject shopPanel;
    [SerializeField]
    private GameObject gamemodePanel;
    [SerializeField]
    private GameObject donatePanel;

    [SerializeField] 
    private LevelUp levelManager;

    private void OnEnable()
    {
        ButtonClickAction();

        coinText.text = PlayerPrefs.GetInt(Constants.DATA.COIN).ToString();

        levelText.text = PlayerPrefs.GetInt(Constants.DATA.LEVEL).ToString();

        if (PlayerPrefs.GetInt(Constants.DATA.LEVEL) < levelManager.maxLevel)
        {
            expText.text = PlayerPrefs.GetInt(Constants.DATA.EXP)
                           + " / " + levelManager.expNeeded[PlayerPrefs.GetInt(Constants.DATA.LEVEL) - 1];
        }
        else
        {
            expText.text = PlayerPrefs.GetInt(Constants.DATA.EXP).ToString();
        }
    }

    private void Start()
    {
        mainPanel.SetActive(true);
        shopPanel.SetActive(false);
        gamemodePanel.SetActive(false);
    }

    private void ButtonClickAction()
    {

        #region LevelButtons

        if (levelButtons[0] != null)
        {
            levelButtons[0].onClick.RemoveAllListeners();
            levelButtons[0].onClick.AddListener(() =>
            {
                if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_0) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_0) == Constants.DATA.TRUE)
                {
                    gamemodePanel.SetActive(true);
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, 0);
                }
                else
                {
                    Debug.Log("Level locked");
                }
            });
        }

        if (levelButtons[1] != null)
        {
            levelButtons[1].onClick.RemoveAllListeners();
            levelButtons[1].onClick.AddListener(() =>
            {
                if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_1) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_1) == Constants.DATA.TRUE)
                {
                    gamemodePanel.SetActive(true);
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, 1);
                }
                else
                {
                    Debug.Log("Level locked");
                }
            });
        }

        if (levelButtons[2] != null)
        {
            levelButtons[2].onClick.RemoveAllListeners();
            levelButtons[2].onClick.AddListener(() =>
            {
                if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_2) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_2) == Constants.DATA.TRUE)
                {
                    gamemodePanel.SetActive(true);
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, 2);
                }
                else
                {
                    Debug.Log("Level locked");
                }
            });
        }

        if (levelButtons[3] != null)
        {
            levelButtons[3].onClick.RemoveAllListeners();
            levelButtons[3].onClick.AddListener(() =>
            {
                if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_3) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_3) == Constants.DATA.TRUE)
                {
                    gamemodePanel.SetActive(true);
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, 3);
                }
                else
                {
                    Debug.Log("Level locked");
                }
            });
        }

        if (levelButtons[4] != null)
        {
            levelButtons[4].onClick.RemoveAllListeners();
            levelButtons[4].onClick.AddListener(() =>
            {
                if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_4) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_4) == Constants.DATA.TRUE)
                {
                    gamemodePanel.SetActive(true);
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, 4);
                }
                else
                {
                    Debug.Log("Level locked");
                }
            });
        }

        #endregion

        if (shopButton != null)
        {
            shopButton.onClick.RemoveAllListeners();
            shopButton.onClick.AddListener(() =>
            {
                mainPanel.SetActive(false);
                shopPanel.SetActive(true);
            });
        }

        if (donateButton != null)
        {
            donateButton.onClick.RemoveAllListeners();
            donateButton.onClick.AddListener(() =>
            {
                mainPanel.SetActive(false);
                donatePanel.SetActive(true);
            });
        }
    }
}
