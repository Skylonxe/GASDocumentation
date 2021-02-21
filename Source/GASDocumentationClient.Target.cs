using UnrealBuildTool;
using System.Collections.Generic;

public class GASDocumentationTarget : TargetRules
{
	public GASDocumentationTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Client;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("GASDocumentation");
	}
}
