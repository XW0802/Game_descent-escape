using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class AnimationBG : MonoBehaviour
{
    Material material; 

    Vector2 movement;

    public Vector2 speed;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        // Ìí¼Ó¸üÐÂÂß¼­
        movement += speed * Time.deltaTime;
        material.mainTextureOffset = movement;
    }
}
