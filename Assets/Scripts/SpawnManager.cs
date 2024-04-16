using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;

    public BirdController birdScript; 

    float minY = 0.58f;
    float maxY = 6.52f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 2, 4);
        birdScript = GameObject.Find("Red_Bird_1").GetComponent<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(birdScript.isAlive == false)
        {
            CancelInvoke();
        }
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(7.57f,Random.Range(minY, maxY)), Quaternion.identity);
    }


}

