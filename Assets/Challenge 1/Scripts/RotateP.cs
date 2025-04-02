using UnityEngine;

public class RotateP : MonoBehaviour
{
    public float rotationSpeed;

    private void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.fixedDeltaTime);
    }
}
