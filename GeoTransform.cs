using UnityEngine;

public class GeoTransform : MonoBehaviour // This must be exactly like this
{
    public float moveSpeed = 5f;
    public float rotateSpeed = 50f;
    public float scaleSpeed = 0.5f;

    void Update()
    {
        // Movement (WASD keys)
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(moveX, 0, moveZ);

        // Rotation (Arrow keys)
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -rotateSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);

        // Scaling (Q to increase, E to decrease)
        if (Input.GetKey(KeyCode.Q))
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.E))
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
    }
}

