using MSCLoader;
using UnityEngine;

namespace UpdateTest
{
    public class UpdateTest : Mod
    {
        public override string ID => "UpdateTest"; //Your mod ID (unique)
        public override string Name => "UpdateTest"; //You mod name
        public override string Author => "Hello :)"; //Your Username
        public override string Version => "1.0"; //Version
        public override string UpdateLink => "https://github.com/Athlon007/UpdateTest";
    }
}
