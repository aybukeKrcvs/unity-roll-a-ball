// FloatingMovement.cs
using UnityEngine;

public class FloatingMovement : MonoBehaviour
{
    public float spped = 3f;
    public float height = 0.4f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * spped) * height;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
