using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor.Pattern{
    public class SpeedBoost : MonoBehaviour, IPlayerElement{
        public float speedStrength = 5f;
        private Rigidbody _rb;
        private float vInput;
        private float hInput;

        void Start(){
            _rb = GetComponent<Rigidbody>();
        }

        void Update(){
            Move();
        }

        void Move(){
            vInput = Input.GetAxis("Vertical") * speedStrength;
            hInput = Input.GetAxis("Horizontal") * speedStrength;
            _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime + this.transform.right * hInput * Time.fixedDeltaTime);
        }

        public void Accept(IVisitor visitor){
            visitor.Visit(this);
        }

        void OnGUI(){
            GUI.Label(new Rect(5, 10, 200, 20), "Speed: " + speedStrength);
        }
    }
}