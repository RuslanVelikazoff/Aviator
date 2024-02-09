using UnityEngine;
using UnityEngine.UI;

public class GamemodePanel : MonoBehaviour
{
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private Button deathmatchButton;
    [SerializeField]
    private Button xpgainingButton;

    [SerializeField]
    private GameObject gamemodePanel;
    [SerializeField]
    private GameObject hangarPanel;

    private void OnEnable()
    {
        ButtonClickAction();
    }

    private void ButtonClickAction()
    {
        if (backButton != null)
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(() =>
            {
                gamemodePanel.SetActive(false);
            });
        }

        if (deathmatchButton != null)
        {
            deathmatchButton.onClick.RemoveAllListeners();
            deathmatchButton.onClick.AddListener(() =>
            {
                PlayerPrefs.SetInt(Constants.DATA.SELECTED_GAMEMODE, 0);
                gamemodePanel.SetActive(false);
                hangarPanel.SetActive(true);
            });
        }

        if (xpgainingButton!= null)
        {
            xpgainingButton.onClick.RemoveAllListeners();
            xpgainingButton.onClick.AddListener(() =>
            {
                PlayerPrefs.SetInt(Constants.DATA.SELECTED_GAMEMODE, 1);
                gamemodePanel.SetActive(false);
                hangarPanel.SetActive(true);
            });
        }
    }
}
