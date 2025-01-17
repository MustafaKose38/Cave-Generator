using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation;

    public float xSensivity = 30f;
    public float ySensivity = 30f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        // Yukar� - A�a�� kamera hareketi
        xRotation -= (mouseY * Time.deltaTime) * ySensivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //Kameraya bu hareketi iletme
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //Player� sa�a-sola d�nd�r
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensivity); 
    }
}
