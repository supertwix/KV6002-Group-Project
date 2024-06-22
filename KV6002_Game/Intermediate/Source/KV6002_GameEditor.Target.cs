using UnrealBuildTool;

public class KV6002_GameEditorTarget : TargetRules
{
	public KV6002_GameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("KV6002_Game");
	}
}
