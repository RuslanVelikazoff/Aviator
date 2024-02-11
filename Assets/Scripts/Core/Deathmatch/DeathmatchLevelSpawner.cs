using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class DeathmatchLevelSpawner : MonoBehaviour
{
    [SerializeField] 
    private GameObject[] playerPrefabs;

    [SerializeField] 
    private float enemySpawnDelay;
    [SerializeField] 
    private GameObject[] enemyPrefabs;
    [SerializeField] 
    private Vector3[] enemyPosSpawn;

    [SerializeField] 
    private float coinSpawnDelay;
    [SerializeField] 
    private GameObject coinPrefab;
    [SerializeField] 
    private Vector3[] coinSpawnPosition;

    private void Awake()
    {
        PlayerSpawn();
        StartCoroutine(EnemySpawnCO());
        StartCoroutine(CoinSpawnCO());
    }

    private void PlayerSpawn()
    {
        Instantiate(playerPrefabs[PlayerPrefs.GetInt(Constants.DATA.SELECTED_AIRPLANES)],
            new Vector3(-1.7f, 0f, 0f), Quaternion.identity);
    }

    private IEnumerator CoinSpawnCO()
    {
        CoinSpawn();
        yield return new WaitForSeconds(coinSpawnDelay);
        StartCoroutine(CoinSpawnCO());
    }

    private void CoinSpawn()
    {
        int randomPosition = Random.Range(0, 2);

        if (randomPosition == 0)
        {
            Instantiate(coinPrefab, coinSpawnPosition[3], Quaternion.identity);
            
            Instantiate(coinPrefab, coinSpawnPosition[4], Quaternion.identity);
        }
        else if(randomPosition == 1 || randomPosition == 2)
        {
            Instantiate(coinPrefab, coinSpawnPosition[0], quaternion.identity);
            
            Instantiate(coinPrefab, coinSpawnPosition[1], quaternion.identity);
            
            Instantiate(coinPrefab, coinSpawnPosition[2], quaternion.identity);
        }
    }

    private IEnumerator EnemySpawnCO()
    {
        EnemySpawn();
        yield return new WaitForSeconds(enemySpawnDelay);
        StartCoroutine(EnemySpawnCO());
    }

    private void EnemySpawn()
    {
        int randomPosition = Random.Range(0, 2);

        if (randomPosition == 0)
        {
            int randomEnemy1 = Random.Range(0, enemyPrefabs.Length - 1);
            Instantiate(enemyPrefabs[randomEnemy1], enemyPosSpawn[3], Quaternion.identity);

            int randomEnemy2 = Random.Range(0, enemyPrefabs.Length - 1);
            Instantiate(enemyPrefabs[randomEnemy2], enemyPosSpawn[4], Quaternion.identity);
        }
        else if(randomPosition == 1 || randomPosition == 2)
        {
            int randomEnemy1 = Random.Range(0, enemyPrefabs.Length - 1);
            Instantiate(enemyPrefabs[randomEnemy1], enemyPosSpawn[0], quaternion.identity);
            
            int randomEnemy2 = Random.Range(0, enemyPrefabs.Length - 1);
            Instantiate(enemyPrefabs[randomEnemy2], enemyPosSpawn[1], quaternion.identity);
            
            int randomEnemy3 = Random.Range(0, enemyPrefabs.Length - 1);
            Instantiate(enemyPrefabs[randomEnemy3], enemyPosSpawn[2], quaternion.identity);
        }
    }
}
