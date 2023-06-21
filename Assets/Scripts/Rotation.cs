using UnityEngine;

public class Rotation : MonoBehaviour
{
    private void FixedUpdate()
    {
        gameObject.transform.Rotate(0, 1, 0);
    }
}
