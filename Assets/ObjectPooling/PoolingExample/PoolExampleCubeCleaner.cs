using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolExampleCubeCleaner : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
            IncrementalPools.Instance.ReturnObjectToPool(PoolTypes.CubesFalling.ToString(), other.gameObject);
    }
}
