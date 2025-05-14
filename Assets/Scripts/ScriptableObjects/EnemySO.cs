using UnityEngine;

[CreateAssetMenu(fileName = "Düşman Verisi", menuName = "Scriptable Verilerim/Düşmanın Verisi")]
public class EnemySO : ScriptableObject
{
    public float health;
    public float maxHealth;
    public float speed;
    public float damage;
    public float range;
    public EnemyType enemyType;
}

public enum EnemyType
{
    tank,
    wizard,
    archer
}
