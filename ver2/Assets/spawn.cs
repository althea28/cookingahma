using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] customers; // Array of customers
    public Transform[] spawnPoints; // Array of spawn points

    private float spawnInterval = 3f; //Spawn customers every 3 secs

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
        Instantiate(customers[index], spawnPoints[index].position, spawnPoints[index].rotation);
    }
}
