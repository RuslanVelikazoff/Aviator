using UnityEngine;

public class Data : MonoBehaviour
{
    private void Awake()
    {
        SetMapsData();
        SetAirplanesData();
    }

    private void SetMapsData()
    {
        //Maps open?
        if (!PlayerPrefs.HasKey(Constants.DATA.MAP_OPEN_0))
        {
            PlayerPrefs.SetString(Constants.DATA.MAP_OPEN_0, Constants.DATA.TRUE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.MAP_OPEN_1))
        {
            PlayerPrefs.SetString(Constants.DATA.MAP_OPEN_1, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.MAP_OPEN_2))
        {
            PlayerPrefs.SetString(Constants.DATA.MAP_OPEN_2, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.MAP_OPEN_3))
        {
            PlayerPrefs.SetString(Constants.DATA.MAP_OPEN_3, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.MAP_OPEN_4))
        {
            PlayerPrefs.SetString(Constants.DATA.MAP_OPEN_4, Constants.DATA.FALSE);
        }

        //Maps buy?
        if (!PlayerPrefs.HasKey(Constants.DATA.MAP_BUY_0))
        {
            PlayerPrefs.SetString(Constants.DATA.MAP_BUY_0, Constants.DATA.TRUE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.MAP_BUY_1))
        {
            PlayerPrefs.SetString(Constants.DATA.MAP_BUY_1, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.MAP_BUY_2))
        {
            PlayerPrefs.SetString(Constants.DATA.MAP_BUY_2, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.MAP_BUY_3))
        {
            PlayerPrefs.SetString(Constants.DATA.MAP_BUY_3, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.MAP_BUY_4))
        {
            PlayerPrefs.SetString(Constants.DATA.MAP_BUY_4, Constants.DATA.FALSE);
        }
    }

    private void SetAirplanesData()
    {
        //Airplanes open?
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_OPEN_0))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_OPEN_0, Constants.DATA.TRUE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_OPEN_1))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_OPEN_1, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_OPEN_2))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_OPEN_2, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_OPEN_3))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_OPEN_3, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_OPEN_4))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_OPEN_4, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_OPEN_5))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_OPEN_5, Constants.DATA.FALSE);
        }

        //Airplanes buy?
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_BUY_0))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_0, Constants.DATA.TRUE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_BUY_1))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_1, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_BUY_2))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_2, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_BUY_3))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_3, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_BUY_4))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_4, Constants.DATA.FALSE);
        }
        if (!PlayerPrefs.HasKey(Constants.DATA.AIRPLANE_BUY_5))
        {
            PlayerPrefs.SetString(Constants.DATA.AIRPLANE_BUY_5, Constants.DATA.FALSE);
        }
    }
}
