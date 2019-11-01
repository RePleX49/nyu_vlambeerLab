using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTileGenerator : MonoBehaviour
{
    public Mesh[] RandomMeshes;

    // Start is called before the first frame update
    void Start()
    {
        int RandNum = Random.Range(0, RandomMeshes.Length);
        GetComponent<MeshFilter>().mesh = RandomMeshes[RandNum];
    }
}
