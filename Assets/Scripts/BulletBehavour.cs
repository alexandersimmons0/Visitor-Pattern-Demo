using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavour : MonoBehaviour{
    public Rigidbody rigid;

    void OnAwake(){
        rigid.AddForce(0f,0f,20f);
    }

    void OnCollisionEnter(Collision collision){
        Invoke("Delete", 0.3f);
    }

    void Delete(){
        Destroy(gameObject);
    }
}
