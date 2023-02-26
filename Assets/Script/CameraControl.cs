using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float rotateSpeed = 30.0f;
    public float speed = 30.0f;
    public float zoomSpeed = 30.0f;

    private void Update()
    {
        // Cam move vector x (horizontal)
        float vectorX = Input.GetAxis("Horizontal");

        // Cam move vector y (vertical)
        float vectorY = Input.GetAxis("Vertical");

        // Cam rotation by QE
        float rotate = 0f;
        if (Input.GetKey(KeyCode.Q))
            rotate = -1f;
        else
            if (Input.GetKey(KeyCode.E))
            rotate = 1f;

        // Cam rotation
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * rotate, Space.World);

        // Cam move
        transform.Translate(new Vector3(vectorX, 0, vectorY) * Time.deltaTime * speed, Space.Self);

        // Cam zoom
        transform.position += transform.up * zoomSpeed * Time.deltaTime * Input.GetAxis("Mouse ScrollWheel");

        // Zoom limiter
        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(transform.position.y, -9f, 10f),
            transform.position.z);
    }
}
