using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShotShell : MonoBehaviour {
    int d;
    
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    void OnCollisionEnter(Collision other)
    {
        
        
            
            
            
                //D村に当たったら球が消える
                if (other.gameObject.tag == "Dmura")
                {
                    Destroy(gameObject);
                    

                }
            
            
            
        
        
    }

    



    //撃ってから1秒で球が消える
    public float Time = 1.0f;

    private void Start()
    {
        Destroy(gameObject, Time);
    }

    
}
