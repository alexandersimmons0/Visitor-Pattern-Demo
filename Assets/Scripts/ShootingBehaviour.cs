using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor.Pattern{
    public class ShootingBehaviour : MonoBehaviour, IPlayerElement{
        public float bulletSpeed = 50f;
        public float bulletPower = 1f;
        private GameObject bulletPrefab;
        private GameObject bulletSpawner;

        void Start(){
            bulletSpawner = GameObject.Find("/Player/bulletSpawn");
            bulletPrefab = (GameObject)Resources.Load("bullet", typeof(GameObject));     
        }
        
        void Update(){
            if(Input.GetMouseButtonDown(0)){
                GameObject newBullet = Instantiate(bulletPrefab, bulletSpawner.transform.position, bulletSpawner.transform.rotation);
                newBullet.GetComponent<Rigidbody>().mass = bulletPower;
                newBullet.GetComponent<Rigidbody>().velocity = this.transform.forward * bulletSpeed; 
            }
        }

        public void Accept(IVisitor visitor){
            visitor.Visit(this);
        }

        void OnGUI(){
            GUI.Label(new Rect(5, 30, 200, 20), "Bullet Strength: " + bulletPower);
        }
    }
}