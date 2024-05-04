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

F = G (M m)/ r^2;

za eliptično tirnico: v = sqrt(u(2/r -1/a))


za okroglo tirnico: v= sqrt(u/r);

kjer je u = GM;
## Instalacija
Za pogon simulacije preprosto prenesite Osoncje Simulacija.exe datoteko in jo poženite.
## Datoteke
V reposatoriju so vključene vse C# datoteke, ki nadzorujejo kamero, planete in  besedilo; Simulacja Osoncja.exe datoteka in OsončjeMere.xlsx, kjer so vse uporabljene mere.


## Kontrole
Za navigiranje po Osončju uporabite:
- **Levi klik** za gibanje naprej;
- **Desni klik** za gibanje nazaj;
- **W, A, S, D** za rotacijo kamere gor, dol, levo, desno;
  > Lahko uporabite tudi **E** in **Q** za rotacijo kamere po Z osi.
- **X** za povečanje hitrosi;
- **C** za zmanjšanje hitrosi.
