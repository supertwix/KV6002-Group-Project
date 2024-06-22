using UnrealBuildTool;

public class KV6002_GameServerTarget : TargetRules
{
	public KV6002_GameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("KV6002_Game");
	}
}
