using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed; // 4 default

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if(Input.GetKey(KeyCode.W))
            transform.Translate(Vector2.up * (Time.deltaTime * speed));
        
        if(Input.GetKey(KeyCode.S))
            transform.Translate(Vector2.down * (Time.deltaTime * speed));

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector2.left * (Time.deltaTime * speed));
        
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector2.right * (Time.deltaTime * speed));
    }
}
