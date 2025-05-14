using UnityEngine;

public class CameraMovement  : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;

    private void Update()
    {
         transform.position = playerTransform.position + offset;
    }
}
