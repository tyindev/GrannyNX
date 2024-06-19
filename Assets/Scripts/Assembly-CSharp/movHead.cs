using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class movHead : MonoBehaviour
{
	public Texture headR;

	public Texture headL;

	public Image head;

	private bool headMove;

	public virtual void Update()
	{
		if (headMove)
		{
			headMove = false;
		}
		else
		{
			headMove = true;
		}
	}

}
