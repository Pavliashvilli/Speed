using UnityEngine;
using UnityEditor;

public class MoveAndSpawnRoad : MonoBehaviour {

    public float speed = 1.5f;
    public GameObject road;

    void Update() {
        if (Player.alive == true )
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -8f) {
            Instantiate(road, new Vector3(0.01f, 10.95f, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
