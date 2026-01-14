// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Myceland : ModuleRules
{
    public Myceland(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "EnhancedInput",
            "AIModule",
            "NavigationSystem",
            "StateTreeModule",
            "GameplayStateTreeModule",
            "Niagara",
            "UMG",
            "Slate",
            "Json",
            "JsonUtilities"
        });

        PrivateDependencyModuleNames.AddRange(new string[] { });

        PublicIncludePaths.AddRange(new string[] {
            "Myceland",
            "Myceland/Variant_Strategy",
            "Myceland/Variant_Strategy/UI",
            "Myceland/Variant_TwinStick",
            "Myceland/Variant_TwinStick/AI",
            "Myceland/Variant_TwinStick/Gameplay",
            "Myceland/Variant_TwinStick/UI"
        });

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
