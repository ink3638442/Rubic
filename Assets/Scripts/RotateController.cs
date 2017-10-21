using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Alpha1) && gameObject.name == "4_Cube_Prefab")
		{
			Collider[] colliders = Physics.OverlapBox(transform.position, new Vector3(0.2f, 0.05f, 0.2f));

			foreach (Collider cube in colliders)
			{
				// Debug.Log(cube.gameObject.name);
				cube.gameObject.transform.parent = this.transform;
			}

			Rotate();
		}

		if (Input.GetKeyDown(KeyCode.Alpha2) && gameObject.name == "10_Cube_Prefab")
		{
			Collider[] colliders = Physics.OverlapBox(transform.position, new Vector3(0.2f, 0.2f, 0.05f));

			foreach (Collider cube in colliders)
			{
				// Debug.Log(cube.gameObject.name);
				cube.gameObject.transform.parent = this.transform;
			}

			Rotate();
		}

		if (Input.GetKeyDown(KeyCode.Alpha3) && gameObject.name == "12_Cube_Prefab")
		{
			Collider[] colliders = Physics.OverlapBox(transform.position, new Vector3(0.05f, 0.2f, 0.2f));

			foreach (Collider cube in colliders)
			{
				// Debug.Log(cube.gameObject.name);
				cube.gameObject.transform.parent = this.transform;
			}

			Rotate();
		}

		if (Input.GetKeyDown(KeyCode.Alpha4) && gameObject.name == "14_Cube_Prefab")
		{
			Collider[] colliders = Physics.OverlapBox(transform.position, new Vector3(0.05f, 0.2f, 0.2f));

			foreach (Collider cube in colliders)
			{
				// Debug.Log(cube.gameObject.name);
				cube.gameObject.transform.parent = this.transform;
			}

			Rotate();
		}

		if (Input.GetKeyDown(KeyCode.Alpha5) && gameObject.name == "16_Cube_Prefab")
		{
			Collider[] colliders = Physics.OverlapBox(transform.position, new Vector3(0.2f, 0.2f, 0.05f));

			foreach (Collider cube in colliders)
			{
				// Debug.Log(cube.gameObject.name);
				cube.gameObject.transform.parent = this.transform;
			}

			Rotate();
		}

		if (Input.GetKeyDown(KeyCode.Alpha6) && gameObject.name == "22_Cube_Prefab")
		{
			Collider[] colliders = Physics.OverlapBox(transform.position, new Vector3(0.2f, 0.05f, 0.2f));

			foreach (Collider cube in colliders)
			{
				// Debug.Log(cube.gameObject.name);
				cube.gameObject.transform.parent = this.transform;
			}

			Rotate();
		}
    }

	void Rotate()
	{
		// 4_Cube_Prefab  ホワイト中心
		// 10_Cube_Prefab イエロー中心
		// 12_Cube_Prefab オレンジ中心
		// 14_Cube_Prefab レッド中心
		// 16_Cube_Prefab グリーン中心
		// 22_Cube_Prefab ブルー中心
		if (this.gameObject.name == "4_Cube_Prefab" || this.gameObject.name == "22_Cube_Prefab")
		{		
			transform.Rotate(0, 90, 0);
		}
		
		if (this.gameObject.name == "10_Cube_Prefab" || this.gameObject.name == "16_Cube_Prefab")
		{
			transform.Rotate(0, 0, 90);
		}

		if (this.gameObject.name == "12_Cube_Prefab" || this.gameObject.name == "14_Cube_Prefab")
		{
			transform.Rotate(90, 0, 0);
		}
	}
}
