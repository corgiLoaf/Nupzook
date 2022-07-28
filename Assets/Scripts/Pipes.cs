using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;

    private void Start() {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 2f;
    }

    private void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime;
        // transform.position = the world space of the Transform. 

        if (transform.position.x < leftEdge){
            Destroy(gameObject);
        }
    }
}
