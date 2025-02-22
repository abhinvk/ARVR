using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed;
    public float rotationSpeed;

    void Start()
    {
        moveSpeed = 15f;
        rotationSpeed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 move = (Vector3.right * moveX + Vector3.forward * moveY) * moveSpeed * Time.deltaTime;
        transform.Translate(move);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.right, -mouseY * rotationSpeed * Time.deltaTime, Space.World);
    }
}