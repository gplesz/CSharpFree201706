
## Egy jól használható, magyar nyelvű C# jegyzet ami ingyenesen letölthető
[Reiter István: C# programozás lépésről lépésre](https://devportal.hu/download/E-bookok/csharp%20jegyzet/C%23%20programozas%20lepesrol%20lepesre%20-%20Reiter%20Istvan%20(frissitett%20tartalommal%202012.10.15).pdf)
 vagy [meg is](https://bookline.hu/product/home.action?_v=_&id=116239&type=22) [vásárolható](https://www.libri.hu/konyv/reiter_istvan.c-programozas-lepesrol-lepesre.html)

## Előkészületek
A tanfolyamon **Windows** operációs rendszeren futó [Visual Studio 2015 Community](https://www.visualstudio.com/vs/community/) fejlesztői keretrendszert fogunk használni. Azt mondanám, hogy a tanfolyam valószínűleg majdnem minden Visual Studio változattal követhető (2008/2010/2012/2013/2015), de mivel ez elérhető, ingyenes és a legfrissebb, és majd ahogy látjuk, egy jó parancssorban két parancs kiadásával telepíthető, nem nagyon van értelme alternatívákat keresni.

### Visual Studio 2015 Community telepítése
A tanfolyamon ezt az alkalmazást fogjuk használni. Ingyenesen elérhető önálló fejlesztők, nyílt forráskódú projektek, akadémiai kutatók számára. Továbbá oktatási célokra és kis (max 5 fős) fejlesztőcsapatoknak.

Letölteni az előző linkről vagy [innen lehet](https://www.visualstudio.com/free-developer-offers/). Ehhez a tanfolyamhoz telepíteni az alapértelmezett beállításokkal elég.

Vagy, 

[ha valaki szeret újat kipróbálni](http://netacademia.blog.hu/2016/11/03/hogyan_keszitsunk_chocolatey_csomagot_az_alkalmazasunkhoz), akkor telepítheti [Chocolatey](https://chocolatey.org/) csomagkezelővel is. 

[Telepítés](https://chocolatey.org/install): ehhez 

#### 1. 
indítsunk egy adminisztrátori parancssort ([elevated command prompt](http://www.computerhope.com/jargon/e/elevated.htm)), 

#### 2.
tegyük vágólapra ezt (igen, az egészet!):

**@powershell -NoProfile -ExecutionPolicy Bypass -Command "iex ((New-Object System.Net.WebClient).DownloadString('https://chocolatey.org/install.ps1'))" && SET "PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin"**

#### 3.
majd a parancssorunkba illesszük be és futtassuk le.

Ezzel telepítettünk egy csomagkezelőt, innentől kezdve nem kell letölteni és telepíteni kattintgatásokkal az alkalmazásainkat, hanem a csomagkezelőnkre bizhatjuk a dolgot, legalábbis [jelenleg már több, mint 4000 alkalmazás esetében](https://chocolatey.org/packages).

Ha van csomagkezelőnk, a Visual Studio Community telepítése [adminisztrátori parancssorból így megy](https://chocolatey.org/packages/VisualStudio2015Community): 

#### 4.

**cinst visualstudio2015community**

Ezzel meg is vagyunk az előkészületekkel, a többit a tanfolyamon folytatjuk!

A [tanfolyami oldal](http://www.netacademia.hu/CsharpFree-programozasi-alapismeretek-c-nyelven) első videója bemutatja, hogy telepítettem a Visual Studio 2015 Community változatát.
