using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelCollider backLeft;
    public WheelCollider backRight;
    public WheelCollider frontLeft;
    public WheelCollider frontRight;

    public Transform backLeftTransform;
    public Transform backRightTransform;
    public Transform frontLeftTransform;
    public Transform frontRightTransform;
    
    public float maxSpeed;
    public float turnSens = 0.5f;
    public float maxTurnAngle = 45.0f;
    public float ivme = 200.0f;

    private float inputX, inputY;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetInputs();
        Move();
        Turn();
    }

    private void GetInputs()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        backLeft.motorTorque = maxSpeed * inputY * ivme * Time.deltaTime;
        backRight.motorTorque = maxSpeed * inputY * ivme * Time.deltaTime;
        frontLeft.motorTorque = maxSpeed * inputY* ivme * Time.deltaTime;
        frontRight.motorTorque = maxSpeed * inputY* ivme * Time.deltaTime;

        backLeftTransform.Rotate(inputY, 0, 0);
        backRightTransform.Rotate(inputY, 0, 0);
        frontLeftTransform.Rotate(inputY, 0, 0);
        frontRightTransform.Rotate(inputY, 0, 0);
    }

    private void Turn()
    {
        var turnAngle = inputX * turnSens * maxTurnAngle;
        frontLeft.steerAngle = turnAngle;
        frontRight.steerAngle = turnAngle;
    }
}
