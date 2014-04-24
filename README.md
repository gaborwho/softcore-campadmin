Softcore-campadmin
==================
A szoftver célja egy táborhely térkihasználtságának adminisztrálása, valamint statisztikai adatok generálása.

A tábor hierarchiájában a gyerekek 3 szintre vannak osztva.  
- A legmagasabb szint az ország szerinti csoportosítás.  
- A második szint a korcsoport szerinti csoportosítás. 
- A harmadik szint, a túl nagy csoportok optimális méretre (12 fő) való darabolása.

Ez a feloszlás minden turnusban változik, ezért a rendszernek kezelnie kell, a turnusok közötti változást. 

A táborban a férőhelyek dinamikusan változnak. Szükség esetén pótágyakkal, lakókocsikkal bővíthető a telep befogadóképessége. A rendszernek lehetőséget kell biztosítani, hogy újabb szobák, férőhelyek hozzáadásának, módosításának kezelésére.

A rendszer egyik fontos eleme az adatok külső forrásból történő importálása (eddigi megállapodás: CSV import, kötött szemantikával). 

Speciális elemei a rendszernek az ifjúsági vezetők, a korcsoportvezetők, valamint az egyéb 
alkalmazottak, akik szintén a telepen laknak. Ők statisztikai és térkihasználási szempontból 
fontosak, de a csoportokat érintő kérdésekben nem játszanak szerepet.
