// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class SteamServerTarget : TargetRules
{
	public SteamServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Steam" } );

		GlobalDefinitions.Add("UE_PROJECT_STEAMSHIPPINGID=480");
		GlobalDefinitions.Add("UE_PROJECT_STEAMPRODUCTNAME=\"SkateKing\"");
		GlobalDefinitions.Add("UE_PROJECT_STEAMGAMEDIR=\"SkateKing\"");
		GlobalDefinitions.Add("UE_PROJECT_STEAMGAMEDESC=\"SkateKing\"");
	}
}
