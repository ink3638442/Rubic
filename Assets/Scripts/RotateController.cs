using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateController : MonoBehaviour
{
	private GameObject centerWhite;
	private GameObject centerYellow;
	private GameObject centerOrange;
	private GameObject centerRed;
	private GameObject centerGreen;
	private GameObject centerBlue;

    // Use this for initialization
    void Start()
    {
		// 4_Cube_Prefab  ホワイト中心
		// 10_Cube_Prefab イエロー中心
		// 12_Cube_Prefab オレンジ中心
		// 14_Cube_Prefab レッド中心
		// 16_Cube_Prefab グリーン中心
		// 22_Cube_Prefab ブルー中心
		this.centerWhite  = GameObject.Find("4_Cube_Prefab");
		this.centerYellow = GameObject.Find("10_Cube_Prefab");
		this.centerOrange = GameObject.Find("12_Cube_Prefab");
		this.centerRed    = GameObject.Find("14_Cube_Prefab");
		this.centerGreen  = GameObject.Find("16_Cube_Prefab");
		this.centerBlue   = GameObject.Find("22_Cube_Prefab");
    }

    // Update is called once per frame
    void Update()
    {
		if (DOTween.PlayingTweens() == null)
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				Collider[] colliders = Physics.OverlapBox(this.centerWhite.transform.position, new Vector3(0.2f, 0.05f, 0.2f));

				foreach (Collider cube in colliders)
				{
					// Debug.Log(cube.gameObject.name);
					cube.gameObject.transform.parent = this.centerWhite.transform;
				}

				Rotate(this.centerWhite);
			}

			if (Input.GetKeyDown(KeyCode.Alpha2))
			{
				Collider[] colliders = Physics.OverlapBox(this.centerYellow.transform.position, new Vector3(0.2f, 0.2f, 0.05f));

				foreach (Collider cube in colliders)
				{
					// Debug.Log(cube.gameObject.name);
					cube.gameObject.transform.parent = this.centerYellow.transform;
				}

				Rotate(this.centerYellow);
			}

			if (Input.GetKeyDown(KeyCode.Alpha3))
			{
				Collider[] colliders = Physics.OverlapBox(this.centerOrange.transform.position, new Vector3(0.05f, 0.2f, 0.2f));

				foreach (Collider cube in colliders)
				{
					// Debug.Log(cube.gameObject.name);
					cube.gameObject.transform.parent = this.centerOrange.transform;
				}

				Rotate(this.centerOrange);
			}

			if (Input.GetKeyDown(KeyCode.Alpha4))
			{
				Collider[] colliders = Physics.OverlapBox(this.centerRed.transform.position, new Vector3(0.05f, 0.2f, 0.2f));

				foreach (Collider cube in colliders)
				{
					// Debug.Log(cube.gameObject.name);
					cube.gameObject.transform.parent = this.centerRed.transform;
				}

				Rotate(this.centerRed);
			}

			if (Input.GetKeyDown(KeyCode.Alpha5))
			{
				Collider[] colliders = Physics.OverlapBox(this.centerGreen.transform.position, new Vector3(0.2f, 0.2f, 0.05f));

				foreach (Collider cube in colliders)
				{
					// Debug.Log(cube.gameObject.name);
					cube.gameObject.transform.parent = this.centerGreen.transform;
				}

				Rotate(this.centerGreen);
			}

			if (Input.GetKeyDown(KeyCode.Alpha6))
			{
				Collider[] colliders = Physics.OverlapBox(this.centerBlue.transform.position, new Vector3(0.2f, 0.05f, 0.2f));

				foreach (Collider cube in colliders)
				{
					// Debug.Log(cube.gameObject.name);
					cube.gameObject.transform.parent = this.centerBlue.transform;
				}

				Rotate(this.centerBlue);
			}
		}
    }

	void Rotate(GameObject center)
	{
		if (center == this.centerWhite || center == this.centerBlue)
		{
			center.transform.DORotate(new Vector3 (0, 90, 0), 0.6f, RotateMode.LocalAxisAdd);
		}
		
		
		if (center == this.centerYellow || center == this.centerGreen)
		{
			center.transform.DORotate(new Vector3 (0, 0, 90), 0.6f, RotateMode.LocalAxisAdd);
		}

		if (center == this.centerOrange || center == this.centerRed)
		{
			center.transform.DORotate(new Vector3 (90, 0, 0), 0.6f, RotateMode.LocalAxisAdd);
		}
	}
}
