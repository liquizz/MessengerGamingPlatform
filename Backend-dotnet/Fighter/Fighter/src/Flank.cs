using System;
using System.Collections.Generic;
using System.Text;

namespace Fighter.src
{
    class Flank : AbstractArea
    {
        override public List<int> SelectedAlgorithm()
        {
            List<int> var = null;
            return var;
        }

        public override void Attack(int attackedFieldId)
        {
            throw new NotImplementedException();
        }
    }
}
