using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deformMesh : MonoBehaviour
{
    MeshFilter meshfilter;
    Mesh mesh;
    Vector3[] verts;
    [SerializeField]
    float Power, Radius;

    void Start()
    {
        meshfilter = GetComponent<MeshFilter>();
        mesh = meshfilter.mesh;
        verts = mesh.vertices;
    }

    // Update is called once per frame
   public void deformmesh(Vector3 posisiontodeform)
    {
        print(posisiontodeform);
        posisiontodeform = transform.InverseTransformPoint(posisiontodeform);
        print(posisiontodeform);
        for (int i = 0; i < verts.Length; i++)
        {
            float dist = (verts[i] - posisiontodeform).sqrMagnitude;
            if (dist < Radius)
            {
                verts[i] -= Vector3.up * Power;
            }
        }
        mesh.vertices = verts;

    }
}
