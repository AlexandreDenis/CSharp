using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SectionSpec
{
    public class CustomConfigurationSection : ConfigurationSection
    {
        private const string helloWorldMessageArtifact = "helloWorldMessage";

        #region GetSection

        private const string SectionName = "customConfig";

        public static CustomConfigurationSection GetSection()
        {
            return (CustomConfigurationSection)ConfigurationManager.GetSection(SectionName);
        }

        #endregion GetSection


        [ConfigurationProperty(helloWorldMessageArtifact, DefaultValue="Hello World")]
        public string HelloWorldMessage
        {
            get
            {
                return (string)this[helloWorldMessageArtifact];
            }
            set
            {
                this[helloWorldMessageArtifact] = value;
            }
        }
    }
}
