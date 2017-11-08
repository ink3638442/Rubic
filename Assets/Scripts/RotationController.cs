using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
	[SerializeField]
	int xVec;
	[SerializeField]
	int yVec;
	[SerializeField]
	int zVec;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		transform.Rotate(xVec * Time.deltaTime, yVec * Time.deltaTime, zVec * Time.deltaTime);
    }
}
