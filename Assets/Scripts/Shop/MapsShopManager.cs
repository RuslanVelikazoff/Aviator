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

    [SerializeField]
    private StartData data;

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
                if (PlayerPrefs.GetInt(Constants.DATA.COIN) - cost >= 0)
                {
                    PlayerPrefs.SetInt(Constants.DATA.COIN, PlayerPrefs.GetInt(Constants.DATA.COIN) - cost);
                    UpdateCoinText();

                    data._mapsBuy[index] = true;
                    data.Save();
                    SetBuyButton(index, cost, level);
                }
                else
                {
                    Debug.Log("Недостаточно средств");
                }
            });
        }
    }

    private void SetBuyButton(int index, int cost, int level)
    {
        if (data._mapsBuy[index] && data._mapsOpen[index])
        {
            buyButtonGameObject.SetActive(false);
        }
        else if (!data._mapsBuy[index] && data._mapsOpen[index])
        {
            buyButton.GetComponent<Image>().sprite = unlockSprite;
            buyButtonText.text = "BUY " + cost + " COINS";
            BuyButtonClickAction(index, cost, level);
        }
        else if (!data._mapsBuy[index] && !data._mapsOpen[index])
        {
            buyButton.GetComponent<Image>().sprite = lockSprite;
            buyButtonText.text = "UNLOCK ON LVL " + level;
        }
    }

    private void SetSprites()
    {
        for (int i = 0; i < lockSprites.Length; i++)
        {
            if (data._mapsOpen[i])
            {
                mapsButtons[i].GetComponent<Image>().sprite = unlockSprites[i];
            }
            else
            {
                mapsButtons[i].GetComponent<Image>().sprite = lockSprites[i];
            }
        }
    }

    private void UpdateCoinText()
    {
        coinText.text = PlayerPrefs.GetInt(Constants.DATA.COIN).ToString();
    }
}
