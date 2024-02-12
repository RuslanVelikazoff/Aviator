using UnityEngine;

public class XPLevelSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] playerPrefabs;

    [SerializeField]
    private GameObject[] obstaclePrefab;

    private void Awake()
    {
        PlayerSpawn();
        SpawnObstacle(new Vector3(7.14f, 0, 0));
    }

    private void PlayerSpawn()
    {
        Instantiate(playerPrefabs[PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES)],
            new Vector3(-1.7f, 0f, 0f), Quaternion.identity);
    }

    public void SpawnObstacle(Vector3 spawnPosition)
    {
        int obstacleIndex = Random.Range(0, obstaclePrefab.Length - 1);

        Instantiate(obstaclePrefab[obstacleIndex], spawnPosition, Quaternion.identity);
    }
}
