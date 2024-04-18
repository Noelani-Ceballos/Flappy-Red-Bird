using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    BirdController birdScript;

    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move pipes left
        
      
      if(birdScript.isAlive == true)
        {
            CancelInvoke(); 
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
    
    }

    void Awake ()
    {
         birdScript = GameObject.Find("Red_Bird_1").GetComponent<BirdController>();
    }
}
