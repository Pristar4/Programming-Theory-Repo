using System;

namespace UnityTemplateProjects
{
    public class Goblin : Enemy

    {
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage/2);
        }
    }
}