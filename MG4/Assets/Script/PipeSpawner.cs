using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipeGroupPrefab;
    public float spawnInterval = 2f;
    public float minY = -1f;
    public float maxY = 2f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            float y = Random.Range(minY, maxY);
            Vector3 pos = new Vector3(transform.position.x, y, 0f);
            Instantiate(pipeGroupPrefab, pos, Quaternion.identity);
            timer = 0f;
        }
    }
}
