using UnityEngine;

public class DeathmatchLevelSpawner : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] playerPrefabs;

    private void Awake()
    {
        Instantiate(playerPrefabs[PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES)],
            new Vector3(-1.7f, 0f, 0f), Quaternion.identity);
    }
}
