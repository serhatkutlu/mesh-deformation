using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    [SerializeField]
    GameObject capsule;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            deformMesh();
        }
        
    }

    private void deformMesh()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out hit))
        {
           deformMesh deformmesh= hit.transform.GetComponent<deformMesh>();
            deformmesh.deformmesh(hit.point);
            Instantiate(capsule, new Vector3(hit.point.x,hit.point.y, hit.point.z- 0.123f), Quaternion.Euler(-90, 0, 0));
        }
    }
}
