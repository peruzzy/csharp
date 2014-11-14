using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiSPrviTest
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U razvoju GISa tradicionalno se koriste tri modela baze podataka: hijerarhijski, mrežni i relacioni"); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Postoje 4 osnovne komponente prostornih podataka: Geometrija, Atributi, Ponašanje i Topologija.");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geometrija predstavlja geometrijske oblike (tačke, linije ili poligoni) koji se odnose na lokacije iz realnog sveta. \nAtributi su opisne karakteristike geografskih podataka. \n Topologija se odnosi na prostorne relacije. \nPonašanje znači da geografski oblici omogućavaju editovanje, pokazivanje na displeju ili mogućnost da se podaci analiziraju,što zavisi od želja korisnika");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eksplicitni geografski podaci odnose se na geografsku širinu I dužinu. Implicitni geografski podaci mogu da se odnose na adresu, poštanski kod, naziv puta, itd.");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lokacijski servisi – Location Based Services (LBS) omogućavaju korisnicima da na osnovu pozicije na kojoj se nalaze, na svom mobilnom uređaju dobijaju informacije o objektivam ili osobinama ili im omogućavaju da učestvuju u nekoj od virtuelnih igara u realnom vremenu");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tačke, linije i poligoni.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relacioni model predstavlja skup utvrđenih relacija (entiteta) definisanih u nekoj složenoj oblasti. Osnovni elemenat je relaciona tabela u koju se unose svi podaci. Tabele su međusobno povezane realcijama čineći jednu logičku celinu. Nad elementima takve tabele mogu se vršiti razne operacije kao I nad skupovima. Tabela ne sme da zavisi od promene položaja kolone ili reda u odnosu na originalnu poziciju. Ne smeju da postoje dvostruki redovi, kao I kolone sa višestrukim vrednostima. Pri tome, u svakom trenutku moraju da budu dozvoljene matematičke operacije nad podacima.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rasterska baza podataka sadrži koordinate svakog piksela bilo u uglu, bilo u centralnom delu. Svaka ćelija ili piksel sadrži diskretne podatke o atributima koji ih karakterišu. Rezolucija rasterskih podataka zavisi od veličine piksela I mreže I može da varira od cm do više km. rasterski GIS memoriše različite informacije kao što su pošumljenos, tip tla, korišćenje zemljišta, podaci o vlažnosti ili neki drugi podaci iz različitih slojeva. Rasterski podaci zahtevaju kraće vreme za obradu nego vektorski podaci ali okupiraju veći memorijski prostor. Kod vektorskog modela podataka kada se jednom unesu tačke I formiraju geometrijske linije, mora da se izradi njihova topologija. Ovo u sebi uključuje izračunavanje I kodovanje relacija između tačaka, linija I područja. Ove informacije mogu automatski da se koduju u tabele koje sadrže informacije iz baze podataka.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prednosti rasterskog pristupa su sledeće: Mogućnost izdvajanja informacija direktno iz digitalnih slika ili fotografija.\nDobra osobina podataka u rasterskom obliku je što mogu biti komprimovani, što znatno redukuje potreban memorijski prostor za smeštanje podataka. \nSusedne lokacije mogu lako da se analiziraju.\n Algoritmi njihove obrade su jednostavniji nego kod vektora.");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prednosti: \nKod vektorskog pristupa moguće je organizovati karte u više slojeva, dok je to kod rastera gotovo nemoguće. \nVektorski podaci pružaju više informacija, jer su povezani sa bazom podataka gde su smešteni i drugi podaci o objektima. \nPrednost vektora je manji memorijski prostor zato što pikseli ne moraju da se memorišu u nekom određenom području. \nNedostatak vektora je što su: Algoritmi za obradu složeni. \nVektorizacija skeniranih podataka(npr.satelitske slike) traži veću računarsku snagu.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Akvizicija je prikupljane prostornih podataka za potrebe GIS-a.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Neposredne ili primarne metode koje se odnose na razne vrste prikupljanja podataka za topografske-kartografske potrebe: \nTerenski premer,\nFotogrametrija,\nDaljinska detekcija \nPosredne ili sekundarne metode prikupljanja podataka koji su u nekoj formi već obrađeni(katastarsko-topografski planovi i karte, tematske karte, statistika). Tu spadaju sve metode digitalizacije.");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U metode daljinskog premera spadaju: \nTahimetrija, \nOrtogonalna metoda, \nGPS premer."); 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ova metoda se zasniva na kombinaciji merenja horizontalnih i vertikalnih uglova i merenju dužina. Instrumentalnu osnovu čini posebno konstruisan geodetski instrument - tahimetar ili instrument sa razdvojenim funkcijama za merenje uglova i elektronsko merenje dužina, a u najnovije vreme tahimetrijska metoda se oslanja na integrisane geodetske sisteme za 3D terenska određivanja - totalne stanice.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GPS (Global Positioning System) – tehnologija sistema za globalno pozicioniranje. Primena ove tehnologije u premeru se zasniva na određivanju vektora između merene i neke druge poznate tačke. Instrumentalnu osnovu čini Real-Time Kinematic (RTK) sistem, koji se sastoji iz jednog statičnog GPS prijemnika - baze, jednog ili više pokretnih GPS prijemnika – rovera, odgovarajućeg broja radio modema i pratećeg hardvera i softvera za obradu primljenih satelitskih signala u realnom vremenu i registrovanje izmerenih vrednosti.");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ortogonalna metoda se zasniva na ortogonalnom merenju detaljnih tačaka sa linije koju formiraju poznate tačke. Zahvaljujući tome, moguće je sračunati koordinate merenih tačaka. Primena je u katastru, za snimanje gusto izgrađenih delova naselja u krupnoj razmeri.");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fotogrametrija i daljinska detekcija omogućavaju kontinuirano registrovanje stanja većih teritorija i igraju veoma značajnu ulogu u GIS-u. Registrovanje stanja – snimanje, obavlja se praktično jednovremeno i indirektno. Merenja se ne obavljaju na samim objektima u prostoru, već na snimcima. Svakako da je sa aspekta GIS-a najznačajnija aerofotogrametrija - oblast primene fotogrametrije koja je i do sada imala veliki značaj za topografsko i tematsko kartografisanje kako u krupnorazmernim (1:500 – 1:10.000), tako i u sitnorazmernim primenama (1:10.000 – 1:50.000).");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Metode za digitalno modeliranje terena (DMT):Direktno merenje izohipse\nMerenje karakterističnih visinskih tačaka i prekidnih linija Dinamičko profilisanje merenja rastera\nProgresivno odmeravanje\nPostupci digitalne obrade slika i automatskog generisanja digitalnog modela visina.");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Postupak definisanja pozicije naziva se georeferenciranje, odnosno svakom entitetu se dodeljuju koordinate iz odabranog koordinatnog sistema.");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Datum definiše veličinu i oblik zemljinog elpsoida, kao I koordinatni početak i orijentaciju u odnosu na Zemlju.");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entitet podrazumeva jedinicu osmatranja. Entiteti su fizički objekti ili pojave koje imaju svoje atribute.");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atributi su opisne karakteristike geografskih podataka.");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geografska dužina - Longitude \nGeografska širina - Lattitude. ");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lokacijski servisi se mogu klasifikovati na reaktivne (sinhrone) i proaktivne (asinhrone).");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Korisnički uređaj, bežična mreža, server aplikacija, server podataka.");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GPS (Global Positioning System), FLT (Forward Link Trilateration), OTD, EOTD.");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Global Positioning System (GPS) je za sada zvanično jedini potpuno funkcionalan sistem za određivanje pozicije korisnika na bilo kojoj tački na planeti. Korišćenjem konstelacije od 24 satelita koji emituju specijalno kodovane radio signale, a koje korisnik može da obradi pomoću GPS prijemnika proračunava se njegova tačna pozicija u koordinatnom sistemu geografske dužine, širine i nadmorske visine. Pored proračunavanja pozicije, moguće je dobiti i informaciju o brzini kretanja nosioca prijemnika.");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RFID, Bluetooth, UWB, WLAN. ");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RFID je skraćenica za Radio Frequency Identification, ili u slobodnom prevodu – identifikacija pomoću radio talasa. RFID predstavlja bilo koji sistem identifikacije u kome električni uređaj koristi radio talase ili promene magnetnog polja za komunikaciju.");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dve najvažnije komponente RFID sistema su:\n   • Tag, koji je identifikacioni uređaj prikačen na predmet koji želimo da pratimo,\n  • Čitač, odnosno, uređaj koji prepoznaje prisustvo RFID tagova i čita informacije sačuvane na njemu. Čitač potom može da informiše neki drugi sistem o prisustvu tagovanog predmeta.");
        }

      
    }
}
