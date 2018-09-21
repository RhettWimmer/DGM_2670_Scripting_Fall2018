using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ForEachLoops : ScriptableObject
{

        public List<FloatData> SpeedOptions;
        public FloatData Randomizer;

        private void OnEnable()
        {
                var randomNum = Random.Range(0, SpeedOptions.Count - 1);
                for (int i = 0; i < SpeedOptions.Count-1; i++)
                {
                        if (i == randomNum)
                        {
                              Randomizer =  SpeedOptions[i];
                        }
                }
        }
}
