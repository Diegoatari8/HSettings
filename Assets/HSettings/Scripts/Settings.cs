using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
namespace Helix.Settings
{
    public class Settings : MonoBehaviour
    {
        public static int antiAliasing;
        public static bool realtimeReflections;
        public static int shadowQuality;
        public static int shadowResolution;
        public static bool softParticles;
        public static float lodBias;
       
        string configFilePath;

        //configuration name. used to be able to read them in config file and ignore when parsing
        string[] cfn = new string[6] { "antiAliasing:", "realtimeReflections:", "shadowQuality:", "shadowResolution:", "softParticles:", "lodBias:" };
        // Start is called before the first frame update
        void Awake()
        {
            configFilePath = Directory.GetCurrentDirectory() + "/config.txt";
            if (!File.Exists(configFilePath))
            {

                StreamWriter writer = new StreamWriter(configFilePath, true);
                string configuration = cfn[0] + antiAliasing + ";" + cfn[1] + realtimeReflections + ";" + cfn[2] + shadowQuality + ";" + cfn[3] + shadowResolution + ";" + cfn[4] + softParticles + ";" + cfn[5] + lodBias;
                string[] config = configuration.Split(" ".ToCharArray());

                foreach (string cfg in config)
                {
                    writer.WriteLine(cfg);


                }
                writer.Close();
            }
            else
            {
                StreamReader reader = new StreamReader(configFilePath);
                string configuration = reader.ReadToEnd();
                string[] config = configuration.Split(";".ToCharArray());
                for (int i = 0; i < cfn.Length; i++)
                {
                    config[i] = config[i].Replace(cfn[i], "");
                }

                antiAliasing = int.Parse(config[0]);

                realtimeReflections = bool.Parse(config[1]);
                shadowQuality = int.Parse(config[2]);
                shadowResolution = int.Parse(config[3]);
                softParticles = bool.Parse(config[4]);
                lodBias = float.Parse(config[5]);
                reader.Close();
                SetQualitySettings(antiAliasing, realtimeReflections, shadowQuality, shadowResolution, softParticles, lodBias);

            }





        }

        void SetQualitySettings(int aa, bool refl, int sq, int sr, bool sp, float lod)
        {

            QualitySettings.antiAliasing = aa;
            QualitySettings.realtimeReflectionProbes = refl;
            QualitySettings.shadows = (ShadowQuality)sq;
            QualitySettings.shadowResolution = (ShadowResolution)sr;
            QualitySettings.softParticles = sp;
            QualitySettings.lodBias = lod;
            SaveSettings();


        }
        void SaveSettings()
        {


            File.WriteAllText(configFilePath, "");

            StreamWriter writer = new StreamWriter(configFilePath, true);

            string configuration = cfn[0] + antiAliasing + ";" + cfn[1] + realtimeReflections + ";" + cfn[2] + shadowQuality + ";" + cfn[3] + shadowResolution + ";" + cfn[4] + softParticles + ";" + cfn[5] + lodBias;
            string[] config = configuration.Split(" ".ToCharArray());

            foreach (string cfg in config)
            {
                writer.WriteLine(cfg);


            }
            writer.Close();
        }
        public void ChangeAA(int newValue)
        {
            antiAliasing = Mathf.Clamp(Mathf.RoundToInt(newValue) * 3,0,8);
            SetQualitySettings(antiAliasing, realtimeReflections, shadowQuality, shadowResolution, softParticles, lodBias);
        }
     
        public void ChangeRR(bool newValue)
        {
            realtimeReflections = newValue;
            SetQualitySettings(antiAliasing, realtimeReflections, shadowQuality, shadowResolution, softParticles, lodBias);
        }
        public void ChangeSQ(int newValue)
        {
            shadowQuality = newValue;
            SetQualitySettings(antiAliasing, realtimeReflections, shadowQuality, shadowResolution, softParticles, lodBias);
        }
        public void ChangeSR(int newValue)
        {
            shadowResolution = newValue;
            SetQualitySettings(antiAliasing, realtimeReflections, shadowQuality, shadowResolution, softParticles, lodBias);
        }
        public void ChangeSP(bool newValue)
        {
            softParticles = newValue;
            SetQualitySettings(antiAliasing, realtimeReflections, shadowQuality, shadowResolution, softParticles, lodBias);
        }
        public void ChangeLOD(float newValue)
        {
            lodBias = newValue;
            SetQualitySettings(antiAliasing, realtimeReflections, shadowQuality, shadowResolution, softParticles, lodBias);
        }
       
    }
}