using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(MeshRenderer))]

public class MeshGenerator : MonoBehaviour
{

    Mesh mesh;
    Vector3[] vertices;
    int[] triangels;
    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        CreateShape();
        UpdateMesh();
    }

    
    void CreateShape()
    {
        vertices = new Vector3[]
        {
            new Vector3 (0f, 0f, 0f), //0
            new Vector3 (1f, 0f, 0f), //1
            new Vector3 (0f, 0f, 1f), //2
            new Vector3 (1f, 0f, 1f), //3
            new Vector3 (0.5f, 1f, 0.5f), //4
        };

        triangels = new int[]
        {
            0, 1, 2, 
            3, 2, 1,

            1,0,4,
            0,2,4,
            2,3,4,
            3,1,4,

        };
    } 


    void UpdateMesh() 
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangels; 
    }
}
