using UnityEngine;

[CreateAssetMenu(fileName = "EnemySO", menuName = "Scriptable Objects/Enemy/EnemySO")]
public class EnemySO : ScriptableObject
{
    public float health;
    public float speed;
    public float damage;
    public float range;
}
