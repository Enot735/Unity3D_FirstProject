using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMain : MonoBehaviour
{
    public GameObject myPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1000; i++)
        {
            Instantiate(myPrefab, new Vector3(Random.Range(-2, 3), i * 5, Random.Range(-2, 3)), Quaternion.identity);
        }        
    }
}
