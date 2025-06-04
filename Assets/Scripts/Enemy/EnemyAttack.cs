using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EntitySO enemySO;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerHealthController>().playerSO.currentHealth -= enemySO.damage;
            Debug.Log($"Player health after collision with enemy = {other.gameObject.GetComponent<PlayerHealthController>().playerSO.currentHealth}");
        }
    }
}
