using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 2f;
    public float leftLimit = -10f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
    }
}
