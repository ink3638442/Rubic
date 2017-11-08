using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text; 

public class RubicController : MonoBehaviour
{
	[SerializeField]
	GameObject centerCore;
	[SerializeField]
	GameObject centerWhite;
	[SerializeField]
	GameObject centerYellow;
	[SerializeField]
	GameObject centerOrange;
	[SerializeField]
	GameObject centerRed;
	[SerializeField]
	GameObject centerGreen;
	[SerializeField]
	GameObject centerBlue;

	[SerializeField]
	List<GameObject> cubes = new List<GameObject>();

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.W))
		{
			foreach (GameObject cube in cubes)
			{
				cube.gameObject.transform.parent = transform;

				if (cube.transform.localPosition.y - centerCore.transform.localPosition.y > 0.2f)
				{
					cube.gameObject.transform.parent = this.centerWhite.transform;
				}
			}
		}

		if (Input.GetKeyDown(KeyCode.Y))
		{
			foreach (GameObject cube in cubes)
			{
				cube.gameObject.transform.parent = transform;

				if (cube.transform.localPosition.z - centerCore.transform.localPosition.z > 0.2f)
				{
					cube.gameObject.transform.parent = this.centerYellow.transform;
				}
			}
		}

		if (Input.GetKeyDown(KeyCode.O))
		{
			foreach (GameObject cube in cubes)
			{
				cube.gameObject.transform.parent = transform;

				if (cube.transform.localPosition.x - centerCore.transform.localPosition.x < -0.2f)
				{
					cube.gameObject.transform.parent = this.centerOrange.transform;
				}
			}
		}

		if (Input.GetKeyDown(KeyCode.R))
		{
			foreach (GameObject cube in cubes)
			{
				cube.gameObject.transform.parent = transform;

				if (cube.transform.localPosition.x - centerCore.transform.localPosition.x > 0.2f)
				{
					cube.gameObject.transform.parent = this.centerRed.transform;
				}
			}
		}

		if (Input.GetKeyDown(KeyCode.G))
		{
			foreach (GameObject cube in cubes)
			{
				cube.gameObject.transform.parent = transform;

				if (cube.transform.localPosition.z - centerCore.transform.localPosition.z < -0.2f)
				{
					cube.gameObject.transform.parent = this.centerGreen.transform;
				}
			}
		}

		if (Input.GetKeyDown(KeyCode.B))
		{
			foreach (GameObject cube in cubes)
			{
				cube.gameObject.transform.parent = transform;

				if (cube.transform.localPosition.y - centerCore.transform.localPosition.y < -0.2f)
				{
					cube.gameObject.transform.parent = this.centerBlue.transform;
				}
			}
		}
    }
}
