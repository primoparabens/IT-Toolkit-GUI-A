reg add "HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings" /v ProxyEnable /t REG_DWORD /d 1 /f
reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Internet Settings" /v ProxyServer /t REG_SZ /d 10.107.9.189:8080 /f
reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Internet Settings" /v ProxyOverride /t REG_SZ /d "192.168.*;172.16.*;10.*;172.17.*;*.nordex-ag.com;nordex-sap*.pironet-ndh.com;*.nordex.corz;*.nordex-dmz.internal;*.nordex-hpc.internal;*.project.intern;80.245.147.91;svbpnajdewp01.awptemp.net;*dg-erp.corbox.de;*.acciona.int;*.nif.nordex.nexinto.com;*.nordex-online.com;*.lab.eng;35.156.3.73;*.office.com;*.office365.com;*.microsoft.com;*.broadcast.skype.com;broadcast.skype.com;*.skypeforbusiness.com;*.Nordex-swas.com;*.outlook.com;*.windowsupdate.com;*.windows.com;*.microsoftonline.com;*.officeconfig.msocdn.com;*.azureedge.net;*.lync.com;*.onmicrosoft.com;*.live.com;clientconfig.passport.net;windowsphone.com;*.s-microsoft.com;*.jus.br;*.windows.net;*.epowerbay.com;*.org.br;Svc-pit.internal;*.worksmarter.com.br;<local>" /f