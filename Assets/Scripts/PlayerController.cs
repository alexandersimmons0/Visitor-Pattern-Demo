using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor.Pattern{
    public class PlayerController : MonoBehaviour, IPlayerElement{
        private List<IPlayerElement> _playerElements = new List<IPlayerElement>();

        void Start(){
            _playerElements.Add(gameObject.AddComponent<JumpBoost>());
            _playerElements.Add(gameObject.AddComponent<SpeedBoost>());
        }

        public void Accept(IVisitor visitor){
            foreach(IPlayerElement element in _playerElements){
                element.Accept(visitor);
            }
        }
    }
}