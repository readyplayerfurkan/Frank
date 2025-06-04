using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public EntitySO playerSO;

    private void Start()
    {
        Debug.Log($"Player health at the start = {playerSO.currentHealth}");
    }
}
