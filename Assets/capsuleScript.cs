using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("block"))
        {
            print(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
