using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolExampleCapsuleSpawner : MonoBehaviour
{
    public float SpawnRate;

    private Coroutine spawnerCoroutine;

    void Start()
    {
        spawnerCoroutine = StartCoroutine(SpawnCapsules());
    }

    public IEnumerator SpawnCapsules()
    {

        while (true)
        {
            yield return new WaitForSeconds(SpawnRate);
            IncrementalPools.Instance.GetObjectFromPool(PoolTypes.CapsulesFloating.ToString());
        }

    }
}
