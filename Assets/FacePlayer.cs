using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    private Transform playerTransform;

    void Start()
    {
        // Find the player object in the scene
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            // Get the transform component of the player object
            playerTransform = player.transform;
        }
        else
        {
            Debug.LogError("Player object not found in the scene!");
        }
    }

    void Update()
    {
        if (playerTransform != null)
        {
            // Rotate the object to face the player
            transform.LookAt(playerTransform.position);
        }
    }
}
