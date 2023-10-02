using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor.Pattern{
    [CreateAssetMenu(fileName = "PowerUps", menuName = "PowerUps")]
    public class PowerUps : ScriptableObject, IVisitor{
        public string powerupName;
        public GameObject powerupPrefab;
        public string powerupDescription;

        [Range(0.0f, 100f)]
        public float speedBooster;

        [Range(0.0f, 50f)]
        public float bulletStrength;

        [Range(0.0f, 100f)]
        public float jumpBooster;

        public void Visit(JumpBoost jumpBoost){
            float booster = jumpBoost.jumpStrength += jumpBooster;
        }

        public void Visit(SpeedBoost speedBoost){
            float boost = speedBoost.speedStrength += speedBooster;      
        }

        public void Visit(ShootingBehaviour shooting){
            float strength = shooting.bulletPower += bulletStrength;
        }
    }
}