using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneParam : MonoBehaviour
{
	public void setObjectNum( int num )
	{
		ApplicationModel.ObjectsNum = num;
		Debug.Log( "ChangeSceneParam.setObjectNum: " + num );
	}
	public void setTriangleNum( int num )
	{
		ApplicationModel.TriangleNum = num;
		Debug.Log( "ChangeSceneParam.setTriangleNum: " + num );
	}
}
