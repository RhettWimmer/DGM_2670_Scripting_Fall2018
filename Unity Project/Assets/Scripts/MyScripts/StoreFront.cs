using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StoreFront : ScriptableObject
{

	public Object Item;
	public int ItemValue;
	public IntData Cash;
	public List<Object> Purchased;
	public IntData EmployeeMove;
	
	public void Purchase()
	{
		if (Cash.Value >= ItemValue)
		{
			Purchased.Add(Item);
			Cash.Value -= ItemValue;
		}
	}

	public void AddObject()
	{
		if (Purchased.Count > 0)
		{
			Instantiate(Purchased[0]);
			EmployeeMove.Value += 1;
/*			Cash.Value -= 1;*/
			Purchased.RemoveAt(0);
		}
	}
}
