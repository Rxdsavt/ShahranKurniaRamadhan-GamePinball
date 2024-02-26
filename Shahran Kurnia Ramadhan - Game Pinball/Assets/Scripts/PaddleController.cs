using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public KeyCode key;
    private HingeJoint hinge;
    // public float springPower;
    private float tPressed;
    private float tReleased;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();

        tPressed = hinge.limits.max;
        tReleased = hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        ListenInput();

    }

    private void ListenInput()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(key))
        {
            jointSpring.targetPosition = tPressed;
        }
        else
        {
            jointSpring.targetPosition = tReleased;
        }

        hinge.spring = jointSpring;

    }

}
