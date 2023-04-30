using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTask : FightTask
{
	public string question;
	public string[] answers;

	[SerializeField] int maxOutput;

	public FightTask GetTask()
	{


		return this;
	}
}
