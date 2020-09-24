using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public WheelCollider wheelColliderFrontLeft;
    public WheelCollider wheelColliderFrontRight;
    public WheelCollider wheelColliderRearLeft;
    public WheelCollider wheelColliderRearRight;

    public Transform wheelFrontLeft;
    public Transform wheelFrontRight;
    public Transform wheelRearLeft;
    public Transform wheelRearRight;

    public float motorTorque = 100f;
    public float maxSteer = 20f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        wheelColliderRearLeft.motorTorque = Input.GetAxis("Vertical") * motorTorque;
        wheelColliderRearRight.motorTorque = Input.GetAxis("Vertical") * motorTorque;

        wheelColliderFrontLeft.steerAngle = Input.GetAxis("Horizontal") * maxSteer;
        wheelColliderFrontRight.steerAngle = Input.GetAxis("Horizontal") * maxSteer;
    }

    void Update()
    {
        var position = Vector3.zero;
        var rotation = Quaternion.identity;

        wheelColliderFrontLeft.GetWorldPose(out position, out rotation);
        wheelFrontLeft.position = position;
        wheelFrontLeft.rotation = rotation;

        wheelColliderFrontRight.GetWorldPose(out position, out rotation);
        wheelFrontRight.position = position;
        wheelFrontRight.rotation = rotation;

        wheelColliderRearLeft.GetWorldPose(out position, out rotation);
        wheelRearLeft.position = position;
        wheelRearLeft.rotation = rotation;

        wheelColliderRearRight.GetWorldPose(out position, out rotation);
        wheelRearRight.position = position;
        wheelRearRight.rotation = rotation;
    }
}
