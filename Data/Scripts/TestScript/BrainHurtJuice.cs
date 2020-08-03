﻿using Sandbox.Common.ObjectBuilders;
using Sandbox.ModAPI;
using VRage.Game.Components;
using VRage.ModAPI;
using VRage.ObjectBuilders;
using VRage.Utils;

namespace TestScript
{
    [MyEntityComponentDescriptor(typeof(MyObjectBuilder_GasTank), false, "LargeHydrogenTank")]

    class BrainHurtJuice : MyGameLogicComponent
    {

        public override void Init(MyObjectBuilder_EntityBase objectBuilder)
        {
            MyLog.Default.WriteLine("mybraintastesbad");
            NeedsUpdate = MyEntityUpdateEnum.BEFORE_NEXT_FRAME | MyEntityUpdateEnum.EACH_100TH_FRAME | MyEntityUpdateEnum.EACH_FRAME;
        }

        public override void UpdateAfterSimulation100()
        {
            MyAPIGateway.Utilities.ShowMessage("herp", "derp");
        }
    }
}