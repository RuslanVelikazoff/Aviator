using UnityEngine;
using UnityEngine.UI;

public class HangarManager : MonoBehaviour
{
    [SerializeField]
    private Text gamemodeText;

    [SerializeField]
    private Button backButton;
    [SerializeField]
    private GameObject mainPanel;
    [SerializeField]
    private GameObject hangarPanel;

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

    private void OnEnable()
    {
        airplanesPanel.SetActive(true);
        mapsPanel.SetActive(false);
        SetSprites();
        SetGamemodeText();
        ButtonClickAction();
    }

    private void ButtonClickAction()
    {
        if (backButton != null)
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(() =>
            {
                mainPanel.SetActive(true);
                hangarPanel.SetActive(false);
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

    private void SetGamemodeText()
    {
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
        {
            gamemodeText.text = "С ВРАГАМИ";
        }

        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 1)
        {
            gamemodeText.text = "БЕЗ ВРАГОВ";
        }
    }
}
