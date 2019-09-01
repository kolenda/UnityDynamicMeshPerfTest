using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMObject : MonoBehaviour
{
	public int trianglesNum = ApplicationModel.TriangleNum;
	public bool meshDoubleBuffering = false;

	Mesh mesh = null;
	List<Vector3>   verticesList = new List<Vector3>();
	List<Vector3>   normalsList = new List<Vector3>();
	List<Color>		colorsList = new List<Color>();
	int[]			indicesList = new int[3];

	// Start is called before the first frame update
	void Start()
    {
		trianglesNum = ApplicationModel.TriangleNum;

		if( mesh == null )
			mesh = GetComponent<MeshFilter>().mesh;

		indicesList = new int[trianglesNum * 3];

		verticesList.Add( new Vector3( 0.0f, 0.0f, 0.0f ) );
		normalsList.Add( new Vector3( 0.0f, 0.0f, 1.0f ) );
		colorsList.Add( new Color( 1.0f, 1.0f, 1.0f, 1.0f ) );
		for( int i = 0; i < trianglesNum; i++ ) {
			float angle = (float)i / trianglesNum * 2.0f;
			verticesList.Add( new Vector3( Mathf.Sin(angle), Mathf.Cos( angle ), 0.0f ) );
			normalsList.Add( new Vector3( Mathf.Sin(angle), Mathf.Cos( angle ), -1.0f ).normalized );
			
			colorsList.Add( new Color(
				Mathf.Abs( Mathf.Sin( angle ) ),
				Mathf.Abs( Mathf.Cos( angle ) ),
				Mathf.Abs( Mathf.Sin( angle * 3.0f ) ),
				1.0f )
				);
		}

		for( int i = 0; i < trianglesNum; i++ ) {
			indicesList[i * 3] = 0;
			indicesList[i * 3 + 1] = (i + 1) % trianglesNum;
			indicesList[i * 3 + 2] = (i + 2) % trianglesNum;
		}
	}


	// Update is called once per frame
	void Update()
    {
		mesh.Clear();
		mesh.SetVertices( verticesList );
		mesh.SetUVs( 0, verticesList );
		mesh.SetColors( colorsList );
		mesh.SetNormals( normalsList );
		mesh.SetIndices( indicesList, MeshTopology.Triangles, 0 );
    }
}
