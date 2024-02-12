using UnityEngine;
using UnityEngine.UI;

public class XPLosePanel : MonoBehaviour
{
    [SerializeField]
    private Button continueButton;
    [SerializeField]
    private Button exitButton;
    [SerializeField]
    private Button restartButton;

    [SerializeField]
    private Text coinText;
    [SerializeField]
    private Text pointText;
    [SerializeField]
    private Text recordText;

    [SerializeField]
    private XPLevelGamemanager gamemanager;

    private void OnEnable()
    {
        ButtonClickAction();
        SetTexts();
    }

    private void ButtonClickAction()
    {
        if (continueButton != null)
        {
            continueButton.onClick.RemoveAllListeners();
            continueButton.onClick.AddListener(() =>
            {
                gamemanager.ContinueGame();
                Debug.Log("Continue");
            });
        }

        if (exitButton != null)
        {
            exitButton.onClick.RemoveAllListeners();
            exitButton.onClick.AddListener(() =>
            {
                gamemanager.ExitGame();
                Debug.Log("Exit");
            });
        }

        if (restartButton != null)
        {
            restartButton.onClick.RemoveAllListeners();
            restartButton.onClick.AddListener(() =>
            {
                gamemanager.RestartGame();
                Debug.Log("Restart");
            });
        }
    }

    private void SetTexts()
    {
        coinText.text = "+" + gamemanager.coins;
        int points = (int)gamemanager.points;
        pointText.text = points.ToString();

        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 0)
        {
            recordText.text = PlayerPrefs.GetInt(Constants.DATA.RECORD_WINTER).ToString();
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 1)
        {
            recordText.text = PlayerPrefs.GetInt(Constants.DATA.RECORD_VOLCANO).ToString();
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 2)
        {
            recordText.text = PlayerPrefs.GetInt(Constants.DATA.RECORD_FOREST).ToString();
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 3)
        {
            recordText.text = PlayerPrefs.GetInt(Constants.DATA.RECORD_CITY).ToString();
        }
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 4)
        {
            recordText.text = PlayerPrefs.GetInt(Constants.DATA.RECORD_SPACE).ToString();
        }
    }
}
