using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    private Text levelText;
    [SerializeField]
    private Text coinText;

    [SerializeField]
    private Button backButton;
    [SerializeField]
    private GameObject mainPanel;
    [SerializeField]
    private GameObject shopPanel;

    [SerializeField]
    private Button airplanesButton;
    [SerializeField]
    private GameObject airplanesPanel;
    [SerializeField]
    private Sprite airplanesActiveSprite;
    [SerializeField]
    private Sprite airplanesInactiveSprite;

    [SerializeField]
    private Button mapsButton;
    [SerializeField]
    private GameObject mapsPanel;
    [SerializeField]
    private Sprite mapsActiveSprite;
    [SerializeField]
    private Sprite mapsInactiveSprite;

    private void Start()
    {
        ButtonClickAction();
    }

    private void OnEnable()
    {
        airplanesPanel.SetActive(true);
        mapsPanel.SetActive(false);
        SetSprites();
        SetTexts();
    }

    private void ButtonClickAction()
    {
        if (backButton != null)
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(() =>
            {
                shopPanel.SetActive(false);
                mainPanel.SetActive(true);
            });
        }

        if (airplanesButton != null)
        {
            airplanesButton.onClick.RemoveAllListeners();
            airplanesButton.onClick.AddListener(() =>
            {
                airplanesPanel.SetActive(true);
                mapsPanel.SetActive(false);
                SetSprites();
            });
        }

        if (mapsButton != null)
        {
            mapsButton.onClick.RemoveAllListeners();
            mapsButton.onClick.AddListener(() =>
            {
                mapsPanel.SetActive(true);
                airplanesPanel.SetActive(false);
                SetSprites();
            });
        }
    }

    private void SetSprites()
    {
        if (airplanesPanel.activeInHierarchy)
        {
            airplanesButton.GetComponent<Image>().sprite = airplanesActiveSprite;
            mapsButton.GetComponent<Image>().sprite = mapsInactiveSprite;
        }

        if (mapsPanel.activeInHierarchy)
        {
            airplanesButton.GetComponent<Image>().sprite = airplanesInactiveSprite;
            mapsButton.GetComponent<Image>().sprite = mapsActiveSprite;
        }
    }

    private void SetTexts()
    {
        levelText.text = "Уровень " + PlayerPrefs.GetInt(Constants.DATA.LEVEL);
        coinText.text = PlayerPrefs.GetInt(Constants.DATA.COIN).ToString();
    }


}
