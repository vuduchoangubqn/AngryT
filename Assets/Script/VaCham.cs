using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaCham : MonoBehaviour
{
    bool isSpawn;
    float count=0;
    [SerializeField] private GameObject ballPrefab;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Player")
            {
            if (!isSpawn)
            {
                Debug.Log("bing");
                
                /*Instantiate(ballPrefab, new Vector2(gameObject.transform.position.x,gameObject.transform.position.y+2), Quaternion.identity);
                Instantiate(ballPrefab, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 4), Quaternion.identity);
                Destroy(gameObject);
                isSpawn = true;
                count++;
                return; */
                
            }
        }
        Debug.Log(count);
    }
}
