using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor.Pattern{
    public interface IVisitor{
        void Visit(JumpBoost jumpBoost);
        void Visit(SpeedBoost speedBoost);
        void Visit(ShootingBehaviour shooting);
    }

    public interface IPlayerElement{
        void Accept(IVisitor visitor);
    }
}
