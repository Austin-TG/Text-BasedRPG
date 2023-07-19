using System.Collections.Generic;

namespace Text_BasedRPG
{
    public partial class Character : GameObject
    {
        private readonly string _race;
        private readonly string _class;
        private readonly string _religion;
        private readonly string _hobby;
        private int _statsAvailable;
        private Dictionary<string, int> _stats;
    }
    public partial class Enemy : GameObject
    {
        private readonly string _type;
        private Dictionary<string, int> _stats;
    }
}