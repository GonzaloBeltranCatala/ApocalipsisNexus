using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Raton : MonoBehaviour
{

    private Vector2 aimSensitivity = new Vector2(30, 30);

    private Vector2 aimInput;

    private float xAngle;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, aimInput.x * aimSensitivity.x * Time.deltaTime, 0);

        transform.GetChild(0).Rotate(-aimInput.y * aimSensitivity * Time.deltaTime, 0, 0);

        transform.GetChild(0).localRotation = Quaternion.Euler(xAngle, 0, 0);

        xAngle = Mathf.Clamp(xAngle - aimInput.y * aimSensitivity.y * Time.deltaTime, -15, 15);



    }
    private void OnAim(InputValue value)
    {
        aimInput = value.Get<Vector2>();
    }
}
