using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor.Pattern{
    public class JumpBoost : MonoBehaviour, IPlayerElement{
        public float jumpStrength = 5f;
        private Rigidbody _rb;

        void Start(){
            _rb = GetComponent<Rigidbody>();
        }

        public void TryJump(){
            if(Physics.Raycast(_rb.transform.position, Vector3.down, 0.5f)){
                _rb.velocity = new Vector3(0,jumpStrength,0);
            }
        }

        void Update(){
            if(Input.GetKeyDown(KeyCode.Space)){
                Debug.Log("Jump Attempt");
                TryJump();
            }
        }

        public void Accept(IVisitor visitor){
            visitor.Visit(this);
        }

        void OnGUI(){
            GUI.Label(new Rect(5, 0, 200, 20), "Jump Strength: " + jumpStrength);
        }
    }
}