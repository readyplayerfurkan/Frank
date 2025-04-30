using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public float speed;
    void Update()
    {
        gameObject.transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
    }

    private void OnEnable()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
