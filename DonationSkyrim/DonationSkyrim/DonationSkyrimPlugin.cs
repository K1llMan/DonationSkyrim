using NetScriptFramework;

namespace DonationSkyrim
{
    public class DonationSkyrimPlugin : Plugin
    {
        public override string Key => "DonationSkyrimPlugin";
        public override string Name => "Donation Skyrim Plugin";
        public override int Version => 1;

        protected override bool Initialize(bool loadedAny)
        {
            return base.Initialize(loadedAny);
        }
    }
}