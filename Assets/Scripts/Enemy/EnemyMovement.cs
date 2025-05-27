using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private EntitySO _enemySO;
    
    void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, _enemySO.maxSpeed);
    }

    private void OnEnable()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
