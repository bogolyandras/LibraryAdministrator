/*
 * Script for initializing the database
 */

CREATE TABLE application_users (
    id int IDENTITY(1,1) PRIMARY KEY,
    username nvarchar(255) NOT NULL UNIQUE,
    password nvarchar(255) NOT NULL,
	role nvarchar(255) CHECK (role IN ('Customer', 'Administrator'))
);

CREATE TABLE customer_details (
	id int IDENTITY(1,1) PRIMARY KEY,
	application_user_id int NOT NULL UNIQUE,
	name nvarchar(255),
	street_address nvarchar (255),
	date_of_birth_year int,
	FOREIGN KEY (application_user_id) REFERENCES application_users(id)
);

CREATE TABLE categories (
	id int IDENTITY(1,1) PRIMARY KEY,
	name varchar(255) UNIQUE
);

CREATE TABLE books (
	id int IDENTITY(1,1) PRIMARY KEY,
	title nvarchar(255) NOT NULL UNIQUE,
	category_id int NOT NULL,
	description nvarchar(1024),
	author nvarchar(255),
	year_of_publishing int,
	isbn nvarchar(255),
	available INT NOT NULL DEFAULT 1 CHECK (available >= 0),
	FOREIGN KEY (category_id) REFERENCES categories(id)
);

CREATE TABLE book_lendings (
	id int IDENTITY(1,1) PRIMARY KEY,
	book_id int NOT NULL,
	transaction_finished bit NOT NULL DEFAULT 0,
	application_user_id int NOT NULL,
	start_date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	end_date DATETIME,
	FOREIGN KEY (book_id) REFERENCES books(id),
	FOREIGN KEY (application_user_id) REFERENCES application_users(id)
);

INSERT INTO application_users(username, password, role)
VALUES
('admin', 'admin', 'Administrator'),
('customer1', 'customer1', 'Customer'),
('customer2', 'customer2', 'Customer');


INSERT INTO customer_details(application_user_id, name, street_address, date_of_birth_year)
VALUES
((SELECT id FROM application_users WHERE username='customer1'), 'Szabó János', '9023, Győr, Szigethy Attila út 106', 1984),
((SELECT id FROM application_users WHERE username='customer2'), 'Nagy Árpád', '9023, Győr, Körkemence u. 2', 1987);

INSERT INTO categories(name)
VALUES ('Életmód'), ('Ezoterika'), ('Gasztronómia'), ('Gazdaság'), ('Informatika'), ('Irodalom');

