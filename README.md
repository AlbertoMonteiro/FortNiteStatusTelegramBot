# FortNiteStatusTelegramBot

This is a simple bot that can retrive player status on Fortnite.

# Setup

You must create appSettings.json file inside **FortNiteStatusTelegramBot** folder

    {
      "TRN-Api-Key": "your key",
      "TelegramToken": "your key"
    }

# Commands

**/stats** - Return player status; You must specify Epic nickname and platform(optional)

_if player is in more that in platorm, and the platform is not specified, all plataforms will be listed_

    /stats Ninja
    /stats Ninja pc

**/recentmatches** - List the last 10 recents player matches; You must specify Epic nickname and platform(optional)

_if player is in more that in platorm, and the platform is not specified, all plataforms will be listed_

    /recentmatches Ninja

**/help** - Show this help message
