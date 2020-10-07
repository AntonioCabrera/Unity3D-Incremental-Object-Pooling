# Unity3D-Incremental-Object-Pooling

Developed as a friendly object pooling system, supporting multiple pools and incremental instancing steps.

Just download the ObjectPoolingWithExample.unitypackage in the repository root folder, add it to your projects and then...

* 1. Open the GameObjectPool class and define PoolTypes values to be the name you want to give to each pool.

* 2. Add the IncrementalPools script to a GameObject in the scene and configure your pool/s.

* 3. To get an object from the pool call: IncrementalPools.Instance.GetObjectFromPool(PoolTypes.TYPE.ToString());  

* 4. To return an object to the pool call: IncrementalPools.Instance.ReturnObjectToPool(PoolTypes.TYPE.ToString(), gameObjectToReturn);

Optional: IF each pooled object instance object has a script on it, you can manage the pooled object instance life cycle by implementing the IPooleableObject interface in there to define the OnGetFromPool() and OnReturnToPool() logics.
