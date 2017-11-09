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

	bool isRotation = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.W))
		{
			RotateWhite();
		}

		if (Input.GetKeyDown(KeyCode.Y))
		{
			RotateYellow();
		}

		if (Input.GetKeyDown(KeyCode.O))
		{
			RotateOrange();
		}

		if (Input.GetKeyDown(KeyCode.R))
		{
			RotateRed();
		}

		if (Input.GetKeyDown(KeyCode.G))
		{
			RotateGreen();
		}

		if (Input.GetKeyDown(KeyCode.B))
		{
			RotateBlue();
		}
	}

	void RotateWhite()
	{
		if (isRotation == false)
		{
			isRotation = true;
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
	}

	void RotateYellow()
	{
		if (isRotation == false)
		{
			isRotation = true;
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
	}

	void RotateOrange()
	{
		if (isRotation == false)
		{
			isRotation = true;
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
	}

	void RotateRed()
	{
		if (isRotation == false)
		{
			isRotation = true;
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
	}

	void RotateGreen()
	{
		if (isRotation == false)
		{
			isRotation = true;
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
	}

	void RotateBlue()
	{
		if (isRotation == false)
		{
			isRotation = true;
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
			center.transform.DOLocalRotate(new Vector3 (0, 90, 0), 0.6f, RotateMode.LocalAxisAdd).OnComplete(MyCallback);
		}
		
		if (center == centerYellow || center == centerGreen)
		{
			center.transform.DOLocalRotate(new Vector3 (0, 0, 90), 0.6f, RotateMode.LocalAxisAdd).OnComplete(MyCallback);
		}

		if (center == centerOrange || center == centerRed)
		{
			center.transform.DOLocalRotate(new Vector3 (90, 0, 0), 0.6f, RotateMode.LocalAxisAdd).OnComplete(MyCallback);
		}
	}

	void MyCallback()
	{
		isRotation = false;
	}
}
