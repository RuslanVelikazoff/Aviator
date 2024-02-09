using UnityEngine;
using UnityEngine.UI;

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

    [SerializeField]
    private StartData data;

    private void OnEnable()
    {
        playButtonGameObject.SetActive(false);
        SetActiveMaps();
        AirplanesButtonClickAction();
    }

    private void SetActiveMaps()
    {
        for (int i = 0; i < mapsButtonsGameObjects.Length; i++)
        {
            if (data._mapsBuy[i])
            {
                mapsButtonsGameObjects[i].SetActive(true);
            }
            else
            {
                mapsButtonsGameObjects[i].SetActive(false);
            }
        }
    }

    private void AirplanesButtonClickAction()
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
            playButtonText.text = "PLAY";
            PlayButtonClickAction(index);
        }
        else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) != index)
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
                //TODO: добавить запуск уровня
                if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 0) //Winter
                {
                    //TODO: тут прописать проверку на игровой мод
                    Debug.Log("Airplanes index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES));
                    Debug.Log("Map index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL));
                    Debug.Log("Gamemode index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE));
                }

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 1) //Volcano
                {
                    Debug.Log("Airplanes index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES));
                    Debug.Log("Map index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL));
                    Debug.Log("Gamemode index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE));
                }

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 2) //Forest
                {
                    Debug.Log("Airplanes index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES));
                    Debug.Log("Map index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL));
                    Debug.Log("Gamemode index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE));
                }

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 3) //City
                {
                    Debug.Log("Airplanes index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES));
                    Debug.Log("Map index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL));
                    Debug.Log("Gamemode index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE));
                }

                else if (PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == index && PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL) == 4) //Space
                {
                    Debug.Log("Airplanes index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES));
                    Debug.Log("Map index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_LEVEL));
                    Debug.Log("Gamemode index: " + PlayerPrefs.GetInt(Constants.DATA.SELECTED_GAMEMODE));
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
