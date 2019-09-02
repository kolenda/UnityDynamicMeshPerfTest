using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationModel
{
	static int objectsNum = 1;
	public static int ObjectsNum
	{
		get { return objectsNum; }
		set { objectsNum = value; }
	}

	static int triangleNum = 10;
	public static int TriangleNum
	{
		get { return triangleNum; }
		set { triangleNum = value; }
	}

	static bool updateGeometryData = false;
	public static bool UpdateGeometryData
	{
		get { return updateGeometryData; }
		set { updateGeometryData = value; }
	}
}
