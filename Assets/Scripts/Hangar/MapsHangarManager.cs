using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapsHangarManager : MonoBehaviour
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
    private Button[] mapsButtons;
    [SerializeField]
    private GameObject[] mapsButtonsGameObjects;

    private void OnEnable()
    {
        playButtonGameObject.SetActive(false);
        SetActiveMaps();
        MapsButtonClickAction();
    }

    private void SetActiveMaps()
    {
        if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_0) == Constants.DATA.TRUE)
        {
            mapsButtonsGameObjects[0].SetActive(true);
        }
        else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_0) == Constants.DATA.FALSE)
        {
            mapsButtonsGameObjects[0].SetActive(false);
        }

        if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_1) == Constants.DATA.TRUE)
        {
            mapsButtonsGameObjects[1].SetActive(true);
        }
        else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_1) == Constants.DATA.FALSE)
        {
            mapsButtonsGameObjects[1].SetActive(false);
        }

        if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_2) == Constants.DATA.TRUE)
        {
            mapsButtonsGameObjects[2].SetActive(true);
        }
        else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_2) == Constants.DATA.FALSE)
        {
            mapsButtonsGameObjects[2].SetActive(false);
        }

        if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_3) == Constants.DATA.TRUE)
        {
            mapsButtonsGameObjects[3].SetActive(true);
        }
        else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_3) == Constants.DATA.FALSE)
        {
            mapsButtonsGameObjects[3].SetActive(false);
        }

        if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_4) == Constants.DATA.TRUE)
        {
            mapsButtonsGameObjects[4].SetActive(true);
        }
        else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_4) == Constants.DATA.FALSE)
        {
            mapsButtonsGameObjects[4].SetActive(false);
        }
    }

    private void MapsButtonClickAction()
    {
        if (mapsButtons[0] != null)
        {
            mapsButtons[0].onClick.RemoveAllListeners();
            mapsButtons[0].onClick.AddListener(() =>
            {
                playButtonGameObject.SetActive(true);
                SetBuyButton(0);
            });
        }

        if (mapsButtons[1] != null)
        {
            mapsButtons[1].onClick.RemoveAllListeners();
            mapsButtons[1].onClick.AddListener(() =>
            {
                playButtonGameObject.SetActive(true);
                SetBuyButton(1);
            });
        }

        if (mapsButtons[2] != null)
        {
            mapsButtons[2].onClick.RemoveAllListeners();
            mapsButtons[2].onClick.AddListener(() =>
            {
                playButtonGameObject.SetActive(true);
                SetBuyButton(2);
            });
        }

        if (mapsButtons[3] != null)
        {
            mapsButtons[3].onClick.RemoveAllListeners();
            mapsButtons[3].onClick.AddListener(() =>
            {
                playButtonGameObject.SetActive(true);
                SetBuyButton(3);
            });
        }

        if (mapsButtons[4] != null)
        {
            mapsButtons[4].onClick.RemoveAllListeners();
            mapsButtons[4].onClick.AddListener(() =>
            {
                playButtonGameObject.SetActive(true);
                SetBuyButton(4);
            });
        }
    }

    private void SetBuyButton(int index)
    {
        if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == index)
        {
            PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, index);
            playButton.GetComponent<Image>().sprite = playSprite;
            playButtonText.text = "Play";
            PlayButtonClickAction(index);
        }
        else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) != index)
        {
            playButton.GetComponent<Image>().sprite = unlockSprite;
            playButtonText.text = "Select";
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
                if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 0) //Winter
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

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 1) //Volcano
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

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 2) //Forest
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

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 3) //City
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

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 4) //Space
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

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) != index)
                {
                    PlayerPrefs.SetInt(Constants.DATA.SELECTED_LEVEL, index);
                    SetBuyButton(index);
                }
            });
        }
    }
}
