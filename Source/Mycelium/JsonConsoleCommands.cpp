#include "JsonSaveSystem.h"
#include "Misc/Paths.h"
#include "Serialization/JsonSerializer.h"

// Global-scope static console command
static FAutoConsoleCommand TestJsonCmd(
	TEXT("Test.Json"),
	TEXT("Tests JSON save/load"),
	FConsoleCommandDelegate::CreateStatic([]()
	{
		JsonSaveSystem SaveSystem;
		FString Path = FPaths::ProjectSavedDir() / TEXT("ConsoleTest.json");

		TSharedPtr<FJsonObject> Obj = MakeShared<FJsonObject>();
		Obj->SetStringField("Level", "01");
		Obj->SetStringField("PlayerName", "Maman");
		Obj->SetStringField("MusicVolume", "50");
		Obj->SetStringField("Resolution", "1920*1080");

		SaveSystem.WriteJsonFile(Path, Obj);

		UE_LOG(LogTemp, Warning, TEXT("Test.Json executed"));
	})
);
