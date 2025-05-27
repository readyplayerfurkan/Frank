using UnityEngine;

[CreateAssetMenu(fileName = "EntitySO", menuName = "Scriptable Objects/EntitySO")]
public class EntitySO : ScriptableObject
{
    public float currentHealth;
    public float maxHealth;
    public float damage;
    public float currentSpeed;
    public float maxSpeed;
}
