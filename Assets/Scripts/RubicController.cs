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

	[SerializeField]
	List<int> reservationsOrder = new List<int>();

	[SerializeField]
	int initialRotationCount;

	float rotateSpeed = 0.6f;

	bool isRotation = false;

    // Use this for initialization
    void Start()
    {
		InitialRotate();
    }

    // Update is called once per frame
    void Update()
    {
		rotateSpeed = 0.6f;

		if (reservationsOrder.Count > 0)
		{
			rotateSpeed = 0.2f;

			switch (reservationsOrder[0])
			{
				case 0:
					RotateWhite();
					break;
				case 1:
					RotateYellow();
					break;
				case 2:
					RotateOrange();  
					break;
				case 3:
					RotateRed();  
					break;
				case 4:
					RotateGreen(); 
					break;
				case 5:
					RotateBlue();
					break;
			}
		}

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

		if (Input.GetKeyDown(KeyCode.S))
		{
			InitialRotate();
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
			center.transform.DOLocalRotate(new Vector3 (0, 90, 0), rotateSpeed, RotateMode.LocalAxisAdd).OnComplete(MyCallback);
		}
		
		if (center == centerYellow || center == centerGreen)
		{
			center.transform.DOLocalRotate(new Vector3 (0, 0, 90), rotateSpeed, RotateMode.LocalAxisAdd).OnComplete(MyCallback);
		}

		if (center == centerOrange || center == centerRed)
		{
			center.transform.DOLocalRotate(new Vector3 (90, 0, 0), rotateSpeed, RotateMode.LocalAxisAdd).OnComplete(MyCallback);
		}
	}

	void InitialRotate()
	{
		if (isRotation == false)
		{
			// 回転する面をランダムで決め、順番を配列に保管しておく
			for (int i = 0; i < initialRotationCount; i++)
			{
				reservationsOrder.Add(Random.Range(0, 6));
			}
		}
	}

	void MyCallback()
	{
		if (reservationsOrder.Count > 0)
		{
			reservationsOrder.RemoveAt(0);
		}

		isRotation = false;
	}
}