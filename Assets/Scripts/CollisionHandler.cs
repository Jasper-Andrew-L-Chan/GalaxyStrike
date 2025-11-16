using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Collision detected with " + other.gameObject.name);
        }
}
