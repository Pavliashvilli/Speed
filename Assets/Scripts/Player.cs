using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject pLost ;

   public float speed = 3f;
   
    public static bool alive = true;


void Start() {
       alive =true;
    }
    void Update() {
        pLost.SetActive (false);
        float hor = Input.GetAxisRaw("Horizontal");
        Vector3 dir = new Vector3(hor, 0, 0);

       transform.Translate(dir.normalized * speed * Time.deltaTime);
    
    }
    

     private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Car")){
            alive = false;
           Destroy(gameObject);
           // Debug.Log("Game Over")
           pLost.SetActive (true);
        }
        
    }

}
