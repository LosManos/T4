// conn string=Data Source=.\mssqlserver2012;Initial Catalog=StorEj_QA;Integrated Security=SSPI;

namespace MyAutomagicNamespace{

	public class Alarm{
		public int AlarmID{get;set;}
		public int ArendeID{get;set;}
		public int GruppID{get;set;}
		public datetime Start{get;set;}
		public datetime Stopp{get;set;}
		public datetime SignaleratTid{get;set;}
	}
	public class RelOmradeAnvandare{
		public int ID{get;set;}
		public int AnvandareId{get;set;}
		public int OmradeId{get;set;}
	}
	public class Import_JmfHyresgast{
		public int HyresgastID{get;set;}
		public int HyresgastattributID{get;set;}
		public int BorIOmradeID{get;set;}
		public Bolag_Forkortning Bostadsbolag{get;set;}
		public Hyresgast_Lokaltyp Lokaltyp{get;set;}
		public Hyresgast_Kontraktsnummer Kontraktsnummer{get;set;}
		public Hyresgast_Namn Namn{get;set;}
		public Hyresgast_Adress Adress{get;set;}
		public Hyresgast_Vaning Vaning{get;set;}
		public Hyresgast_Adresstillagg Adresstillagg{get;set;}
		public Hyresgast_Telefonnummer Tel{get;set;}
		public Hyresgast_Fodelsear Fodelsear{get;set;}
		public Hyresgast_Portkod Portkod{get;set;}
		public Omrade_Titel Omrade{get;set;}
		public Hyresgast_Namn NamnAndrahandshyresgast{get;set;}
		public Hyresgast_Namn NamnNyttjare{get;set;}
		public Hyresgast_Telefonnummer TelAndrahandshyresgast{get;set;}
		public Hyresgast_Atgardskod Atgardskod{get;set;}
		public int BatchID{get;set;}
		public bit Hittad{get;set;}
		public int JmfID{get;set;}
	}
	public class Import_FranTxt{
		public int ImportID{get;set;}
		public int BatchID{get;set;}
		public Bolag_Forkortning Bostadsbolag{get;set;}
		public Hyresgast_Lokaltyp Lokaltyp{get;set;}
		public Hyresgast_Kontraktsnummer Kontraktsnummer{get;set;}
		public Hyresgast_Namn Namn{get;set;}
		public Hyresgast_Adress Adress{get;set;}
		public Hyresgast_Vaning Vaning{get;set;}
		public Hyresgast_Telefonnummer Tel{get;set;}
		public Hyresgast_Fodelsear Fodelsear{get;set;}
		public Omrade_Titel Omrade{get;set;}
		public Hyresgast_Namn NamnAndrahandshyresgast{get;set;}
		public Hyresgast_Namn NamnNyttjare{get;set;}
		public Hyresgast_Telefonnummer TelAndrahandshyresgast{get;set;}
		public Hyresgast_Adresstillagg AdressTillagg{get;set;}
		public Hyresgast_Portkod Portkod{get;set;}
	}
	public class Import_Batch{
		public int BatchID{get;set;}
		public int AnvandareID{get;set;}
		public datetime ImportDatum{get;set;}
		public bit ArImporterad{get;set;}
	}
	public class Omrade{
		public int OmradeID{get;set;}
		public int DistriktID{get;set;}
		public Omrade_Titel Titel{get;set;}
	}
	public class AkutArende{
		public int AkutArendeID{get;set;}
		public int ArendeID{get;set;}
		public int RapporteradStorningstypID{get;set;}
		public int IakttagenStorningstypID{get;set;}
		public Arende_Noteringar Beskrivning{get;set;}
		public bit Anmalare_EjKontakt{get;set;}
		public int Anmalare_HyresgastID{get;set;}
		public Hyresgast_Namn Anmalare_Namn{get;set;}
		public Hyresgast_Adress Anmalare_Gatuadress{get;set;}
		public int Anmalare_BorIOmradeID{get;set;}
		public Omrade_Titel Anmalare_BorIOmrade_Titel{get;set;}
		public Hyresgast_Kontraktsnummer Anmalare_Kontraktsnummer{get;set;}
		public Hyresgast_Telefonnummer Anmalare_Tel{get;set;}
		public int Storande_HyresgastID{get;set;}
		public Hyresgast_Namn Storande_Namn{get;set;}
		public Hyresgast_Adress Storande_Gatuadress{get;set;}
		public int Storande_BorIOmradeID{get;set;}
		public Omrade_Titel Storande_BorIOmrade_Titel{get;set;}
		public Hyresgast_Kontraktsnummer Storande_Kontraktsnummer{get;set;}
		public Hyresgast_Telefonnummer Storande_Tel{get;set;}
	}
	public class Grupp{
		public int GruppID{get;set;}
		public Titel Titel{get;set;}
		public bit AttRadera{get;set;}
	}
	public class Anvandare2{
		public int AnvandareID{get;set;}
		public int TillhorGruppID{get;set;}
		public int BolagID{get;set;}
		public Anvandare_Namn Namn{get;set;}
		public varchar Anvandarnamn{get;set;}
		public varchar Losenord{get;set;}
		public Anvandare_Epostadress Epostadress{get;set;}
		public bit Prenumerera{get;set;}
		public int AntalMisslyckadePaloggningar{get;set;}
		public datetime SenastePaloggningsforsok{get;set;}
		public bit Last{get;set;}
		public datetime LosenordSkapad{get;set;}
	}
	public class Arendestatus{
		public int ArendestatusID{get;set;}
		public Titel Titel{get;set;}
		public Beskrivning Beskrivning{get;set;}
	}
	public class Import_JmfOmrade{
		public int JmfID{get;set;}
		public int OmradeID{get;set;}
		public int DistriktID{get;set;}
		public Omrade_Titel Titel{get;set;}
		public int BatchID{get;set;}
		public bit Hittad{get;set;}
	}
	public class Logg{
		public int LoggID{get;set;}
		public varchar AnvandareNamn{get;set;}
		public varchar Namn{get;set;}
		public varchar Beskrivning{get;set;}
		public varchar Data{get;set;}
		public varchar Kommentar{get;set;}
		public datetime Skapad{get;set;}
	}
	public class Import_Omrade{
		public int Import_OmradeID{get;set;}
		public int OmradeID{get;set;}
		public int DistriktID{get;set;}
		public Omrade_Titel Titel{get;set;}
		public int BatchID{get;set;}
		public int ImportID{get;set;}
	}
	public class Uppdragstyp{
		public int UppdragstypID{get;set;}
		public Titel Titel{get;set;}
	}
	public class InstallningDatatyp{
		public int InstallningDatatypID{get;set;}
		public Titel Titel{get;set;}
	}
	public class Bestallning{
		public int BestallningID{get;set;}
		public int BolagID{get;set;}
		public int ReferenspersonID{get;set;}
		public int AnvandareID{get;set;}
		public varchar Beskrivning{get;set;}
		public datetime Start{get;set;}
		public datetime Slut{get;set;}
		public varchar ReferenspersonNamn{get;set;}
		public varchar ReferenspersonTelefonnummer{get;set;}
		public varchar ReferenspersonKommentar{get;set;}
		public varchar TillsynshyresgastLagenhetsnummer{get;set;}
		public varchar TillsynshyresgastNamn{get;set;}
		public varchar TillsynshyresgastAdress{get;set;}
		public Omrade_Titel TillsynshyresgastOmrade{get;set;}
		public varchar TillsynshyresgastPortkod{get;set;}
		public varchar TillsynshyresgastTelefonnummer{get;set;}
		public varchar TillsynshyresgastKommentar{get;set;}
		public int TillsynshyresgastID{get;set;}
		public int KontaktPersonID{get;set;}
	}
	public class Storningstyp{
		public int StorningstypID{get;set;}
		public Titel Titel{get;set;}
		public Beskrivning Beskrivning{get;set;}
		public bit RapporteradTyp{get;set;}
		public bit IakttagenTyp{get;set;}
	}
	public class RelRollAnvandare{
		public int ID{get;set;}
		public int RollID{get;set;}
		public int AnvandareID{get;set;}
	}
	public class Roll{
		public int RollID{get;set;}
		public Titel Titel{get;set;}
		public varchar Beskrivning{get;set;}
		public bit Personal{get;set;}
		public bit ArSystem{get;set;}
	}
	public class dtproperties{
		public int id{get;set;}
		public int objectid{get;set;}
		public varchar property{get;set;}
		public varchar value{get;set;}
		public nvarchar uvalue{get;set;}
		public image lvalue{get;set;}
		public int version{get;set;}
	}
	public class Installning{
		public int InstallningID{get;set;}
		public Installning_Nyckel InstallningNyckel{get;set;}
		public int DatatypID{get;set;}
		public varchar Titel{get;set;}
		public Installning_Varde Varde{get;set;}
		public Installning_Kommentar Kommentar{get;set;}
	}
	public class Tillsynsplanering{
		public int TillsynsplaneringID{get;set;}
		public int BestallningID{get;set;}
		public bit OmplaneringTillaten{get;set;}
		public bit Dag{get;set;}
		public datetime Start{get;set;}
		public datetime Slut{get;set;}
		public text Kommentar{get;set;}
	}
	public class Hyresgastattribut{
		public int HyresgastattributID{get;set;}
		public nvarchar Portkod{get;set;}
	}
	public class Meddelande{
		public int MeddelandeID{get;set;}
		public datetime DatumTid{get;set;}
		public int ArendeID{get;set;}
		public int Sandare_AnvandareID{get;set;}
		public int Sandare_GruppID{get;set;}
		public int Sandare_RollID{get;set;}
		public int Mottagare_GruppID{get;set;}
		public int Mottagare_RollID{get;set;}
		public Meddelande_Meddelande Meddelande{get;set;}
	}
	public class Anvandare_Old{
		public int AnvandareID{get;set;}
		public int TillhorGruppID{get;set;}
		public int BolagID{get;set;}
		public Anvandare_Namn Namn{get;set;}
		public varchar Anvandarnamn{get;set;}
		public varchar Losenord{get;set;}
		public Anvandare_Epostadress Epostadress{get;set;}
		public bit Prenumerera{get;set;}
		public int AntalMisslyckadePaloggningar{get;set;}
		public datetime SenastePaloggninsforsok{get;set;}
		public bit Last{get;set;}
	}
	public class Bolag{
		public int BolagID{get;set;}
		public Bolag_Forkortning Forkortning{get;set;}
		public Titel Namn{get;set;}
		public bit MatchaNamnVidImport{get;set;}
		public bit Offentlig{get;set;}
	}
	public class Arende{
		public int ArendeID{get;set;}
		public int DelegeratTillGruppID{get;set;}
		public int ArendestatusID{get;set;}
		public int FakturerandeBolagID{get;set;}
		public int UppdragstypID{get;set;}
		public Arende_Noteringar Iakttagelser{get;set;}
		public Arende_Tidloggkommentar Tidloggkommentar{get;set;}
		public int LastAvAnvandareID{get;set;}
		public datetime LastDatumTid{get;set;}
		public Arende_SigneratAv SigneratAv{get;set;}
		public int SkapatAnvandareID{get;set;}
		public datetime SkapatDatumtid{get;set;}
		public int RedigeratAnvandareID{get;set;}
		public datetime RedigeratDatumtid{get;set;}
		public int Prio{get;set;}
	}
	public class Hyresgast{
		public int HyresgastID{get;set;}
		public int HyresgastattributID{get;set;}
		public int BorIOmradeID{get;set;}
		public Bolag_Forkortning Bostadsbolag{get;set;}
		public Hyresgast_Lokaltyp Lokaltyp{get;set;}
		public Hyresgast_Kontraktsnummer Kontraktsnummer{get;set;}
		public Hyresgast_Namn Namn{get;set;}
		public Hyresgast_Adress Adress{get;set;}
		public Hyresgast_Vaning Vaning{get;set;}
		public Hyresgast_Adresstillagg Adresstillagg{get;set;}
		public Hyresgast_Telefonnummer Tel{get;set;}
		public Hyresgast_Fodelsear Fodelsear{get;set;}
		public Hyresgast_Portkod Portkod{get;set;}
		public Omrade_Titel Omrade{get;set;}
		public Hyresgast_Namn NamnAndrahandshyresgast{get;set;}
		public Hyresgast_Namn NamnNyttjare{get;set;}
		public Hyresgast_Telefonnummer TelAndrahandshyresgast{get;set;}
		public Hyresgast_Atgardskod Atgardskod{get;set;}
	}
	public class Arendelogg{
		public int ArendeloggID{get;set;}
		public int ArendeID{get;set;}
		public int AnvandareID{get;set;}
		public datetime Datumtid{get;set;}
		public Arendelogg_Meddelande Meddelande{get;set;}
		public Anvandare_Anvandarnamn Anvandare_Anvandarnamn{get;set;}
		public Anvandare_Namn Anvandare_Namn{get;set;}
	}
	public class Tidlogg{
		public int TidloggID{get;set;}
		public int ArendeID{get;set;}
		public int ArendestatusIDFran{get;set;}
		public int ArendestatusIDTill{get;set;}
		public datetime ArendestatusAndrad{get;set;}
		public datetime ArendestatusAndradOriginal{get;set;}
		public int AndrandeAnvandareID{get;set;}
		public int SkapatAnvandareID{get;set;}
		public datetime SkapatDatumtid{get;set;}
		public int RedigeratAnvandareID{get;set;}
		public datetime RedigeratDatumtid{get;set;}
	}
	public class Tillsynsarende{
		public int TillsynsarendeID{get;set;}
		public int ArendeID{get;set;}
		public int BestallningID{get;set;}
		public int TillsynsplaneringID{get;set;}
		public datetime PlaneratUtforandeStart{get;set;}
		public datetime PlaneratUtforandeSlut{get;set;}
		public bit OmplaneringTillaten{get;set;}
		public bit Dag{get;set;}
	}
	public class Distrikt{
		public int DistriktID{get;set;}
		public int BolagID{get;set;}
		public Titel Titel{get;set;}
	}
	public class Import_Hyresgast{
		public int Import_HyresgastID{get;set;}
		public int HyresgastID{get;set;}
		public int HyresgastattributID{get;set;}
		public int BorIOmradeID{get;set;}
		public Bolag_Forkortning Bostadsbolag{get;set;}
		public Hyresgast_Lokaltyp Lokaltyp{get;set;}
		public Hyresgast_Kontraktsnummer Kontraktsnummer{get;set;}
		public Hyresgast_Namn Namn{get;set;}
		public Hyresgast_Adress Adress{get;set;}
		public Hyresgast_Vaning Vaning{get;set;}
		public Hyresgast_Adresstillagg Adresstillagg{get;set;}
		public Hyresgast_Telefonnummer Tel{get;set;}
		public Hyresgast_Fodelsear Fodelsear{get;set;}
		public Hyresgast_Portkod Portkod{get;set;}
		public Omrade_Titel Omrade{get;set;}
		public Hyresgast_Namn NamnAndrahandshyresgast{get;set;}
		public Hyresgast_Namn NamnNyttjare{get;set;}
		public Hyresgast_Telefonnummer TelAndrahandshyresgast{get;set;}
		public Hyresgast_Atgardskod Atgardskod{get;set;}
		public int BatchID{get;set;}
		public int ImportID{get;set;}
	}
}
