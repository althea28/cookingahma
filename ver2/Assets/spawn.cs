using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] customers;  
    public Transform[] spawnPoints;  

    private float spawnInterval = 3f; // Spawn customers every 3 seconds

    private int spawnCount = 0;

    private void Start()
    {
        StartCoroutine(SpawnCustomersCoroutine());
    }

    private IEnumerator SpawnCustomersCoroutine()
    {
        while (spawnCount < spawnPoints.Length)
        {
            yield return new WaitForSeconds(spawnInterval);

            SpawnCustomer(spawnCount);
            spawnCount++;
        }
    }

    private void SpawnCustomer(int index)
    {
        GameObject customer = Instantiate(customers[index], spawnPoints[index].position, spawnPoints[index].rotation);
        customer.SetActive(true); 

    }
}