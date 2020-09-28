using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolExampleCapsuleMoving : MonoBehaviour , IPooleableObject
{
    public float MoveSpeed = 30f;

    private float lifeTime;
    private float maxLifeTime = 3f;
    private Vector3 initialPosition;

    private void Awake()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
        lifeTime += Time.deltaTime;
        if (lifeTime > maxLifeTime)
        {
            IncrementalPools.Instance.ReturnObjectToPool(PoolTypes.CapsulesFloating.ToString(),gameObject);
        }

    }

    #region IPooleableObject calls

    public void OnGetFromPool()
    {
        transform.position = initialPosition;
        lifeTime = 0f;
    }

    public void OnReturnToPool()
    {
        
    }

    #endregion
}
