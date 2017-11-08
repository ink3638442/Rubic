using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
					cube.gameObject.transform.parent = centerWhite.transform;
				}
			}
			Rotate(centerWhite);
		}

		if (Input.GetKeyDown(KeyCode.Y))
		{
			foreach (GameObject cube in cubes)
			{
				cube.gameObject.transform.parent = transform;

				if (cube.transform.localPosition.z - centerCore.transform.localPosition.z > 0.2f)
				{
					cube.gameObject.transform.parent = centerYellow.transform;
				}
			}
			Rotate(centerYellow);
		}

		if (Input.GetKeyDown(KeyCode.O))
		{
			foreach (GameObject cube in cubes)
			{
				cube.gameObject.transform.parent = transform;

				if (cube.transform.localPosition.x - centerCore.transform.localPosition.x < -0.2f)
				{
					cube.gameObject.transform.parent = centerOrange.transform;
				}
			}
			Rotate(centerOrange);
		}

		if (Input.GetKeyDown(KeyCode.R))
		{
			foreach (GameObject cube in cubes)
			{
				cube.gameObject.transform.parent = transform;

				if (cube.transform.localPosition.x - centerCore.transform.localPosition.x > 0.2f)
				{
					cube.gameObject.transform.parent = centerRed.transform;
				}
			}
			Rotate(centerRed);
		}

		if (Input.GetKeyDown(KeyCode.G))
		{
			foreach (GameObject cube in cubes)
			{
				cube.gameObject.transform.parent = transform;

				if (cube.transform.localPosition.z - centerCore.transform.localPosition.z < -0.2f)
				{
					cube.gameObject.transform.parent = centerGreen.transform;
				}
			}
			Rotate(centerGreen);
		}

		if (Input.GetKeyDown(KeyCode.B))
		{
			foreach (GameObject cube in cubes)
			{
				cube.gameObject.transform.parent = transform;

				if (cube.transform.localPosition.y - centerCore.transform.localPosition.y < -0.2f)
				{
					cube.gameObject.transform.parent = centerBlue.transform;
				}
			}
			Rotate(centerBlue);
		}
    }

	void Rotate(GameObject center)
	{
		if (center == centerWhite || center == centerBlue)
		{
			center.transform.DOLocalRotate(new Vector3 (0, 90, 0), 0.6f, RotateMode.LocalAxisAdd);
		}
		
		if (center == centerYellow || center == centerGreen)
		{
			center.transform.DOLocalRotate(new Vector3 (0, 0, 90), 0.6f, RotateMode.LocalAxisAdd);
		}

		if (center == centerOrange || center == centerRed)
		{
			center.transform.DOLocalRotate(new Vector3 (90, 0, 0), 0.6f, RotateMode.LocalAxisAdd);
		}
	}
}
