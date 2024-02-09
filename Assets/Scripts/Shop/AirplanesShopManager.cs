using UnityEngine;
using UnityEngine.UI;

public class AirplanesShopManager : MonoBehaviour
{
    [SerializeField]
    private Button[] airplanesButtons;
    [SerializeField]
    private Sprite[] unlockSprites;
    [SerializeField]
    private Sprite[] lockSprites;

    [SerializeField]
    private Button buyButton;
    [SerializeField]
    private GameObject buyButtonGameObject;
    [SerializeField]
    private Sprite unlockSprite;
    [SerializeField]
    private Sprite lockSprite;
    [SerializeField]
    private Text buyButtonText;

    [SerializeField]
    private Text coinText;

    [SerializeField]
    private StartData data;

    private void OnEnable()
    {
        buyButtonGameObject.SetActive(false);
        AirplanesButtonClickAction();
        SetSprites();
    }

    private void AirplanesButtonClickAction()
    {
        if (airplanesButtons[0] != null)
        {
            airplanesButtons[0].onClick.RemoveAllListeners();
            airplanesButtons[0].onClick.AddListener(() =>
            {
                buyButtonGameObject.SetActive(true);
                SetBuyButton(0, 0, 0); 
            });
        }

        if (airplanesButtons[1] != null)
        {
            airplanesButtons[1].onClick.RemoveAllListeners();
            airplanesButtons[1].onClick.AddListener(() =>
            {
                buyButtonGameObject.SetActive(true);
                SetBuyButton(1, 10000, 10);
            });
        }

        if (airplanesButtons[2] != null)
        {
            airplanesButtons[2].onClick.RemoveAllListeners();
            airplanesButtons[2].onClick.AddListener(() =>
            {
                buyButtonGameObject.SetActive(true);
                SetBuyButton(2, 20000, 15);
            });
        }

        if (airplanesButtons[3] != null)
        {
            airplanesButtons[3].onClick.RemoveAllListeners();
            airplanesButtons[3].onClick.AddListener(() =>
            {
                buyButtonGameObject.SetActive(true);
                SetBuyButton(3, 30000, 20);
            });
        }

        if (airplanesButtons[4] != null)
        {
            airplanesButtons[4].onClick.RemoveAllListeners();
            airplanesButtons[4].onClick.AddListener(() =>
            {
                buyButtonGameObject.SetActive(true);
                SetBuyButton(4, 40000, 30);
            });
        }

        if (airplanesButtons[5] != null)
        {
            airplanesButtons[5].onClick.RemoveAllListeners();
            airplanesButtons[5].onClick.AddListener(() =>
            {
                buyButtonGameObject.SetActive(true);
                SetBuyButton(5, 50000, 40);
            });
        }
    }

    private void BuyButtonClickAction(bool buy, bool select, int index, int cost, int level)
    {
        if (buyButton != null)
        {
            buyButton.onClick.RemoveAllListeners();
            buyButton.onClick.AddListener(() =>
            {
                if (buy)
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.COIN) - cost >= 0)
                    {
                        PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) - cost);
                        UpdateCoinText();

                        data._airplanesBuy[index] = true;
                        data.Save();
                        PlayerPrefs.SetInt(Constants.DATA.SELECTED_AIRPLANES, index);
                        SetBuyButton(index, cost, level);
                    }
                    else
                    {
                        Debug.Log("Недостаточно средств");
                    }
                }

                if (select)
                {
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_AIRPLANES, index);
                    SetBuyButton(index, cost, level);
                }
            });
        }
    }

    private void SetBuyButton(int index, int cost, int level)
    {
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index && data._airplanesBuy[index] && data._airplanesOpen[index])
        {
            buyButton.GetComponent<Image>().sprite = lockSprite;
            buyButtonText.text = "SELECTED";
        }
        else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index && !data._airplanesBuy[index] && data._airplanesOpen[index])
        {
            buyButton.GetComponent<Image>().sprite = unlockSprite;
            buyButtonText.text = "BUY " + cost + " COINS";
            BuyButtonClickAction(true, false, index, cost, level);
        }
        else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index && data._airplanesBuy[index] && data._airplanesOpen[index])
        {
            buyButton.GetComponent<Image>().sprite = unlockSprite;
            buyButtonText.text = "SELECT";
            BuyButtonClickAction(false, true, index, cost, level);
        }
        else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index && !data._airplanesBuy[index] && !data._airplanesOpen[index])
        {
            buyButton.GetComponent<Image>().sprite = lockSprite;
            buyButtonText.text = "UNLOCK ON LVL " + level;
        }
    }

    private void SetSprites()
    {
        for (int i = 0; i < lockSprites.Length; i++)
        {
            if (data._airplanesOpen[i])
            {
                airplanesButtons[i].GetComponent<Image>().sprite = unlockSprites[i];
            }
            else
            {
                airplanesButtons[i].GetComponent<Image>().sprite = lockSprites[i];
            }
        }
    }

    private void UpdateCoinText()
    {
        coinText.text = PlayerPrefs.GetInt(Constants.DATA.COIN).ToString();
    }
}
