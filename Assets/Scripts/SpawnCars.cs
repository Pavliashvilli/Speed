using UnityEngine;
using System.Collections;

public class SpawnCars : MonoBehaviour {

    public GameObject[] cars;
    private float[] positions = { 1.09f, 0.39f, -0.36f, -1.11f };

    void Start() {
        StartCoroutine(spawn());
    }

    IEnumerator spawn() {
        while(Player.alive == true) {
            Instantiate(
                cars[Random.Range(0, cars.Length)],
                new Vector3(positions[Random.Range(0, 4)], 6f, 0),
                Quaternion.Euler(new Vector3(90, 180, 0))
            );
            yield return new WaitForSeconds(2.5f);
        }
    }

}
