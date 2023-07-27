using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float turnSpeed = 90f;
    [SerializeField] float headUpperAngle = 85f;
    [SerializeField] float headLowerAngle = -75f;
    float yaw = 0f;
    float pitch = 0f;
    Quaternion bodyStartOrientation;
    Quaternion headStartOrientation;
    Transform head;

    // Start is called before the first frame update
    void Start()
    {
        head = GetComponentInChildren<Camera>().transform;
        bodyStartOrientation = transform.localRotation;
        headStartOrientation = head.transform.localRotation;
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false;

    }

    void Update()
    {
        var horizontal = Input.GetAxis("Mouse X") * Time.deltaTime * turnSpeed;
        var vertical = Input.GetAxis("Mouse Y") * Time.deltaTime * turnSpeed;

        yaw += horizontal;
        pitch += vertical;

        pitch = Mathf.Clamp(pitch, headLowerAngle, headUpperAngle);
        var bodyRotation = Quaternion.AngleAxis(yaw, Vector3.up);
        var headRotation = Quaternion.AngleAxis(pitch, Vector3.right);
        transform.localRotation = bodyRotation * bodyStartOrientation;
        head.localRotation = bodyRotation * headStartOrientation;

    }
}
