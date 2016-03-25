; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{993C892C-A6CB-45D9-A54B-E180AEC4DF55}
AppName=Saraaz Erp
AppVersion=Saraaz Erp 1.5
;AppVerName=Saraaz Erp Saraaz Erp 1.5
AppPublisher=Lymytz Sarl
AppPublisherURL=http://www.lymytz.com/
AppSupportURL=http://www.lymytz.com/
AppUpdatesURL=http://www.lymytz.com/
DefaultDirName={pf}\Saraaz Erp
DefaultGroupName=Saraaz Erp
AllowNoIcons=yes
OutputDir=E:\
OutputBaseFilename=SaraazErp
SetupIconFile=E:\Projets\SARAAZ-ERP\Application\GESCAISSE_SARAAZ_ERP\GESCAISSE_SARAAZ_ERP\IMG\favicon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "E:\Projets\SARAAZ-ERP\Application\GESCAISSE_SARAAZ_ERP\GESCAISSE_SARAAZ_ERP\bin\Debug\GESCAISSE_SARAAZ_ERP.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Projets\SARAAZ-ERP\Application\GESCAISSE_SARAAZ_ERP\Librairie Ext\Npgsql.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\Projets\SARAAZ-ERP\Application\GESCAISSE_SARAAZ_ERP\GESCAISSE_SARAAZ_ERP\IMG\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\Saraaz Erp"; Filename: "{app}\GESCAISSE_SARAAZ_ERP.exe"
Name: "{group}\{cm:ProgramOnTheWeb,Saraaz Erp}"; Filename: "http://www.lymytz.com/"
Name: "{commondesktop}\Saraaz Erp"; Filename: "{app}\GESCAISSE_SARAAZ_ERP.exe"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\Saraaz Erp"; Filename: "{app}\GESCAISSE_SARAAZ_ERP.exe"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\GESCAISSE_SARAAZ_ERP.exe"; Description: "{cm:LaunchProgram,Saraaz Erp}"; Flags: nowait postinstall skipifsilent
