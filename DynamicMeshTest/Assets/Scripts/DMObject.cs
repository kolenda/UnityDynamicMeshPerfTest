using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMObject : MonoBehaviour
{
	public int trianglesNum = 3;
	public bool meshDoubleBuffering = false;

	Mesh mesh = null;
	List<Vector3>	verticesList = new List<Vector3>();

	// Start is called before the first frame update
	void Start()
    {
		Debug.LogWarning( "DMObject::Start(): trianglesNum: " + trianglesNum );

		if( mesh == null )
			mesh = GetComponent<MeshFilter>().mesh;

		Debug.LogWarning( "DMObject::Start(): mesh: " + mesh );

		for( int i = 0; i < trianglesNum; i++ ) {
			float angle = (float)i / trianglesNum;
			verticesList.Add( new Vector3( Mathf.Sin(angle), Mathf.Cos( angle ), 0.0f ) );
		}
	}

    // Update is called once per frame
    void Update()
    {
		mesh.Clear();
		mesh.SetVertices( verticesList );
//		mesh.Set
    }
}
