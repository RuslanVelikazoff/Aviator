using UnityEngine;
using UnityEngine.UI;

public class SwipeLevels : MonoBehaviour
{
    [SerializeField]
    private GameObject scrollBar;
    private float scrollPosition = 0;
    private float[] position;

    [SerializeField]
    private GameObject[] playButtons;
    [SerializeField]
    private Text[] buttonTexts;
    [SerializeField]
    private Sprite unlockSprite;
    [SerializeField]
    private Sprite lockSprite;

    [SerializeField]
    private GameObject[] unlockLevelImages;
    [SerializeField]
    private GameObject[] lockLevelImages;
    [SerializeField]
    private Text[] recordTexts;


    private void Start()
    {
        LevelSprite();
    }

    private void Update()
    {
        position = new float[transform.childCount];
        float distance = 1f / (position.Length - 1f);

        for (int i = 0; i < position.Length; i++)
        {
            position[i] = distance * i;
        }

        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began || Input.touches[0].phase == TouchPhase.Moved)
            {
                scrollPosition = scrollBar.GetComponent<Scrollbar>().value;
            }
            else
            {
                for (int i = 0; i < position.Length; i++)
                {
                    if (scrollPosition < position[i] + (distance / 2) && scrollPosition > position[i] - (distance / 2))
                    {
                        scrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollBar.GetComponent<Scrollbar>().value, position[i], .1f);
                        ButtonSprite(i);
                    }
                }
            }
        }

        if (Input.GetMouseButton(0))
        {
            scrollPosition = scrollBar.GetComponent<Scrollbar>().value;
        }
        else if (!Input.GetMouseButton(0))
        {
            for (int i = 0; i < position.Length; i++)
            {
                if (scrollPosition < position[i] + (distance / 2) && scrollPosition > position[i] - (distance / 2))
                {
                    scrollBar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollBar.GetComponent<Scrollbar>().value, position[i], .1f);
                    ButtonSprite(i);
                }
            }
        }
    }

    private void LevelSprite()
    {
        unlockLevelImages[0].SetActive(true);
        recordTexts[0].text = "Your record: " + "\n" + PlayerPrefs.GetInt(Constants.DATA.RECORD_WINTER).ToString();
        lockLevelImages[0].SetActive(false);

        if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_1) == Constants.DATA.TRUE)
        {
            unlockLevelImages[1].SetActive(true);
            recordTexts[1].text = "Your record: " +"\n" + PlayerPrefs.GetInt(Constants.DATA.RECORD_VOLCANO).ToString();
            lockLevelImages[1].SetActive(false);
        }
        else
        {
            unlockLevelImages[1].SetActive(false);
            lockLevelImages[1].SetActive(true);
        }

        if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_2) == Constants.DATA.TRUE)
        {
            unlockLevelImages[2].SetActive(true);
            recordTexts[2].text = "Your record: " + "\n" + PlayerPrefs.GetInt(Constants.DATA.RECORD_FOREST).ToString();
            lockLevelImages[2].SetActive(false);
        }
        else
        {
            unlockLevelImages[2].SetActive(false);
            lockLevelImages[2].SetActive(true);
        }

        if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_3) == Constants.DATA.TRUE)
        {
            unlockLevelImages[3].SetActive(true);
            recordTexts[3].text = "Your record: " + "\n" + PlayerPrefs.GetInt(Constants.DATA.RECORD_CITY).ToString();
            lockLevelImages[3].SetActive(false);
        }
        else
        {
            unlockLevelImages[3].SetActive(false);
            lockLevelImages[3].SetActive(true);
        }

        if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_4) == Constants.DATA.TRUE)
        {
            unlockLevelImages[4].SetActive(true);
            recordTexts[4].text = "Your record: " + "\n" + PlayerPrefs.GetInt(Constants.DATA.RECORD_SPACE).ToString();
            lockLevelImages[4].SetActive(false);
        }
        else
        {
            unlockLevelImages[4].SetActive(false);
            lockLevelImages[4].SetActive(true);
        }
    }

    private void ButtonSprite(int index)
    {
        for (int i = 0; i < playButtons.Length; i++)
        {
            if (i == index)
            {
                continue;
            }
            else
            {
                playButtons[i].SetActive(false);
                buttonTexts[i].text = "";
            }
        }

        if (index == 0)
        {
            playButtons[index].SetActive(true);
            buttonTexts[index].text = "Play";
        }

        if (index == 1)
        {
            playButtons[index].SetActive(true);

            if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_1) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_1) == Constants.DATA.TRUE)
            {
                playButtons[index].GetComponent<Image>().sprite = unlockSprite;
                buttonTexts[index].text = "Play";
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_1) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_1) == Constants.DATA.TRUE)
            {
                playButtons[index].GetComponent<Image>().sprite = lockSprite;
                buttonTexts[index].text = "The level is not purchased";
            }
            else
            {
                playButtons[index].GetComponent<Image>().sprite = lockSprite;
                buttonTexts[index].text = "Will open at the 10 level";
            }
        }

        if (index == 2)
        {
            playButtons[index].SetActive(true);

            if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_2) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_2) == Constants.DATA.TRUE)
            {
                playButtons[index].GetComponent<Image>().sprite = unlockSprite;
                buttonTexts[index].text = "Play";
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_2) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_2) == Constants.DATA.TRUE)
            {
                playButtons[index].GetComponent<Image>().sprite = lockSprite;
                buttonTexts[index].text = "The level is not purchased";
            }
            else
            {
                playButtons[index].GetComponent<Image>().sprite = lockSprite;
                buttonTexts[index].text = "Will open at the 20 level";
            }
        }

        if (index == 3)
        {
            playButtons[index].SetActive(true);

            if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_3) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_3) == Constants.DATA.TRUE)
            {
                playButtons[index].GetComponent<Image>().sprite = unlockSprite;
                buttonTexts[index].text = "Play";
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_3) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_3) == Constants.DATA.TRUE)
            {
                playButtons[index].GetComponent<Image>().sprite = lockSprite;
                buttonTexts[index].text = "The level is not purchased";
            }
            else
            {
                playButtons[index].GetComponent<Image>().sprite = lockSprite;
                buttonTexts[index].text = "Will open at the 30 level";
            }
        }

        if (index == 4)
        {
            playButtons[index].SetActive(true);

            if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_4) == Constants.DATA.TRUE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_4) == Constants.DATA.TRUE)
            {
                playButtons[index].GetComponent<Image>().sprite = unlockSprite;
                buttonTexts[index].text = "Play";
            }
            else if (PlayerPrefs.GetString(Constants.DATA.MAP_BUY_4) == Constants.DATA.FALSE
                && PlayerPrefs.GetString(Constants.DATA.MAP_OPEN_4) == Constants.DATA.TRUE)
            {
                playButtons[index].GetComponent<Image>().sprite = lockSprite;
                buttonTexts[index].text = "The level is not purchased";
            }
            else
            {
                playButtons[index].GetComponent<Image>().sprite = lockSprite;
                buttonTexts[index].text = "Will open at the 40 level";
            }
        }
    }
}
