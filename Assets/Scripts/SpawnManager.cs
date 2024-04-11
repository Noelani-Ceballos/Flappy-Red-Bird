using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;

    float minY = 0.58f;
    float maxY = 6.52f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(7.57f,Random.Range(minY, maxY)), Quaternion.identity);
    }


}

