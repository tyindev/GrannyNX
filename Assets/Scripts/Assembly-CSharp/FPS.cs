using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class FPS : MonoBehaviour
{
	public float updateInterval;

	private float accum;

	private int frames;

	private float timeleft;

	public FPS()
	{
	}

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
	}
}
