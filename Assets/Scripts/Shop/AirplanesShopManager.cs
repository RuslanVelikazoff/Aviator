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
                    if (index == 0)
                    {
                        if (PlayerPrefs.GetInt(Constants.DATA.COIN) - cost >= 0)
                        {
                            PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) - cost);
                            UpdateCoinText();

                            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_0, Constants.DATA.TRUE);
                            PlayerPrefs.SetInt(Constants.DATA.SELECTED_AIRPLANES, index);
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

                            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_1, Constants.DATA.TRUE);
                            PlayerPrefs.SetInt(Constants.DATA.SELECTED_AIRPLANES, index);
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

                            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_2, Constants.DATA.TRUE);
                            PlayerPrefs.SetInt(Constants.DATA.SELECTED_AIRPLANES, index);
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

                            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_3, Constants.DATA.TRUE);
                            PlayerPrefs.SetInt(Constants.DATA.SELECTED_AIRPLANES, index);
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

                            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_4, Constants.DATA.TRUE);
                            PlayerPrefs.SetInt(Constants.DATA.SELECTED_AIRPLANES, index);
                            SetBuyButton(index, cost, level);
                        }
                        else
                        {
                            Debug.Log("Недостаточно средств");
                        }
                    }

                    if (index == 5)
                    {
                        if (PlayerPrefs.GetInt(Constants.DATA.COIN) - cost >= 0)
                        {
                            PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) - cost);
                            UpdateCoinText();

                            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_5, Constants.DATA.TRUE);
                            PlayerPrefs.SetInt(Constants.DATA.SELECTED_AIRPLANES, index);
                            SetBuyButton(index, cost, level);
                        }
                        else
                        {
                            Debug.Log("Недостаточно средств");
                        }
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
        if (index == 0)
        {
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_0) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_0) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Selected";
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_0) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_0) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Buy for " + cost + " coins";
                BuyButtonClickAction(true, false, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_0) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_0) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Select";
                BuyButtonClickAction(false, true, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_0) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_0) == Constants.DATA.FALSE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Will open at the " + level + " level";
            }

            else
            {
                Debug.Log("Bug");
            }
        }

        if (index == 1)
        {
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_1) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_1) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Selected";
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_1) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_1) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Buy for " + cost + " coins";
                BuyButtonClickAction(true, false, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_1) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_1) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Select";
                BuyButtonClickAction(false, true, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_1) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_1) == Constants.DATA.FALSE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Will open at the " + level + " level";
            }

            else
            {
                Debug.Log("Bug");
            }
        }

        if (index == 2)
        {
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_2) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_2) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Selected";
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_2) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_2) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "buy for " + cost + " coins";
                BuyButtonClickAction(true, false, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_2) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_2) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Select";
                BuyButtonClickAction(false, true, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_2) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_2) == Constants.DATA.FALSE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Will open at the " + level + " level";
            }

            else
            {
                Debug.Log("Bug");
            }
        }

        if (index == 3)
        {
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_3) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_3) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Selected";
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_3) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_3) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Buy for " + cost + " coins";
                BuyButtonClickAction(true, false, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_3) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_3) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Select";
                BuyButtonClickAction(false, true, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_3) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_3) == Constants.DATA.FALSE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Will open at the " + level + " level";
            }

            else
            {
                Debug.Log("Bug");
            }
        }

        if (index == 4)
        {
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_4) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_4) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Selected";
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_4) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_4) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Buy for " + cost + " coins";
                BuyButtonClickAction(true, false, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_4) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_4) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Select";
                BuyButtonClickAction(false, true, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_4) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_4) == Constants.DATA.FALSE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Will open at the " + level + " level";
            }

            else
            {
                Debug.Log("Bug");
            }
        }

        if (index == 5)
        {
            if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_5) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_5) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Selected";
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_5) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_5) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Buy for " + cost + " coins";
                BuyButtonClickAction(true, false, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_5) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_5) == Constants.DATA.TRUE)
            {
                buyButton.GetComponent<Image>().sprite = unlockSprite;
                buyButtonText.text = "Select";
                BuyButtonClickAction(false, true, index, cost, level);
            }

            else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_5) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_5) == Constants.DATA.FALSE)
            {
                buyButton.GetComponent<Image>().sprite = lockSprite;
                buyButtonText.text = "Will open at the " + level + " level";
            }

            else
            {
                Debug.Log("Bug");
            }
        }

    }

    private void SetSprites()
    {
        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_0) == Constants.DATA.TRUE)
        {
            airplanesButtons[0].GetComponent<Image>().sprite = unlockSprites[0];
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_0) == Constants.DATA.FALSE)
        {
            airplanesButtons[0].GetComponent<Image>().sprite = lockSprites[0];
        }

        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_1) == Constants.DATA.TRUE)
        {
            airplanesButtons[1].GetComponent<Image>().sprite = unlockSprites[1];
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_1) == Constants.DATA.FALSE)
        {
            airplanesButtons[1].GetComponent<Image>().sprite = lockSprites[1];
        }

        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_2) == Constants.DATA.TRUE)
        {
            airplanesButtons[2].GetComponent<Image>().sprite = unlockSprites[2];
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_2) == Constants.DATA.FALSE)
        {
            airplanesButtons[2].GetComponent<Image>().sprite = lockSprites[2];
        }

        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_3) == Constants.DATA.TRUE)
        {
            airplanesButtons[3].GetComponent<Image>().sprite = unlockSprites[3];
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_3) == Constants.DATA.FALSE)
        {
            airplanesButtons[3].GetComponent<Image>().sprite = lockSprites[3];
        }

        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_4) == Constants.DATA.TRUE)
        {
            airplanesButtons[4].GetComponent<Image>().sprite = unlockSprites[4];
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_4) == Constants.DATA.FALSE)
        {
            airplanesButtons[4].GetComponent<Image>().sprite = lockSprites[4];
        }

        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_5) == Constants.DATA.TRUE)
        {
            airplanesButtons[5].GetComponent<Image>().sprite = unlockSprites[5];
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_OPEN_5) == Constants.DATA.FALSE)
        {
            airplanesButtons[5].GetComponent<Image>().sprite = lockSprites[5];
        }
    }

    private void UpdateCoinText()
    {
        coinText.text = PlayerPrefs.GetInt(Constants.DATA.COIN).ToString();
    }
}
