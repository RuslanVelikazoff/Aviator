using UnityEngine.UI;
using UnityEngine;

public class MapsShopManager : MonoBehaviour
{
    [SerializeField]
    private Button[] mapsButtons;
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

    private void OnEnable()
    {
        buyButtonGameObject.SetActive(false);
        MapsButtonClickAction();
        SetSprites();
    }

    private void MapsButtonClickAction()
    {
        if (mapsButtons[0] != null)
        {
            mapsButtons[0].onClick.RemoveAllListeners();
            mapsButtons[0].onClick.AddListener(() =>
            {
                buyButtonGameObject.SetActive(true);
                SetBuyButton(0, 0, 0);
            });
        }

        if (mapsButtons[1] != null)
        {
            mapsButtons[1].onClick.RemoveAllListeners();
            mapsButtons[1].onClick.AddListener(() =>
            {
                buyButtonGameObject.SetActive(true);
                SetBuyButton(1, 10000, 10);
            });
        }

        if (mapsButtons[2] != null)
        {
            mapsButtons[2].onClick.RemoveAllListeners();
            mapsButtons[2].onClick.AddListener(() =>
            {
                buyButtonGameObject.SetActive(true);
                SetBuyButton(2, 20000, 20);
            });
        }

        if (mapsButtons[3] != null)
        {
            mapsButtons[3].onClick.RemoveAllListeners();
            mapsButtons[3].onClick.AddListener(() =>
            {
                buyButtonGameObject.SetActive(true);
                SetBuyButton(3, 30000, 30);
            });
        }

        if (mapsButtons[4] != null)
        {
            mapsButtons[4].onClick.RemoveAllListeners();
            mapsButtons[4].onClick.AddListener(() =>
            {
                buyButtonGameObject.SetActive(true);
                SetBuyButton(4, 40000, 40);
            });
        }
    }

    private void BuyButtonClickAction(int index, int cost, int level)
    {
        if (buyButton != null)
        {
            buyButton.onClick.RemoveAllListeners();
            buyButton.onClick.AddListener(() =>
            {
                if (index == 0)
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.COIN) - cost >= 0)
                    {
                        PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) - cost);
                        UpdateCoinText();

                        PlayerPrefs.SetString(Constants.DATA.MAP_BUY_0, Constants.DATA.TRUE);
                        SetBuyButton(index, cost, level);
                    }
                    else
                    {
                        Debug.Log("Недостаточно средств");
                    }
                }

                if (index == 1)
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.COIN) - cost >= 0)
                    {
                        PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) - cost);
                        UpdateCoinText();

                        PlayerPrefs.SetString(Constants.DATA.MAP_BUY_1, Constants.DATA.TRUE);
                        SetBuyButton(index, cost, level);
                    }
                    else
                    {
                        Debug.Log("Недостаточно средств");
                    }
                }

                if (index == 2)
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.COIN) - cost >= 0)
                    {
                        PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) - cost);
                        UpdateCoinText();

                        PlayerPrefs.SetString(Constants.DATA.MAP_BUY_2, Constants.DATA.TRUE);
                        SetBuyButton(index, cost, level);
                    }
                    else
                    {
                        Debug.Log("Недостаточно средств");
                    }
                }

                if (index == 3)
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.COIN) - cost >= 0)
                    {
                        PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) - cost);
                        UpdateCoinText();

                        PlayerPrefs.SetString(Constants.DATA.MAP_BUY_3, Constants.DATA.TRUE);
                        SetBuyButton(index, cost, level);
                    }
                    else
                    {
                        Debug.Log("Недостаточно средств");
                    }
                }

                if (index == 4)
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.COIN) - cost >= 0)
                    {
                        PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) - cost);
                        UpdateCoinText();

                        PlayerPrefs.SetString(Constants.DATA.MAP_BUY_4, Constants.DATA.TRUE);
                        SetBuyButton(index, cost, level);
                    }
                    else
                    {
                        Debug.Log("Недостаточно средств");
                    }
                }
            });
        }
    }

    private void SetBuyButton(int index, int cost, int level)
    {
        if (index == 0)
        {
            if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_0) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_0) == Constants.DATA.TRUE)
            {
                buyButtonGameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_0) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_0) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Buy for " + cost + " coins";
                BuyButtonClickAction(index, cost, level);
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_0) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_0) == Constants.DATA.FALSE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Will open at the " + level + " level";
            }
        }

        if (index == 1)
        {
            if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_1) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_1) == Constants.DATA.TRUE)
            {
                buyButtonGameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_1) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_1) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Buy for " + cost + " coins";
                BuyButtonClickAction(index, cost, level);
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_1) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_1) == Constants.DATA.FALSE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Will open at the " + level + " level";
            }
        }

        if (index == 2)
        {
            if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_2) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_2) == Constants.DATA.TRUE)
            {
                buyButtonGameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_2) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_2) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Buy for " + cost + " coins";
                BuyButtonClickAction(index, cost, level);
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_2) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_2) == Constants.DATA.FALSE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Will open at the " + level + " level";
            }
        }

        if (index == 3)
        {
            if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_3) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_3) == Constants.DATA.TRUE)
            {
                buyButtonGameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_3) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_3) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Buy for " + cost + " coins";
                BuyButtonClickAction(index, cost, level);
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_3) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_3) == Constants.DATA.FALSE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Will open at the " + level + " level";
            }
        }

        if (index == 4)
        {
            if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_4) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_4) == Constants.DATA.TRUE)
            {
                buyButtonGameObject.SetActive(false);
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_4) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_4) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Buy for " + cost + " coins";
                BuyButtonClickAction(index, cost, level);
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_4) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_4) == Constants.DATA.FALSE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Will open at the " + level + " level";
            }
        }
    }

    private void SetSprites()
    {
        if (PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_0) == Constants.DATA.TRUE)
        {
            mapsButtons[0].GetComponent<Image>().sprite = unlockSprites[0];
        }
        else if (PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_0) == Constants.DATA.FALSE)
        {
            mapsButtons[0].GetComponent<Image>().sprite = lockSprites[0];
        }

        if (PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_1) == Constants.DATA.TRUE)
        {
            mapsButtons[1].GetComponent<Image>().sprite = unlockSprites[1];
        }
        else if (PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_1) == Constants.DATA.FALSE)
        {
            mapsButtons[1].GetComponent<Image>().sprite = lockSprites[1];
        }

        if (PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_2) == Constants.DATA.TRUE)
        {
            mapsButtons[2].GetComponent<Image>().sprite = unlockSprites[2];
        }
        else if (PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_2) == Constants.DATA.FALSE)
        {
            mapsButtons[2].GetComponent<Image>().sprite = lockSprites[2];
        }

        if (PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_3) == Constants.DATA.TRUE)
        {
            mapsButtons[3].GetComponent<Image>().sprite = unlockSprites[3];
        }
        else if (PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_3) == Constants.DATA.FALSE)
        {
            mapsButtons[3].GetComponent<Image>().sprite = lockSprites[3];
        }

        if (PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_4) == Constants.DATA.TRUE)
        {
            mapsButtons[4].GetComponent<Image>().sprite = unlockSprites[4];
        }
        else if (PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_0) == Constants.DATA.FALSE)
        {
            mapsButtons[4].GetComponent<Image>().sprite = lockSprites[4];
        }
    }

    private void UpdateCoinText()
    {
        coinText.text = PlayerPrefs.GetInt(Constants.DATA.COIN).ToString();
    }
}
