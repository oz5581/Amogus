# PluginTemplate
Basic plugin template. On tshock pre12

# Updating a plugin from before 1.4  
1. Update references to the latest `TShockAPI.dll`, `TerrariaServer.exe`, and `OTAPI.dll`, and if applicable reference `Newtonsoft.Json.dll` to version 9.0.0 if using a strict out of date reference
2. Replace all occurrences of errors


## Some Breaking API Changes from 4.3.25 -> 4.3.26+
| 4.3.25 | 4.3.26+ |
| -- | -- |
| TSPlayer.GiveItem(int type, string name, int width, int height, int stack, int prefix = 0) | TSPlayer.GiveItem(int type, int stack, int prefix = 0) |
| TShock.Utils.FindPlayer(string playerName) | TShockAPI.TSPlayer.FindByNameOrID(string playerName) |
| TSPlayer.User | TSPlayer.Account |
| TShockAPI.DB.User | TShockAPI.DB.UserAccount |
| TShock.Users.GetUserByName(string playerName) | TShock.UserAccounts.GetUserAccountByName(string playerName) |
  
You can compare between [4.3.25 and general-devel](https://github.com/Pryaxis/TShock/compare/v4.3.25...general-devel) for all changes.  
Alt-click on any one file collapse button to open/close all files at the same time.  
