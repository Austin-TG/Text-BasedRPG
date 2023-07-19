using System;
using System.Collections.Generic;

namespace Text_BasedRPG
{
    public partial class Character : GameObject
    {
        public Character(String race, String cclass, string religion, string hobby)
        {
            this._race = race;
            this._class = cclass;
            this._religion = religion;
            this._hobby = hobby;

            StatsAssign();
        }
        private void StatsAssign(string stat = null)
        {
            if (stat != null)
            {
                _stats[stat] += 1;
            }
            _stats = new Dictionary<string, int>()
            {
                {"Strength", 0 },
                {"Dexterity", 0 },
                {"Intelligence", 0 },
                {"Wisdom", 0 },
                {"Luck", 0 }
            };
        }
        private void StatsClear()
        {
            _stats.Clear();
        }
        private void StatsLevelUp()
        {
            _statsAvailable += 1;
        }
        private void StatsGetValues()
        {
            foreach (KeyValuePair<string, int> kvp in _stats)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }
        public override void Description()
        {
            Console.WriteLine("Object is Character");
        }
    }
}