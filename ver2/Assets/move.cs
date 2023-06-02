using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 5f; // Speed at which the prefab moves
    public Vector3 direction = Vector3.forward; // Direction in which the prefab moves

    private void Update()
    {
        // Calculate the translation based on the speed and direction
        Vector3 translation = direction * speed * Time.deltaTime;

        // Apply the translation to the prefab's position
        transform.Translate(translation);
    }
}