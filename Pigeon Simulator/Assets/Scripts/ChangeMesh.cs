using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMesh : MonoBehaviour
{

    public GameObject swapObject;

    // Use this for initialization
    void Start()
    {
        Mesh swapMesh = swapObject.GetComponent<MeshFilter>().sharedMesh;

        gameObject.GetComponent<MeshFilter>().sharedMesh = swapMesh;

    }
}
