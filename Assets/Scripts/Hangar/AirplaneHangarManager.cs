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

    [SerializeField]
    private StartData data;

    private void OnEnable()
    {
        playButtonGameObject.SetActive(false);
        SetActiveAirplanes();
        AirplanesButtonClickAction();
    }

    private void SetActiveAirplanes()
    {
        for (int i = 0; i < airplanesButtonsGameObjects.Length; i++)
        {
            if (data._airplanesBuy[i])
            {
                airplanesButtonsGameObjects[i].SetActive(true);
            }
            else
            {
                airplanesButtonsGameObjects[i].SetActive(false);
            }
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
            playButtonText.text = "PLAY";
            PlayButtonClickAction(index);
        }
        else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) != index)
        {
            playButton.GetComponent<Image>().sprite = unlockSprite;
            playButtonText.text = "SELECT";
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
                        SceneManager.LoadScene(3);
                    }
                    else if(PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 1)
                    {
                        SceneManager.LoadScene(8);
                    }
                }

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 1) //Volcano
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

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 2) //Forest
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

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 3) //City
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
                    {
                        SceneManager.LoadScene(6);
                    }
                    else
                    {
                        SceneManager.LoadScene(11);
                    }
                }

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 4) //Space
                {
                    if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE) == 0)
                    {
                        SceneManager.LoadScene(7);
                    }
                    else
                    {
                        SceneManager.LoadScene(12);
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
