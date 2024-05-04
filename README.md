# Simulacija Osončja
Ta projek je simulacja kroženja planetov okoli Sonca v igralnem pogonu Unity. 
## Značilnosti
V simulaciji planeti za seboj puščajo sled, da se lažje upazi eliptično kroženje okoli Sonca.
Vsak planet ima svojo texturo in nad seboj napisan ime, da se ga lažje najde.


Uporabljene so skrajšane ente za razdanjo med planeti. Ena enota v simulaciji je enaka 10^5 km. 
Masa planetov je naravnana na maso Zemlje, kar pomeni, če je masa v simulaciji enaka 1, potem je to enako masi Zemlje oziroma 5.972 × 10^24 kg.
Gravitacijska konstanta je iz 6.67 * 10^-11 Nm^2/kg^2 nastavljena na 10 za hitrejšo kroženje planetov.


Okoli Zemlje se vrti tudi Luna.
## Fizika za simulacijo
Za simulacijo sta uporabljeni samo dve formuli:
sila med planeti in Soncem

F = G (M m)/ r^2;

začetna hitrost za eliptično tirnico: v = sqrt(µ(2/r -1/a));


>za okroglo tirnico: v= sqrt(µ/r);

kjer je µ = GM;
## Instalacija
Za pogon simulacije prenesite mapo **"Mapa za instalacijo"** na disk. V mapi najprej odpakirajte Osoncje **"Simulacija_Data.zip"** in **"UnityPlayer.zip"**, nato pa lahko poženete **"Osoncje Simulacija.exe"**.
## Datoteke
V reposatoriju so vključene vse C# skripti, ki nadzorujejo kamero, planete in  besedilo, Mapa za instalacijo in OsončjeMere.xlsx, kjer so napisane vse uporabljene mere.


## Kontrole
Za navigiranje po Osončju uporabite:
- **Levi klik** za gibanje naprej;
- **Desni klik** za gibanje nazaj;
- **W, A, S, D** za rotacijo kamere gor, dol, levo, desno;
  > Lahko uporabite tudi **E** in **Q** za rotacijo kamere po Z osi.
- **X** za povečanje hitrosi;
- **C** za zmanjšanje hitrosi.
