using UnrealBuildTool;

public class KV6002_GameTarget : TargetRules
{
	public KV6002_GameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("KV6002_Game");
	}
}
