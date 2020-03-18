using UnityEngine;

public class MoveObjects : MonoBehaviour {

    public static float speed =2.0f ;
   // public int a = 0 ;

    void FixedUpdate() {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.y < -6 ){
            Destroy(gameObject);
            OnCarDestroyed();
            speed+=0.5f; 
        }
    }

    void OnCarDestroyed () {
      PlayerPrefs.SetInt ("Score", 1 + PlayerPrefs.GetInt ("Score"));
    }
}
