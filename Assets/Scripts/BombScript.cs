using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public GameObject bombPrefab;
    float minX = -2.55f;
    float maxX = 2.55f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBomb());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnBomb()
    {
        yield return new WaitForSeconds(Random.Range(0f,1f));
        Instantiate(bombPrefab, new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.identity);
        StartCoroutine(SpawnBomb());


    }
}
