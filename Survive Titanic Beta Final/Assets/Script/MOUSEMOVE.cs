using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOUSEMOVE : MonoBehaviour
{
    public float rotationspeed=500f;
    // Start is called before the first frame update
    public Transform playerhead;
    float xRot=0f;
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX=Input.GetAxis("Mouse X")*rotationspeed* Time.deltaTime;
        float mouseY=Input.GetAxis("Mouse Y")*rotationspeed* Time.deltaTime;
        playerhead.Rotate(Vector3.up*mouseX);
        playerhead.Rotate(Vector3.up*mouseY);
        xRot-=mouseY;
        xRot=Mathf.Clamp(xRot,-150f,45f);
        transform.localRotation= Quaternion.Euler(xRot,0f,0f);
    }
}
