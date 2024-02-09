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
    private StartData data;

    private void OnEnable()
    {
        coinText.text = PlayerPrefs.GetInt(Constants.DATA.COIN).ToString();

        levelText.text = PlayerPrefs.GetInt(Constants.DATA.LEVEL).ToString();

        expText.text = PlayerPrefs.GetInt(Constants.DATA.EXP) + " / 1000"; //TODO: продумать систему прокачки
    }

    private void Start()
    {
        mainPanel.SetActive(true);
        shopPanel.SetActive(false);

        ButtonClickAction();
    }

    private void ButtonClickAction()
    {

        #region LevelButtons

        if (levelButtons[0] != null)
        {
            levelButtons[0].onClick.RemoveAllListeners();
            levelButtons[0].onClick.AddListener(() =>
            {
                if (data._mapsBuy[0])
                {
                    Debug.Log("Winter level");
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
                if (data._mapsBuy[1])
                {
                    Debug.Log("Volcano level");
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
                if (data._mapsBuy[2])
                {
                    Debug.Log("Forest level");
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
                if (data._mapsOpen[3])
                {
                    Debug.Log("City level");
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
                if (data._mapsOpen[4])
                {
                    Debug.Log("Space level");
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
