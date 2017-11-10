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
