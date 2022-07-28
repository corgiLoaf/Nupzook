using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable() 
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate); // method, time, repeat rate 
    }

    private void OnDisable() 
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity); // clone the original object and returns the clone.
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }

}
