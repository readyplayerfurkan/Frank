using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private EntitySO _playerSO;
    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if(Input.GetKey(KeyCode.W))
            transform.Translate(Vector2.up * (Time.deltaTime * _playerSO.maxSpeed));
        
        if(Input.GetKey(KeyCode.S))
            transform.Translate(Vector2.down * (Time.deltaTime * _playerSO.maxSpeed));

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector2.left * (Time.deltaTime * _playerSO.maxSpeed));
        
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector2.right * (Time.deltaTime * _playerSO.maxSpeed));
    }
}
