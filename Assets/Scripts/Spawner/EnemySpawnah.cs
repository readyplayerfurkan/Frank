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
        // Random.Range(1,4) -> Bu bir b�lge verecek.

            // 1. B�lge x -> 17 y -> 6 ila -6 aras� (Ekran�n En Sa� K�sm�) Vector3(17, Random.Range(-6,6), 0)
            // 2. B�lge x -> -17 ila 17 aras� y -> -6 (Ekran�n Alt K�sm�)
            // 3. B�lge x -> -17 y -> 6 ila -6 aras� (Ekran�n En Sol K�sm�)
            // 4. B�lge x -> -17 ila 17 aras� y -> 6 (Ekran�n En �st K�sm�)
    }
}

