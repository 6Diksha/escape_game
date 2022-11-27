using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float maxSpeed=5f;
    private Vector3 input;
    private Vector3 spawn;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        input = new Vector3(Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
        if(GetComponent<Rigidbody>().velocity.magnitude<maxSpeed){
            GetComponent<Rigidbody>().AddRelativeForce(input * moveSpeed);
        }

        if (transform.position.x < -1)
        {
            SceneManager.LoadScene("End");;
        }
    }
}
//     void Restart()
//     {
//         SceneManager.LoadScene(SceneManager.GetActiveScene)
    
// }