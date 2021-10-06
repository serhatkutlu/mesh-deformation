using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    
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
        }
    }
}
