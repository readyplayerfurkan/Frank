using UnityEngine;
using Management.ObjectPool;
using System.Collections;
using UnityEditor.Build.Content;

public class EnemySpawnah : ObjectPooling<GameObject>
{
    [SerializeField] private float EnemySpawnInterval;
    [SerializeField] private float EnemySpawnPointX;
    [SerializeField] private float EnemySpawnPointY;
    [SerializeField] private EnemySO archerEnemy;

    
    private GameObject player;

    private void Start()
    {
        Debug.Log(archerEnemy.range);
        ObjectPool();
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(SpawnEnemyCoroutine());
    }

    private IEnumerator SpawnEnemyCoroutine()
    {
        while (true)
        {
            itemInstantiate = GetItem();
            AdjustEnemyPosition(itemInstantiate);
            yield return new WaitForSeconds(EnemySpawnInterval);        
        }
    }
    
    // Oyuncunun görüş alanı dışında kalan alanda düşmanların spawn olacağı noktalar burada belirleniyor.
    private void AdjustEnemyPosition(GameObject enemy)
    {
        int selectedArea = Random.Range(0, 4);
        
        float spawnPointXPositive = player.transform.position.x + EnemySpawnPointX;
        float spawnPointXNegative = player.transform.position.x - EnemySpawnPointX;
        
        float spawnPointYPositive = player.transform.position.y + EnemySpawnPointY;
        float spawnPointYNegative = player.transform.position.y - EnemySpawnPointY;

        float randomPointX = Random.Range(spawnPointXNegative, spawnPointXPositive);
        float randomPointY = Random.Range(spawnPointYNegative, spawnPointYPositive);
        
        switch (selectedArea)
        {
            case 0:
                enemy.transform.position = new Vector3(spawnPointXPositive, randomPointY, 0);
                break;
            case 1:
                enemy.transform.position = new Vector3(randomPointX, spawnPointYNegative, 0);
                break;
            case 2:
                enemy.transform.position = new Vector3(spawnPointXNegative, randomPointY, 0);
                break;
            case 3:
                enemy.transform.position = new Vector3(randomPointX, spawnPointYPositive, 0);
                break;
        }
    }
}

