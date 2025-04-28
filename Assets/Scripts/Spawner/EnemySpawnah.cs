using UnityEngine;
using Management.ObjectPool;
using System.Collections;

public class EnemySpawnah : ObjectPooling<GameObject>
{
    [SerializeField] private float EnemySpawnInterval;

    private void Start()
    {
        ObjectPool();
        StartCoroutine(SpawnEnemyCoroutine());
    }

    private IEnumerator SpawnEnemyCoroutine()
    {
        while (true)
        {
            GetItem();
            Debug.Log("Bir item çaðýrýldý");
            yield return new WaitForSeconds(EnemySpawnInterval);
            Debug.Log("Süre bitti");
        }
    }
}
