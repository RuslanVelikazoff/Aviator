using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AirplaneHangarManager : MonoBehaviour
{
    [SerializeField]
    private Button playButton;
    [SerializeField]
    private GameObject playButtonGameObject;
    [SerializeField]
    private Text playButtonText;
    [SerializeField]
    private Sprite unlockSprite;
    [SerializeField]
    private Sprite playSprite;

    [SerializeField]
    private Button[] airplanesButtons;
    [SerializeField]
    private GameObject[] airplanesButtonsGameObjects;

    private void OnEnable()
    {
        playButtonGameObject.SetActive(false);
        SetActiveAirplanes();
        AirplanesButtonClickAction();
    }

    private void SetActiveAirplanes()
    {
        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_0) == Constants.DATA.TRUE)
        {
            airplanesButtonsGameObjects[0].SetActive(true);
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_0) == Constants.DATA.FALSE)
        {
            airplanesButtonsGameObjects[0].SetActive(false);
        }

        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_1) == Constants.DATA.TRUE)
        {
            airplanesButtonsGameObjects[1].SetActive(true);
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_1) == Constants.DATA.FALSE)
        {
            airplanesButtonsGameObjects[1].SetActive(false);
        }

        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_2) == Constants.DATA.TRUE)
        {
            airplanesButtonsGameObjects[2].SetActive(true);
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_2) == Constants.DATA.FALSE)
        {
            airplanesButtonsGameObjects[2].SetActive(false);
        }

        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_3) == Constants.DATA.TRUE)
        {
            airplanesButtonsGameObjects[3].SetActive(true);
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_3) == Constants.DATA.FALSE)
        {
            airplanesButtonsGameObjects[3].SetActive(false);
        }

        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_4) == Constants.DATA.TRUE)
        {
            airplanesButtonsGameObjects[4].SetActive(true);
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_4) == Constants.DATA.FALSE)
        {
            airplanesButtonsGameObjects[4].SetActive(false);
        }

        if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_5) == Constants.DATA.TRUE)
        {
            airplanesButtonsGameObjects[5].SetActive(true);
        }
        else if (PlayerPrefs.GetString(Constants.DATA.AIRPLANE_BUY_5) == Constants.DATA.FALSE)
        {
            airplanesButtonsGameObjects[5].SetActive(false);
        }
    }

    private void AirplanesButtonClickAction()
    {
        if (airplanesButtons[0] != null)
        {
            airplanesButtons[0].onClick.RemoveAllListeners();
            airplanesButtons[0].onClick.AddListener(() =>
            {
                playButtonGameObject.SetActive(true);
                SetBuyButton(0);
            });
        }

        if (airplanesButtons[1] != null)
        {
            airplanesButtons[1].onClick.RemoveAllListeners();
            airplanesButtons[1].onClick.AddListener(() =>
            {
                playButtonGameObject.SetActive(true);
                SetBuyButton(1);
            });
        }

        if (airplanesButtons[2] != null)
        {
            airplanesButtons[2].onClick.RemoveAllListeners();
            airplanesButtons[2].onClick.AddListener(() =>
            {
                playButtonGameObject.SetActive(true);
                SetBuyButton(2);
            });
        }

        if (airplanesButtons[3] != null)
        {
            airplanesButtons[3].onClick.RemoveAllListeners();
            airplanesButtons[3].onClick.AddListener(() =>
            {
                playButtonGameObject.SetActive(true);
                SetBuyButton(3);
            });
        }

        if (airplanesButtons[4] != null)
        {
            airplanesButtons[4].onClick.RemoveAllListeners();
            airplanesButtons[4].onClick.AddListener(() =>
            {
                playButtonGameObject.SetActive(true);
                SetBuyButton(4);
            });
        }

        if (airplanesButtons[5] != null)
        {
            airplanesButtons[5].onClick.RemoveAllListeners();
            airplanesButtons[5].onClick.AddListener(() =>
            {
                playButtonGameObject.SetActive(true);
                SetBuyButton(5);
            });
        }
    }

    private void SetBuyButton(int index)
    {
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index)
        {
            PlayerPrefs.SetInt(Constants.DATA.SELECTED_AIRPLANES, index);
            playButton.GetComponent<Image>().sprite = playSprite;
            playButtonText.text = "ИГРАТЬ";
            PlayButtonClickAction(index);
        }
        else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index)
        {
            playButton.GetComponent<Image>().sprite = unlockSprite;
            playButtonText.text = "ВЫБРАТЬ";
            PlayButtonClickAction(index);
        }
    }

    private void PlayButtonClickAction(int index)
    {
        if (playButton != null)
        {
            playButton.onClick.RemoveAllListeners();
            playButton.onClick.AddListener(() =>
            {
                if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 0) //Winter
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
                    {
                        SceneManager.LoadScene(1);
                    }
                    else if(PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 1)
                    {
                        SceneManager.LoadScene(6);
                    }
                }

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 1) //Volcano
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
                    {
                        SceneManager.LoadScene(2);
                    }
                    else
                    {
                        SceneManager.LoadScene(7);
                    }
                }

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 2) //Forest
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
                    {
                        SceneManager.LoadScene(3);
                    }
                    else
                    {
                        SceneManager.LoadScene(8);
                    }
                }

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 3) //City
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
                    {
                        SceneManager.LoadScene(4);
                    }
                    else
                    {
                        SceneManager.LoadScene(9);
                    }
                }

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 4) //Space
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
                    {
                        SceneManager.LoadScene(5);
                    }
                    else
                    {
                        SceneManager.LoadScene(10);
                    }
                }

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index)
                {
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_AIRPLANES, index);
                    SetBuyButton(index);
                }
            });
        }
    }
}
