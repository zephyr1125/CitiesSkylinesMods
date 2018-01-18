using ICities;

namespace ZephyrTest
{
    public class TestOne : IUserMod
    {
        public string Name
        {
            get { return "太昊的Mod"; }
        }

        public string Description
        {
            get { return "太昊的Mod的测试"; }
        }
    }

    public class TestOneResource : ResourceExtensionBase
    {
        public override void OnAfterResourcesModified(int x, int z, NaturalResource type, int amount)
        {
            
        }
    }
}