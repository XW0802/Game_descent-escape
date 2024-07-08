using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> platforms = new List<GameObject>();

    public float spawnTime;
    private float countTime;
    private Vector3 spawnPosition;
    


    // Update is called once per frame
    void Update()
    {
        SspawnPlatform();
    }

    public void SspawnPlatform()
    {
        countTime += Time.deltaTime;
        spawnPosition = transform.position;
        spawnPosition.x = Random.Range(-3.2f, 3.2f);
        
        if (countTime >= spawnTime)
        {
            Createplatform();
            countTime = 0;

        }

    }

    public void Createplatform()
    {
        int index = Random.Range(0, platforms.Count);

        int spikeNum = 0;
        if(index == 3)
        {
            spikeNum++;
        }

        if (spikeNum > 1)
        {
            spikeNum = 0;
            countTime = spawnTime;
            return;
        }
        GameObject newPlatform = Instantiate(platforms[index], spawnPosition, Quaternion.identity);
        newPlatform.transform.SetParent(this.gameObject.transform);
    }
}
