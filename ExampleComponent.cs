<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketBlox.Attributes;
using MarketBlox.SystemCore;

namespace MarketBlox.Examples
{
    [Module("Example", true)]
    public class ExampleComponent : SystemComponent
    {
        public ExampleComponent()
        {
            DisplayName = "Example";
=======
﻿//Deprecated approach

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MarketBlox.Attributes;
>>>>>>> working

//namespace MarketBlox.SystemCore
//{
//    [Module("Example", true)]
//    public class ExampleComponent : SystemComponent
//    {
//        public ExampleComponent()
//        {
//            DisplayName = "Example";

//            //AddSubscriberKey<OHLCData>("OHlC In"); //if you want an OHLC input
//            AddSubscriberKey<decimal>("Input A");
//            AddSubscriberKey<decimal>("Input B");
//            AddSettingKey<decimal>("Multiplier", 10); //you can set a default value
//            AddPublisherKey<decimal>("Output");
//        }

//        public override void Update()
//        {
//            decimal a = GetSubscriberKeyValue<decimal>("Input A"); //get your inputs
//            decimal b = GetSubscriberKeyValue<decimal>("Input B");
//            decimal c = SettingValueGet<decimal>("Multiplier"); //get your setting
//            decimal output = (a * b) / c; //do something
//            PublishNewDataPacket<decimal>("Output", output); //publish your results
//        }
//    }
//}
