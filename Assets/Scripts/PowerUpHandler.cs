using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor.Pattern{
    public class PowerUpHandler : MonoBehaviour
    {
        public PowerUps powerUp;
        void OnTriggerEnter(Collider other){
            if(other.GetComponent<PlayerController>()){
                other.GetComponent<PlayerController>().Accept(powerUp);
                gameObject.SetActive(false);
            }
        }
    }
}