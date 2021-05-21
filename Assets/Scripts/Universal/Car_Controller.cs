using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Car_Controller : MonoBehaviour
{
    private float Brakes;
    private float horizontalInput;
    private float verticalInput;
    private float steerAngle = 0;
    private float currentSpeed;
    private float topSpeed = 90f;
    private float pitch = 0;

    public WheelCollider frontDriverW, frontPassW;
    public WheelCollider rearDriverW, rearPassW;
    public Transform frontDriverT, frontPassT;
    public Transform rearDriverT, rearPassT;
    public float maxSteerAngle = 45f; 
    public float motorForce = 80f;
    //public AudioSource audioSource;


    // Grabbing the all input values based on the Axis
    public void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal"); 
        verticalInput = Input.GetAxis("Vertical");
    }

    // 
    private void Steer() 
    {
        steerAngle = maxSteerAngle * horizontalInput;
        frontDriverW.steerAngle = steerAngle;
        frontPassW.steerAngle = steerAngle;
    }

    // Basic acceleration script 
    private void Accelerate()
    {
        frontDriverW.motorTorque = verticalInput * motorForce * 3000;
        frontPassW.motorTorque = verticalInput * motorForce * 3000;
    }

    // Calls UpdateWheelPose for all wheels and colliders 
    private void UpdateWheel()
    {
        UpdateWheelPose(frontDriverW, frontDriverT);
        UpdateWheelPose(frontPassW, frontPassT);
        UpdateWheelPose(rearDriverW, rearDriverT);
        UpdateWheelPose(rearPassW, rearPassT);
    }

    // Creating animation for wheel and colliders with it
    private void UpdateWheelPose(WheelCollider w_collider, Transform t_transform)
    {
        Vector3 pos = t_transform.position;
        Quaternion quat = t_transform.rotation;
        w_collider.GetWorldPose(out pos, out quat); // ensuring to account for ground contact, suspension limits, steer angle, and rotation angle 
        t_transform.position = pos;
        t_transform.rotation = quat;
    }

    // Whenever input for Brake is applied, sets brakeTorque for wheels to 90000.
    private void Brake()
    {
        Brakes = 0;
        if(Input.GetKey(KeyCode.Space) == true)
        {
            Brakes = 70000;
        }
        frontDriverW.brakeTorque = Brakes;
        frontPassW.brakeTorque = Brakes;
        rearDriverW.brakeTorque = Brakes;
        rearPassW.brakeTorque = Brakes;
    }


    private void Update()
    {
        currentSpeed = transform.GetComponent<Rigidbody>().velocity.magnitude * 3.6f;
        pitch = currentSpeed / topSpeed;
        transform.GetComponent<AudioSource>().pitch = pitch;
    }

    // Calling all car functions
    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        UpdateWheel();
        Brake();
    }



}