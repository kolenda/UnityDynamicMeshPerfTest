using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMScene : MonoBehaviour
{
	public int objectsNum = 1;
	public int trianglesNum = 1;

	public GameObject	objectPrefab;

    // Start is called before the first frame update
    void Start()
    {
		Debug.LogWarning( "DMScene::Start(): objectsNum: " + objectsNum + ", trianglesNum: " + trianglesNum );

		for( int i = 0; i < objectsNum; i++ ) {
			Vector3 pos = new Vector3( i % 5, i / 5, 0.0f );
			GameObject go = Instantiate( objectPrefab, pos, Quaternion.identity );

			DMObject dmObject = go.GetComponent<DMObject>();
			if( dmObject != null ) {
				dmObject.trianglesNum = trianglesNum;
			}
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
