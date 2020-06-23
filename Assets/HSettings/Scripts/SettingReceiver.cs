using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Helix.Settings
{
    public class SettingReceiver : MonoBehaviour
    {
        public enum Setting
        {
            AntiAliasing,
            RealtimeReflections,
            ShadowQuality,
            ShadowResolution,
            SoftParticles,
            LodBias
        }
        public Setting setting;
        // Start is called before the first frame update
        void Start()
        {
            if ((int)setting == 0)
            {
                GetComponent<Dropdown>().value = Settings.antiAliasing;
            }
            if ((int)setting == 1)
            {
                GetComponent<Toggle>().isOn = Settings.realtimeReflections;
            }
            if ((int)setting == 2)
            {
                GetComponent<Dropdown>().value = Settings.shadowQuality;
            }
            if ((int)setting == 3)
            {
                GetComponent<Dropdown>().value = Settings.shadowResolution;
            }
            if ((int)setting == 4)
            {
                GetComponent<Toggle>().isOn = Settings.softParticles;
            }
            if ((int)setting == 5)
            {
                GetComponent<Slider>().value = Settings.lodBias;
            }

        }


    }
}