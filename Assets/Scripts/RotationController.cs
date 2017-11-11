using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField]
    int xVecInit;
    [SerializeField]
    int yVecInit;
    [SerializeField]
    int zVecInit;

    float xVec;
    float yVec;
    float zVec;

    bool RotateSwitch = true;

    // Use this for initialization
    void Start()
    {
        xVec = xVecInit;
        yVec = yVecInit;
        zVec = zVecInit;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xVec * Time.deltaTime, yVec * Time.deltaTime, zVec * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
		{
            if (RotateSwitch == true)
            {
                RotateStop();
            }
            else
            {
                RotateStart();
            }
		}

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-xVec * Time.deltaTime, 0, -zVec * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-xVec * Time.deltaTime, -yVec * Time.deltaTime, -xVec * Time.deltaTime);
        }
    }

    void RotateStop()
    {
        RotateSwitch = false;
        xVec = yVec = zVec = 0;
    }

    void RotateStart()
    {
        RotateSwitch = true;
        xVec = xVecInit;
        yVec = yVecInit;
        zVec = zVecInit;
    }
}
