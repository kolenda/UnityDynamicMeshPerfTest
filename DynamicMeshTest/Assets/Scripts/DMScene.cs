using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMScene : MonoBehaviour
{
	public int objectsNum = ApplicationModel.ObjectsNum;
	public int trianglesNum = ApplicationModel.TriangleNum;

	public GameObject	objectPrefab;

    // Start is called before the first frame update
    void Start()
    {
		objectsNum = ApplicationModel.ObjectsNum;
		trianglesNum = ApplicationModel.TriangleNum;

		Debug.LogWarning( "DMScene::Start(): objectsNum: " + objectsNum + ", trianglesNum: " + trianglesNum );

		int lineSize = (int) Mathf.Sqrt( objectsNum );
		float scale = 5.0f / lineSize;
		Vector3 center = new Vector3( lineSize / 2, lineSize / 2, 0.0f ) * scale;
		for( int i = 0; i < objectsNum; i++ ) {
			Vector3 pos = new Vector3( i % lineSize, i / lineSize, 0.0f ) * scale;
			GameObject go = Instantiate( objectPrefab, pos - center, Quaternion.identity );
			go.transform.localScale /= (Mathf.Sqrt( objectsNum ) / 3.0f);
		}
    }
}
