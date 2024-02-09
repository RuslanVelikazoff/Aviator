using UnityEngine;

public class StartData : MonoBehaviour
{
    public bool[] _airplanesOpen;
    public bool[] _mapsOpen;

    public bool[] _airplanesBuy;
    public bool[] _mapsBuy;

    private const string saveKey = "mainSave";

    private void Start()
    {
        Load();
    }

    private void OnApplicationQuit()
    {
        Save();
    }

    private void OnDisable()
    {
        Save();
    }

    public void Load()
    {
        var data = SaveManager.Load<SaveData.GameData>(saveKey);

        _airplanesOpen = data.airplanesOpen;
        _mapsOpen = data.mapsOpen;

        _airplanesBuy = data.airplanesBuy;
        _mapsBuy = data.mapsBuy;

        Debug.Log("Данные загружены");
    }

    public void Save()
    {
        SaveManager.Save(saveKey, GetSaveSnapshot());
        PlayerPrefs.Save();
        Debug.Log("Данные сохранены");
    }

    public SaveData.GameData GetSaveSnapshot()
    {
        var data = new SaveData.GameData()
        {
            airplanesOpen = _airplanesOpen,
            mapsOpen = _mapsOpen,
            airplanesBuy = _airplanesBuy,
            mapsBuy = _mapsBuy
        };

        return data;
    }
}
