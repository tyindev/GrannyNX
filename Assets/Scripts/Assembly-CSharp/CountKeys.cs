using System;
using UnityEngine;

[Serializable]
public class CountKeys : MonoBehaviour
{
	public int keys;

	public GameObject keyCounterParent;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		// wat5re
	}

	public virtual void countUpkeys()
	{
		keys++;
	}

	public virtual void countDownkeys()
	{
		keys--;
	}
}
