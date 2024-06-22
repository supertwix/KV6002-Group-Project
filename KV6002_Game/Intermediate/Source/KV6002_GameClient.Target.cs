using UnrealBuildTool;

public class KV6002_GameClientTarget : TargetRules
{
	public KV6002_GameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("KV6002_Game");
	}
}
