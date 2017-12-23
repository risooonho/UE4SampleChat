// Copyright ZX.Diablo 2017

using UnrealBuildTool;
using System.Collections.Generic;

public class UE4SampleChatEditorTarget : TargetRules
{
	public UE4SampleChatEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "UE4SampleChat" } );
	}
}
