using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject customer; 
    public Transform spawnPoint; 

    private float spawnInterval = 3f;  

    private void Start()
    {
         StartCoroutine(SpawnCustomersCoroutine());
    }

    private IEnumerator SpawnCustomersCoroutine()
    {
        while (true)
        {
             yield return new WaitForSeconds(spawnInterval);

    
            SpawnCustomer();
        }
    }

    private void SpawnCustomer()
    {
 
        Instantiate(customer, spawnPoint.position, spawnPoint.rotation);
    }
}