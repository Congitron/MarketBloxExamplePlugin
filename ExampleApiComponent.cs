using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketBloxAPI;

//this setup lets us get info about inputs, outputs, and settings, but we still need a way for the component to ask for values in 
//Initialize() and Update().

namespace MarketBloxExamplePlugin
{
    class ExampleApiComponent : ISystemComponent
    {
        public string DisplayName { get { return "Example Component"; } }

        public void Initialize()
        {
            //do something after user has changed settings
        }

        public List<KeyInfo> Inputs
        {
            get 
            {
                List<KeyInfo> inputs = new List<KeyInfo>();
                
                inputs.Add(new KeyInfo<decimal>("Input A"));
                inputs.Add(new KeyInfo<decimal>("Input B"));
                
                return inputs;
            }
        }

        public List<KeyInfo> Outputs
        {
            get
            {
                List<KeyInfo> outputs = new List<KeyInfo>();

                outputs.Add(new KeyInfo<decimal>("Output"));

                return outputs;
            }
        }

        public List<KeyInfo> Settings
        {
            get
            {
                List<KeyInfo> settings = new List<KeyInfo>();

                settings.Add(new KeyInfo<decimal>("Multiplier", 10));

                return settings;
            }
            
        }

        public void Update()
        {
            //decimal a = GetSubscriberKeyValue<decimal>("Input A"); //get your inputs
            //            decimal b = GetSubscriberKeyValue<decimal>("Input B");
            //            decimal c = SettingValueGet<decimal>("Multiplier"); //get your setting
            //            decimal output = (a * b) / c; //do something
            //            PublishNewDataPacket<decimal>("Output", output); //publish your results
        }
    }
}
