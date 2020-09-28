using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolExampleCubeSpawner : MonoBehaviour 
{
    public float RandomBoxSpawnSize;
    public float spawnRate;

    private Coroutine spawnerCoroutine;

    void Start()
    {
        spawnerCoroutine = StartCoroutine(SpawnCubes());
    }

    public IEnumerator SpawnCubes()
    {

        while (true)
        {
            GameObject currentCube = null;

            currentCube = IncrementalPools.Instance.GetObjectFromPool(PoolTypes.CubesFalling.ToString());
            

            Vector3 position = new Vector3();

            position.x = Random.Range(-RandomBoxSpawnSize, RandomBoxSpawnSize);
            position.y = 4;
            position.z = Random.Range(-RandomBoxSpawnSize, RandomBoxSpawnSize);

            currentCube.transform.position = position;
            currentCube.transform.rotation = Random.rotation;
            currentCube.GetComponent<Rigidbody>().AddTorque(position * 100);
            currentCube.GetComponent<Rigidbody>().velocity = Vector3.zero;
            currentCube.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            yield return new WaitForSeconds(spawnRate);
        }

    }

  
}
