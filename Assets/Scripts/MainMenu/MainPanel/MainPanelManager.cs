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
    private GameObject mainPanel;
    [SerializeField]
    private GameObject shopPanel;
    [SerializeField]
    private GameObject gamemodePanel;

    [SerializeField]
    private StartData data;
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
                if (data._mapsBuy[0] && data._mapsOpen[0])
                {
                    gamemodePanel.SetActive(true);
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, 0);
                }
                else
                {
                    Debug.Log("Volcano level is locked");
                }
            });
        }

        if (levelButtons[1] != null)
        {
            levelButtons[1].onClick.RemoveAllListeners();
            levelButtons[1].onClick.AddListener(() =>
            {
                if (data._mapsBuy[1] && data._mapsOpen[1])
                {
                    gamemodePanel.SetActive(true);
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, 1);
                }
                else
                {
                    Debug.Log("Volcano level is locked");
                }
            });
        }

        if (levelButtons[2] != null)
        {
            levelButtons[2].onClick.RemoveAllListeners();
            levelButtons[2].onClick.AddListener(() =>
            {
                if (data._mapsBuy[2] && data._mapsOpen[2])
                {
                    gamemodePanel.SetActive(true);
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, 2);
                }
                else
                {
                    Debug.Log("Forest level is locked");
                }
            });
        }

        if (levelButtons[3] != null)
        {
            levelButtons[3].onClick.RemoveAllListeners();
            levelButtons[3].onClick.AddListener(() =>
            {
                if (data._mapsBuy[3] && data._mapsOpen[3])
                {
                    gamemodePanel.SetActive(true);
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, 3);
                }
                else
                {
                    Debug.Log("City level is locked");
                }
            });
        }

        if (levelButtons[4] != null)
        {
            levelButtons[4].onClick.RemoveAllListeners();
            levelButtons[4].onClick.AddListener(() =>
            {
                if (data._mapsBuy[4] && data._mapsOpen[4])
                {
                    gamemodePanel.SetActive(true);
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, 4);
                }
                else
                {
                    Debug.Log("Space level is locked");
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
    }
}