INSERT INTO books(title, category_id, description, author, year_of_publishing, isbn)
VALUES
('A család háziorvosa', (SELECT id FROM categories WHERE name = 'Életmód'), 'Könyvünk segítséget nyújt a betegségek korai felismeréséhez, és hogy milyen esetekben forduljunk szakorvoshoz. Tanácsokat ad olyan betegségekről és gyógymódokról is, amit akár mi is kérdezhettünk volna háziorvosunktól, de esetleg nem mertük feltenni.', 'Cesko Izabella', 2004, '9789639497702'),
('A koleszterin nem ártalmas', (SELECT id FROM categories WHERE name = 'Életmód'), 'A ma uralkodó felfogás szerint: A koleszterin egy ártalmas anyag. Tudja meg, hogy mi az igazság!', 'dr. Lenkei Gábor', 2012, '9789638936448'),
('A feng shui kézikönyve', (SELECT id FROM categories WHERE name = 'Ezoterika'), 'A feng shui ősi kínai művészet, melynek lényege: harmóniában élni környezetünkkel. Ez az átfogó kézikönyv szemléletes és könnyen érthető módon ismerteti meg olvasóját az évezredes tan alapjaival.', '	Alexandra Kiadó', 2012, '9789632979144'),
('A jövendőmondás 8 módja', (SELECT id FROM categories WHERE name = 'Ezoterika'), 'Az ember mindig is kíváncsi volt a jövőjére. A világ különböző tájain, különböző kultúrákban más és más jóslási módszerek terjedtek el.', 'Sarah Bartlett', 2007, '9789639652408'),
('A 100 legfinomabb húsétel', (SELECT id FROM categories WHERE name = 'Gasztronómia'), 'Hogyan készül a báránycomb? Miként lehet elkészíteni a Rockefeller osztrigát? Milyen a brandyszósz, a mustárpác? Mindezekre a kérdésekre ad választ a színes képekkel teli kötet, amely gyakorlati szempontok alapján dolgozza fel a különböző népek ételeit, különleges receptjeit.', 'Takács Erika', 2004, '9789632145396'),
('Magyar ízek varázsa', (SELECT id FROM categories WHERE name = 'Gasztronómia'), 'A szerző mesterszakács, odaadó híve és elkötelezett propagálója a magyar konyhának. "Főzzünk magyarul" című könyvéből, amely szintén a M-érték Kiadónál jelent meg, több kiadásban, sok ezren sajátíthatták el a magyar konyha alapételeinek elkészítési módját. ', 'Liscsinszky Béla', 2012, '9786155113536'),
('A nyílt társadalom - avagy a globális kapitalizmus megreformálása', (SELECT id FROM categories WHERE name = 'Gazdaság'), 'Soros György könyvében egy egészen új, meghökkentő szemszögből veszi nagyítóüveg alá eddigi elképzeléseit, oly módon, hogy közben a legfrissebb globális gazdasági és politikai fejleményeket is bevonja elemzési körébe, feltárva ezzel a gazdasági és politikai rendszer összehangolatlanságát.', 'Soros György', 2001, '9789639193550'),
('Bolti eladás', (SELECT id FROM categories WHERE name = 'Gazdaság'), 'A bolti eladás nem egyszerű feladat, már jóval azelőtt el kell kezdenünk készülni rá, mielőtt reggel kinyitnánk az üzlet ajtaját. Részben mesterség, azaz magas szintű tudás, részben pedig művészet, hiszen az általános ismereteken túl mindenkinek meg kell találnia a saját hangját is, amivel hitelesen tudja megszólítani a vevőt. ', 'Rozványi Dávid', 2007, '9789639425170'),
('Access 2007 zsebkönyv', (SELECT id FROM categories WHERE name = 'Informatika'), 'E könyvecske segítségével megismerhetjük az Office 2007 adatbázis-kezelő programjának, az Access 2007-nek kezelését. A közérthető nyelvezet miatt bátran ajánljuk akár kezdőknek is, de hasznos lehet azok számára is, akik ECDL vagy egyéb vizsgára készülnek, vagy akik az adatbázis-kezelés további lehetőségeivel kívánnak megismerkedni, mivel e könyvecske az Access 2007 kezeléséhez szükséges ismereteken túl további hasznos tanácsokat is ad.', 'Bártfai Barnabás', 2007, '9425255'),
('A C# nyelv és a programozás alapjai ', (SELECT id FROM categories WHERE name = 'Informatika'), '"Vannak, akik úgy gondolják, hogy a programozás a mai világban már elengedhetetlen tudás azok számára, akik az informatika világában kívánnak elhelyezkedni. Sokan úgy vélik, hogy a programozás segítségével megkönnyíthetik, hatékonyabbá tehetik a munkájukat. Mások pedig egyszerűen az alkotás örömét találják meg a programozásban.', 'Jónás Katalin', 2014, '9786155012273'),
('A tegnap világa', (SELECT id FROM categories WHERE name = 'Irodalom'), 'A tegnap világa a nagy memoárirodalomnak is kitűnő darabja, épp ezért aki hiteles tanút akar megszólaltatni például az 1914 előtti Bécs életének, hangulatának, társadalmának a jellemzéséhez, az feltétlenül idézi Zweiget is - így Brigitte Hamann, amikor Hitler korai éveinek helyszínét mutatja be.', 'Stefan Zweig', 2008, '9789630781756'),
('A fogadás - 18 dráma', (SELECT id FROM categories WHERE name = 'Irodalom'), 'Ameddig eszemnél leszek, mindig azt fogom vallani, hogy nincsenek következmények nélküli tettek. Arról is mindig meg leszek győződve, hogy ez az egyetlen termékeny dramaturgiai alapállás. De persze nincs olyan termékeny alapállás, amely garantálná bármely műfajban a művészi sikert.', 'Eörsi István', 2004, '9789639539556');