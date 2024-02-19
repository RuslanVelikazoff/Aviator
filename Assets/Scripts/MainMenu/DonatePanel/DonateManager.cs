using UnityEngine;
using UnityEngine.UI;

public class DonateManager : MonoBehaviour
{
    [SerializeField]
    private Button yesButton;
    [SerializeField]
    private Button noButton;

    [SerializeField]
    private GameObject confirmPanel;
    [SerializeField]
    private GameObject mainPanel;

    [SerializeField]
    private YG.YandexGame sdk;

    private void Start()
    {
        ButtonClickAction();
    }

    private void ButtonClickAction()
    {
        if (yesButton != null)
        {
            yesButton.onClick.RemoveAllListeners();
            yesButton.onClick.AddListener(() =>
            {
                sdk._RewardedShow(1);
            });
        }

        if (noButton != null)
        {
            noButton.onClick.RemoveAllListeners();
            noButton.onClick.AddListener(() =>
            {
                confirmPanel.SetActive(false);
                mainPanel.SetActive(true);
            });
        }
    }

    public void AddCoinCul()
    {
        PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) + 1000);
        confirmPanel.SetActive(false);
        mainPanel.SetActive(true);
    }
}
