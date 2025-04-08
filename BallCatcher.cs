using UnityEngine;

public class BallCatcher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("мяч упал: " + other.name);
    }
}
