using UnrealBuildTool;
using System.Collections.Generic;

public class GASDocumentationClientTarget : TargetRules
{
	public GASDocumentationClientTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Client;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("GASDocumentation");
	}
}
