using UnityEngine;
using Management.ObjectPool;
using System.Collections;
using UnityEditor.Build.Content;

public class EnemySpawnah : ObjectPooling<GameObject>
{
    [SerializeField] private float EnemySpawnInterval;
    [SerializeField] private float EnemySpawnPointX;
    [SerializeField] private float EnemySpawnPointY;
    private GameObject player;

    private void Start()
    {
        ObjectPool();
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(SpawnEnemyCoroutine());
    }

    private IEnumerator SpawnEnemyCoroutine()
    {
        while (true)
        {
            GetItem();
            yield return new WaitForSeconds(EnemySpawnInterval);        
        }
    }
    
    private void EnemyTeleporter(GameObject enemy)
    {       
        // Random.Range(1,4) -> Bu bir bölge verecek.

            // 1. Bölge x -> 17 y -> 6 ila -6 arasý (Ekranýn En Sað Kýsmý) Vector3(17, Random.Range(-6,6), 0)
            // 2. Bölge x -> -17 ila 17 arasý y -> -6 (Ekranýn Alt Kýsmý)
            // 3. Bölge x -> -17 y -> 6 ila -6 arasý (Ekranýn En Sol Kýsmý)
            // 4. Bölge x -> -17 ila 17 arasý y -> 6 (Ekranýn En Üst Kýsmý)
    }
}

