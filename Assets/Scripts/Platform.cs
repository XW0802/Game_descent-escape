using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Vector3 movement;
    public float speed;
    GameObject topline;
    // Start is called before the first frame update
    void Start()
    {
        movement.y = speed;
        topline = GameObject.Find("Topline");
    }

    // Update is called once per frame
    void Update()
    {
        MovePlatform();
        
    }

    void MovePlatform()
    {
        transform.position += movement * Time.deltaTime;
        if(transform.position.y >= topline.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
