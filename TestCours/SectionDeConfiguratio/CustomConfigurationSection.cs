using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SectionDeConfiguratio
{
    public class CustomConfigurationSection : ConfigurationSection
    {
        private const string windowsTitleArtifact = "windowsTitle";
        private const string delayArtifact = "delay";
        private const string backColorArtifact = "backColor";

        #region GetSection

        private const string SectionName = "windowsConfig";

        public static CustomConfigurationSection GetSection()
        {
            return (CustomConfigurationSection)ConfigurationManager.GetSection(SectionName);
        }

        #endregion GetSection


        [ConfigurationProperty(windowsTitleArtifact, DefaultValue = "Default Title")]
        public string WindowsTitle
        {
            get
            {
                return (string)this[windowsTitleArtifact];
            }
            set
            {
                this[windowsTitleArtifact] = value;
            }
        }

        [ConfigurationProperty(delayArtifact, DefaultValue = 5)]
        public int Delay
        {
            get
            {
                return (int)this[delayArtifact];
            }
            set
            {
                this[delayArtifact] = value;
            }
        }

        [ConfigurationProperty(backColorArtifact, DefaultValue = "#ffff0000")]
        public string BackColor
        {
            get
            {
                return (string)this[backColorArtifact];
            }
            set
            {
                this[backColorArtifact] = value;
            }
        }
    }
}
