using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Tracker.Models
{
    public class Covid19IdistrictModel
    {
        public Kerala Kerala { get; set; }
        public Delhi Delhi { get; set; }
        public Telangana Telangana { get; set; }
        public Rajasthan Rajasthan { get; set; }
        public Haryana Haryana { get; set; }
        public UttarPradesh UttarPradesh { get; set; }
        public Ladakh Ladakh { get; set; }
        public TamilNadu TamilNadu { get; set; }
        public JammuAndKashmir JammuKashmir { get; set; }
        public Karnataka Karnataka { get; set; }
        public Maharashtra Maharashtra { get; set; }
        public Punjab Punjab { get; set; }
        public AndhraPradesh AndhraPradesh { get; set; }
        public Uttarakhand Uttarakhand { get; set; }
        public Odisha Odisha { get; set; }
        public Puducherry Puducherry { get; set; }
        public WestBengal WestBengal { get; set; }
        public Chandigarh Chandigarh { get; set; }
        public Chhattisgarh Chhattisgarh { get; set; }
        public Gujarat2 Gujarat { get; set; }
        public HimachalPradesh HimachalPradesh { get; set; }
        public MadhyaPradesh MadhyaPradesh { get; set; }
        public Bihar Bihar { get; set; }
        public Manipur Manipur { get; set; }
        public Mizoram Mizoram { get; set; }
        public Goa Goa { get; set; }
        public AndamanAndNicobarIslands NicobarIslands { get; set; }
        public Jharkhand Jharkhand { get; set; }
        public Assam Assam { get; set; }
        public ArunachalPradesh ArunachalPradesh { get; set; }
    }
    public class Thrissur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta delta { get; set; }
    }

    public class Delta2
    {
        public int confirmed { get; set; }
    }

    public class Alappuzha
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta2 delta { get; set; }
    }

    public class Delta3
    {
        public int confirmed { get; set; }
    }

    public class Kasaragod
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta3 delta { get; set; }
    }

    public class Delta4
    {
        public int confirmed { get; set; }
    }

    public class Pathanamthitta
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta4 delta { get; set; }
    }

    public class Delta5
    {
        public int confirmed { get; set; }
    }

    public class Kannur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta5 delta { get; set; }
    }

    public class Delta6
    {
        public int confirmed { get; set; }
    }

    public class Ernakulam
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta6 delta { get; set; }
    }

    public class Delta7
    {
        public int confirmed { get; set; }
    }

    public class Kottayam
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta7 delta { get; set; }
    }

    public class Delta8
    {
        public int confirmed { get; set; }
    }

    public class Thiruvananthapuram
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta8 delta { get; set; }
    }

    public class Delta9
    {
        public int confirmed { get; set; }
    }

    public class Idukki
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta9 delta { get; set; }
    }

    public class Delta10
    {
        public int confirmed { get; set; }
    }

    public class Malappuram
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta10 delta { get; set; }
    }

    public class Delta11
    {
        public int confirmed { get; set; }
    }

    public class Kozhikode
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta11 delta { get; set; }
    }

    public class Delta12
    {
        public int confirmed { get; set; }
    }

    public class Palakkad
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta12 delta { get; set; }
    }

    public class Delta13
    {
        public int confirmed { get; set; }
    }

    public class Wayanad
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta13 delta { get; set; }
    }

    public class Delta14
    {
        public int confirmed { get; set; }
    }

    public class Kollam
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta14 delta { get; set; }
    }

    public class DistrictData
    {
        public Thrissur Thrissur { get; set; }
        public Alappuzha Alappuzha { get; set; }
        public Kasaragod Kasaragod { get; set; }
        public Pathanamthitta Pathanamthitta { get; set; }
        public Kannur Kannur { get; set; }
        public Ernakulam Ernakulam { get; set; }
        public Kottayam Kottayam { get; set; }
        public Thiruvananthapuram Thiruvananthapuram { get; set; }
        public Idukki Idukki { get; set; }
        public Malappuram Malappuram { get; set; }
        public Kozhikode Kozhikode { get; set; }
        public Palakkad Palakkad { get; set; }
        public Wayanad Wayanad { get; set; }
        public Kollam Kollam { get; set; }
    }

    public class Kerala
    {
        public DistrictData districtData { get; set; }
    }

    public class Delta15
    {
        public int confirmed { get; set; }
    }

    public class EastDelhi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta15 delta { get; set; }
    }

    public class Delta16
    {
        public int confirmed { get; set; }
    }

    public class SouthWestDelhi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta16 delta { get; set; }
    }

    public class Delta17
    {
        public int confirmed { get; set; }
    }

    public class WestDelhi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta17 delta { get; set; }
    }

    public class Delta18
    {
        public int confirmed { get; set; }
    }

    public class NorthDelhi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta18 delta { get; set; }
    }

    public class Delta19
    {
        public int confirmed { get; set; }
    }

    public class NewDelhi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta19 delta { get; set; }
    }

    public class Delta20
    {
        public int confirmed { get; set; }
    }

    public class SouthDelhi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta20 delta { get; set; }
    }

    public class Delta21
    {
        public int confirmed { get; set; }
    }

    public class NorthEastDelhi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta21 delta { get; set; }
    }

    public class Delta22
    {
        public int confirmed { get; set; }
    }

    public class NorthWestDelhi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta22 delta { get; set; }
    }

    public class Delta23
    {
        public int confirmed { get; set; }
    }

    public class Unknown
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta23 delta { get; set; }
    }

    public class DistrictData2
    {
        public EastDelhi EastDelhi { get; set; }
        public SouthWestDelhi SouthWestDelhi { get; set; }
        public WestDelhi WestDelhi { get; set; }
        public NorthDelhi NorthDelhi { get; set; }
        public NewDelhi NewDelhi { get; set; }
        public SouthDelhi SouthDelhi { get; set; }
        public NorthEastDelhi NorthEastDelhi { get; set; }
        public NorthWestDelhi NorthWestDelhi { get; set; }
        public Unknown Unknown { get; set; }
    }

    public class Delhi
    {
        public DistrictData2 districtData { get; set; }
    }

    public class Delta24
    {
        public int confirmed { get; set; }
    }

    public class Hyderabad
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta24 delta { get; set; }
    }

    public class Delta25
    {
        public int confirmed { get; set; }
    }

    public class Karimnagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta25 delta { get; set; }
    }

    public class Delta26
    {
        public int confirmed { get; set; }
    }

    public class BhadradriKothagudem
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta26 delta { get; set; }
    }

    public class Delta27
    {
        public int confirmed { get; set; }
    }

    public class RangaReddy
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta27 delta { get; set; }
    }

    public class Delta28
    {
        public int confirmed { get; set; }
    }

    public class MedchalMalkajgiri
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta28 delta { get; set; }
    }

    public class Delta29
    {
        public int confirmed { get; set; }
    }

    public class Unknown2
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta29 delta { get; set; }
    }

    public class DistrictData3
    {
        public Hyderabad Hyderabad { get; set; }
        public Karimnagar Karimnagar { get; set; }
        public BhadradriKothagudem BhadradriKothagudem { get; set; }
        public RangaReddy RangaReddy { get; set; }
        public MedchalMalkajgiri MedchalMalkajgiri { get; set; }
        public Unknown2 Unknown { get; set; }
    }

    public class Telangana
    {
        public DistrictData3 districtData { get; set; }
    }

    public class Delta30
    {
        public int confirmed { get; set; }
    }

    public class Jaipur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta30 delta { get; set; }
    }

    public class Delta31
    {
        public int confirmed { get; set; }
    }

    public class Jhunjhunu
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta31 delta { get; set; }
    }

    public class Delta32
    {
        public int confirmed { get; set; }
    }

    public class Bhilwara
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta32 delta { get; set; }
    }

    public class Delta33
    {
        public int confirmed { get; set; }
    }

    public class Jodhpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta33 delta { get; set; }
    }

    public class Delta34
    {
        public int confirmed { get; set; }
    }

    public class Pali
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta34 delta { get; set; }
    }

    public class Delta35
    {
        public int confirmed { get; set; }
    }

    public class Sikar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta35 delta { get; set; }
    }

    public class Delta36
    {
        public int confirmed { get; set; }
    }

    public class Pratapgarh
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta36 delta { get; set; }
    }

    public class Delta37
    {
        public int confirmed { get; set; }
    }

    public class Dungarpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta37 delta { get; set; }
    }

    public class Delta38
    {
        public int confirmed { get; set; }
    }

    public class Churu
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta38 delta { get; set; }
    }

    public class Delta39
    {
        public int confirmed { get; set; }
    }

    public class Ajmer
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta39 delta { get; set; }
    }

    public class Delta40
    {
        public int confirmed { get; set; }
    }

    public class Evacuees
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta40 delta { get; set; }
    }

    public class Delta41
    {
        public int confirmed { get; set; }
    }

    public class Alwar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta41 delta { get; set; }
    }

    public class Delta42
    {
        public int confirmed { get; set; }
    }

    public class Tonk
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta42 delta { get; set; }
    }

    public class Delta43
    {
        public int confirmed { get; set; }
    }

    public class Dhaulpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta43 delta { get; set; }
    }

    public class Delta44
    {
        public int confirmed { get; set; }
    }

    public class Udaipur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta44 delta { get; set; }
    }

    public class Delta45
    {
        public int confirmed { get; set; }
    }

    public class Bharatpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta45 delta { get; set; }
    }

    public class Delta46
    {
        public int confirmed { get; set; }
    }

    public class Bikaner
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta46 delta { get; set; }
    }

    public class Delta47
    {
        public int confirmed { get; set; }
    }

    public class Dausa
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta47 delta { get; set; }
    }

    public class Delta48
    {
        public int confirmed { get; set; }
    }

    public class Banswara
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta48 delta { get; set; }
    }

    public class Delta49
    {
        public int confirmed { get; set; }
    }

    public class Karauli
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta49 delta { get; set; }
    }

    public class Delta50
    {
        public int confirmed { get; set; }
    }

    public class Nagaur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta50 delta { get; set; }
    }

    public class DistrictData4
    {
        public Jaipur Jaipur { get; set; }
        public Jhunjhunu Jhunjhunu { get; set; }
        public Bhilwara Bhilwara { get; set; }
        public Jodhpur Jodhpur { get; set; }
        public Pali Pali { get; set; }
        public Sikar Sikar { get; set; }
        public Pratapgarh Pratapgarh { get; set; }
        public Dungarpur Dungarpur { get; set; }
        public Churu Churu { get; set; }
        public Ajmer Ajmer { get; set; }
        public Evacuees Evacuees { get; set; }
        public Alwar Alwar { get; set; }
        public Tonk Tonk { get; set; }
        public Dhaulpur Dhaulpur { get; set; }
        public Udaipur Udaipur { get; set; }
        public Bharatpur Bharatpur { get; set; }
        public Bikaner Bikaner { get; set; }
        public Dausa Dausa { get; set; }
        public Banswara Banswara { get; set; }
        public Karauli Karauli { get; set; }
        public Nagaur Nagaur { get; set; }
    }

    public class Rajasthan
    {
        public DistrictData4 districtData { get; set; }
    }

    public class Delta51
    {
        public int confirmed { get; set; }
    }

    public class Gurugram
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta51 delta { get; set; }
    }

    public class Delta52
    {
        public int confirmed { get; set; }
    }

    public class Faridabad
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta52 delta { get; set; }
    }

    public class Delta53
    {
        public int confirmed { get; set; }
    }

    public class Panipat
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta53 delta { get; set; }
    }

    public class Delta54
    {
        public int confirmed { get; set; }
    }

    public class Panchkula
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta54 delta { get; set; }
    }

    public class Delta55
    {
        public int confirmed { get; set; }
    }

    public class Sonipat
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta55 delta { get; set; }
    }

    public class Delta56
    {
        public int confirmed { get; set; }
    }

    public class Palwal
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta56 delta { get; set; }
    }

    public class Delta57
    {
        public int confirmed { get; set; }
    }

    public class Ambala
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta57 delta { get; set; }
    }

    public class Delta58
    {
        public int confirmed { get; set; }
    }

    public class Sirsa
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta58 delta { get; set; }
    }

    public class Delta59
    {
        public int confirmed { get; set; }
    }

    public class Hisar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta59 delta { get; set; }
    }

    public class Delta60
    {
        public int confirmed { get; set; }
    }

    public class Rohtak
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta60 delta { get; set; }
    }

    public class Delta61
    {
        public int confirmed { get; set; }
    }

    public class Nuh
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta61 delta { get; set; }
    }

    public class Delta62
    {
        public int confirmed { get; set; }
    }

    public class Karnal
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta62 delta { get; set; }
    }

    public class Delta63
    {
        public int confirmed { get; set; }
    }

    public class Bhiwani
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta63 delta { get; set; }
    }

    public class Delta64
    {
        public int confirmed { get; set; }
    }

    public class Kaithal
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta64 delta { get; set; }
    }

    public class Delta65
    {
        public int confirmed { get; set; }
    }

    public class Unknown3
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta65 delta { get; set; }
    }

    public class DistrictData5
    {
        public Gurugram Gurugram { get; set; }
        public Faridabad Faridabad { get; set; }
        public Panipat Panipat { get; set; }
        public Panchkula Panchkula { get; set; }
        public Sonipat Sonipat { get; set; }
        public Palwal Palwal { get; set; }
        public Ambala Ambala { get; set; }
        public Sirsa Sirsa { get; set; }
        public Hisar Hisar { get; set; }
        public Rohtak Rohtak { get; set; }
        public Nuh Nuh { get; set; }
        public Karnal Karnal { get; set; }
        public Bhiwani Bhiwani { get; set; }
        public Kaithal Kaithal { get; set; }
        public Unknown3 Unknown { get; set; }
    }

    public class Haryana
    {
        public DistrictData5 districtData { get; set; }
    }

    public class Delta66
    {
        public int confirmed { get; set; }
    }

    public class Agra
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta66 delta { get; set; }
    }

    public class Delta67
    {
        public int confirmed { get; set; }
    }

    public class Ghaziabad
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta67 delta { get; set; }
    }

    public class Delta68
    {
        public int confirmed { get; set; }
    }

    public class Lucknow
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta68 delta { get; set; }
    }

    public class Delta69
    {
        public int confirmed { get; set; }
    }

    public class GautamBuddhaNagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta69 delta { get; set; }
    }

    public class Delta70
    {
        public int confirmed { get; set; }
    }

    public class Moradabad
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta70 delta { get; set; }
    }

    public class Delta71
    {
        public int confirmed { get; set; }
    }

    public class Varanasi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta71 delta { get; set; }
    }

    public class Delta72
    {
        public int confirmed { get; set; }
    }

    public class KanpurNagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta72 delta { get; set; }
    }

    public class Delta73
    {
        public int confirmed { get; set; }
    }

    public class Pilibhit
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta73 delta { get; set; }
    }

    public class Delta74
    {
        public int confirmed { get; set; }
    }

    public class Jaunpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta74 delta { get; set; }
    }

    public class Delta75
    {
        public int confirmed { get; set; }
    }

    public class Baghpat
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta75 delta { get; set; }
    }

    public class Delta76
    {
        public int confirmed { get; set; }
    }

    public class Lakhimpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta76 delta { get; set; }
    }

    public class Delta77
    {
        public int confirmed { get; set; }
    }

    public class Shamli
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta77 delta { get; set; }
    }

    public class Delta78
    {
        public int confirmed { get; set; }
    }

    public class Meerut
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta78 delta { get; set; }
    }

    public class Delta79
    {
        public int confirmed { get; set; }
    }

    public class Bareilly
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta79 delta { get; set; }
    }

    public class Delta80
    {
        public int confirmed { get; set; }
    }

    public class Bulandshahr
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta80 delta { get; set; }
    }

    public class Delta81
    {
        public int confirmed { get; set; }
    }

    public class Basti
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta81 delta { get; set; }
    }

    public class Delta82
    {
        public int confirmed { get; set; }
    }

    public class Hardoi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta82 delta { get; set; }
    }

    public class Delta83
    {
        public int confirmed { get; set; }
    }

    public class Shahjahanpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta83 delta { get; set; }
    }

    public class Delta84
    {
        public int confirmed { get; set; }
    }

    public class Firozabad
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta84 delta { get; set; }
    }

    public class Delta85
    {
        public int confirmed { get; set; }
    }

    public class Azamgarh
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta85 delta { get; set; }
    }

    public class Delta86
    {
        public int confirmed { get; set; }
    }

    public class Saharanpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta86 delta { get; set; }
    }

    public class Delta87
    {
        public int confirmed { get; set; }
    }

    public class Pratapgarh2
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta87 delta { get; set; }
    }

    public class Delta88
    {
        public int confirmed { get; set; }
    }

    public class Hapur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta88 delta { get; set; }
    }

    public class Delta89
    {
        public int confirmed { get; set; }
    }

    public class Ghazipur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta89 delta { get; set; }
    }

    public class Delta90
    {
        public int confirmed { get; set; }
    }

    public class Banda
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta90 delta { get; set; }
    }

    public class Delta91
    {
        public int confirmed { get; set; }
    }

    public class Maharajganj
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta91 delta { get; set; }
    }

    public class Delta92
    {
        public int confirmed { get; set; }
    }

    public class Hatras
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta92 delta { get; set; }
    }

    public class Delta93
    {
        public int confirmed { get; set; }
    }

    public class Mirzapur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta93 delta { get; set; }
    }

    public class DistrictData6
    {
        public Agra Agra { get; set; }
        public Ghaziabad Ghaziabad { get; set; }
        public Lucknow Lucknow { get; set; }
        public GautamBuddhaNagar GautamBuddhaNagar { get; set; }
        public Moradabad Moradabad { get; set; }
        public Varanasi Varanasi { get; set; }
        public KanpurNagar KanpurNagar { get; set; }
        public Pilibhit Pilibhit { get; set; }
        public Jaunpur Jaunpur { get; set; }
        public Baghpat Baghpat { get; set; }
        public Lakhimpur Lakhimpur { get; set; }
        public Shamli Shamli { get; set; }
        public Meerut Meerut { get; set; }
        public Bareilly Bareilly { get; set; }
        public Bulandshahr Bulandshahr { get; set; }
        public Basti Basti { get; set; }
        public Hardoi Hardoi { get; set; }
        public Shahjahanpur Shahjahanpur { get; set; }
        public Firozabad Firozabad { get; set; }
        public Azamgarh Azamgarh { get; set; }
        public Saharanpur Saharanpur { get; set; }
        public Pratapgarh2 Pratapgarh { get; set; }
        public Hapur Hapur { get; set; }
        public Ghazipur Ghazipur { get; set; }
        public Banda Banda { get; set; }
        public Maharajganj Maharajganj { get; set; }
        public Hatras Hatras { get; set; }
        public Mirzapur Mirzapur { get; set; }
    }

    public class UttarPradesh
    {
        public DistrictData6 districtData { get; set; }
    }

    public class Delta94
    {
        public int confirmed { get; set; }
    }

    public class Leh
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta94 delta { get; set; }
    }

    public class Delta95
    {
        public int confirmed { get; set; }
    }

    public class Kargil
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta95 delta { get; set; }
    }

    public class DistrictData7
    {
        public Leh Leh { get; set; }
        public Kargil Kargil { get; set; }
    }

    public class Ladakh
    {
        public DistrictData7 districtData { get; set; }
    }

    public class Delta96
    {
        public int confirmed { get; set; }
    }

    public class Kancheepuram
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta96 delta { get; set; }
    }

    public class Delta97
    {
        public int confirmed { get; set; }
    }

    public class Chennai
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta97 delta { get; set; }
    }

    public class Delta98
    {
        public int confirmed { get; set; }
    }

    public class Erode
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta98 delta { get; set; }
    }

    public class Delta99
    {
        public int confirmed { get; set; }
    }

    public class Coimbatore
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta99 delta { get; set; }
    }

    public class Delta100
    {
        public int confirmed { get; set; }
    }

    public class Tirunelveli
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta100 delta { get; set; }
    }

    public class Delta101
    {
        public int confirmed { get; set; }
    }

    public class Tiruppur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta101 delta { get; set; }
    }

    public class Delta102
    {
        public int confirmed { get; set; }
    }

    public class Madurai
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta102 delta { get; set; }
    }

    public class Delta103
    {
        public int confirmed { get; set; }
    }

    public class Salem
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta103 delta { get; set; }
    }

    public class Delta104
    {
        public int confirmed { get; set; }
    }

    public class Vellore
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta104 delta { get; set; }
    }

    public class Delta105
    {
        public int confirmed { get; set; }
    }

    public class Tiruchirappalli
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta105 delta { get; set; }
    }

    public class Delta106
    {
        public int confirmed { get; set; }
    }

    public class Chengalpattu
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta106 delta { get; set; }
    }

    public class Delta107
    {
        public int confirmed { get; set; }
    }

    public class Thanjavur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta107 delta { get; set; }
    }

    public class Delta108
    {
        public int confirmed { get; set; }
    }

    public class Virudhunagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta108 delta { get; set; }
    }

    public class Delta109
    {
        public int confirmed { get; set; }
    }

    public class Karur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta109 delta { get; set; }
    }

    public class Delta110
    {
        public int confirmed { get; set; }
    }

    public class Tiruvannamalai
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta110 delta { get; set; }
    }

    public class Delta111
    {
        public int confirmed { get; set; }
    }

    public class Viluppuram
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta111 delta { get; set; }
    }

    public class Delta112
    {
        public int confirmed { get; set; }
    }

    public class Namakkal
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta112 delta { get; set; }
    }

    public class Delta113
    {
        public int confirmed { get; set; }
    }

    public class Kanniyakumari
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta113 delta { get; set; }
    }

    public class Delta114
    {
        public int confirmed { get; set; }
    }

    public class Thoothukkudi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta114 delta { get; set; }
    }

    public class Delta115
    {
        public int confirmed { get; set; }
    }

    public class Theni
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta115 delta { get; set; }
    }

    public class Delta116
    {
        public int confirmed { get; set; }
    }

    public class Dindigul
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta116 delta { get; set; }
    }

    public class Delta117
    {
        public int confirmed { get; set; }
    }

    public class Sivaganga
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta117 delta { get; set; }
    }

    public class Delta118
    {
        public int confirmed { get; set; }
    }

    public class Tirupathur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta118 delta { get; set; }
    }

    public class Delta119
    {
        public int confirmed { get; set; }
    }

    public class Thiruvarur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta119 delta { get; set; }
    }

    public class Delta120
    {
        public int confirmed { get; set; }
    }

    public class Ranipet
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta120 delta { get; set; }
    }

    public class Delta121
    {
        public int confirmed { get; set; }
    }

    public class Ramanathapuram
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta121 delta { get; set; }
    }

    public class Delta122
    {
        public int confirmed { get; set; }
    }

    public class Thiruvallur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta122 delta { get; set; }
    }

    public class Delta123
    {
        public int confirmed { get; set; }
    }

    public class Nagapattinam
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta123 delta { get; set; }
    }

    public class Delta124
    {
        public int confirmed { get; set; }
    }

    public class Cuddalore
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta124 delta { get; set; }
    }

    public class Delta125
    {
        public int confirmed { get; set; }
    }

    public class Kallakurichi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta125 delta { get; set; }
    }

    public class Delta126
    {
        public int confirmed { get; set; }
    }

    public class Perambalur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta126 delta { get; set; }
    }

    public class Delta127
    {
        public int confirmed { get; set; }
    }

    public class TheNilgiris
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta127 delta { get; set; }
    }

    public class DistrictData8
    {
        public Kancheepuram Kancheepuram { get; set; }
        public Chennai Chennai { get; set; }
        public Erode Erode { get; set; }
        public Coimbatore Coimbatore { get; set; }
        public Tirunelveli Tirunelveli { get; set; }
        public Tiruppur Tiruppur { get; set; }
        public Madurai Madurai { get; set; }
        public Salem Salem { get; set; }
        public Vellore Vellore { get; set; }
        public Tiruchirappalli Tiruchirappalli { get; set; }
        public Chengalpattu Chengalpattu { get; set; }
        public Thanjavur Thanjavur { get; set; }
        public Virudhunagar Virudhunagar { get; set; }
        public Karur Karur { get; set; }
        public Tiruvannamalai Tiruvannamalai { get; set; }
        public Viluppuram Viluppuram { get; set; }
        public Namakkal Namakkal { get; set; }
        public Kanniyakumari Kanniyakumari { get; set; }
        public Thoothukkudi Thoothukkudi { get; set; }
        public Theni Theni { get; set; }
        public Dindigul Dindigul { get; set; }
        public Sivaganga Sivaganga { get; set; }
        public Tirupathur Tirupathur { get; set; }
        public Thiruvarur Thiruvarur { get; set; }
        public Ranipet Ranipet { get; set; }
        public Ramanathapuram Ramanathapuram { get; set; }
        public Thiruvallur Thiruvallur { get; set; }
        public Nagapattinam Nagapattinam { get; set; }
        public Cuddalore Cuddalore { get; set; }
        public Kallakurichi Kallakurichi { get; set; }
        public Perambalur Perambalur { get; set; }
        public TheNilgiris TheNilgiris { get; set; }
    }

    public class TamilNadu
    {
        public DistrictData8 districtData { get; set; }
    }

    public class Delta128
    {
        public int confirmed { get; set; }
    }

    public class Jammu
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta128 delta { get; set; }
    }

    public class Delta129
    {
        public int confirmed { get; set; }
    }

    public class Srinagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta129 delta { get; set; }
    }

    public class Delta130
    {
        public int confirmed { get; set; }
    }

    public class Bandipore
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta130 delta { get; set; }
    }

    public class Delta131
    {
        public int confirmed { get; set; }
    }

    public class Unknown4
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta131 delta { get; set; }
    }

    public class Delta132
    {
        public int confirmed { get; set; }
    }

    public class Rajouri
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta132 delta { get; set; }
    }

    public class Delta133
    {
        public int confirmed { get; set; }
    }

    public class Badgam
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta133 delta { get; set; }
    }

    public class Delta134
    {
        public int confirmed { get; set; }
    }

    public class Baramula
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta134 delta { get; set; }
    }

    public class Delta135
    {
        public int confirmed { get; set; }
    }

    public class Shopian
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta135 delta { get; set; }
    }

    public class Delta136
    {
        public int confirmed { get; set; }
    }

    public class Kashmir
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta136 delta { get; set; }
    }

    public class Delta137
    {
        public int confirmed { get; set; }
    }

    public class Udhampur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta137 delta { get; set; }
    }

    public class DistrictData9
    {
        public Jammu Jammu { get; set; }
        public Srinagar Srinagar { get; set; }
        public Bandipore Bandipore { get; set; }
        public Unknown4 Unknown { get; set; }
        public Rajouri Rajouri { get; set; }
        public Badgam Badgam { get; set; }
        public Baramula Baramula { get; set; }
        public Shopian Shopian { get; set; }
        public Kashmir Kashmir { get; set; }
        public Udhampur Udhampur { get; set; }
    }

    public class JammuAndKashmir
    {
        public DistrictData9 districtData { get; set; }
    }

    public class Delta138
    {
        public int confirmed { get; set; }
    }

    public class Bengaluru
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta138 delta { get; set; }
    }

    public class Delta139
    {
        public int confirmed { get; set; }
    }

    public class Kalaburagi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta139 delta { get; set; }
    }

    public class Delta140
    {
        public int confirmed { get; set; }
    }

    public class Kodagu
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta140 delta { get; set; }
    }

    public class Delta141
    {
        public int confirmed { get; set; }
    }

    public class Chikkaballapura
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta141 delta { get; set; }
    }

    public class Delta142
    {
        public int confirmed { get; set; }
    }

    public class Mysuru
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta142 delta { get; set; }
    }

    public class Delta143
    {
        public int confirmed { get; set; }
    }

    public class Dharwad
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta143 delta { get; set; }
    }

    public class Delta144
    {
        public int confirmed { get; set; }
    }

    public class UttaraKannada
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta144 delta { get; set; }
    }

    public class Delta145
    {
        public int confirmed { get; set; }
    }

    public class DakshinaKannada
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta145 delta { get; set; }
    }

    public class Delta146
    {
        public int confirmed { get; set; }
    }

    public class Udupi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta146 delta { get; set; }
    }

    public class Delta147
    {
        public int confirmed { get; set; }
    }

    public class Chitradurga
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta147 delta { get; set; }
    }

    public class Delta148
    {
        public int confirmed { get; set; }
    }

    public class Tumakuru
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta148 delta { get; set; }
    }

    public class Delta149
    {
        public int confirmed { get; set; }
    }

    public class Davanagere
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta149 delta { get; set; }
    }

    public class Delta150
    {
        public int confirmed { get; set; }
    }

    public class Ballari
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta150 delta { get; set; }
    }

    public class Delta151
    {
        public int confirmed { get; set; }
    }

    public class Bidar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta151 delta { get; set; }
    }

    public class Delta152
    {
        public int confirmed { get; set; }
    }

    public class Bagalkote
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta152 delta { get; set; }
    }

    public class Delta153
    {
        public int confirmed { get; set; }
    }

    public class Belagavi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta153 delta { get; set; }
    }

    public class Delta154
    {
        public int confirmed { get; set; }
    }

    public class BengaluruRural
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta154 delta { get; set; }
    }

    public class DistrictData10
    {
        public Bengaluru Bengaluru { get; set; }
        public Kalaburagi Kalaburagi { get; set; }
        public Kodagu Kodagu { get; set; }
        public Chikkaballapura Chikkaballapura { get; set; }
        public Mysuru Mysuru { get; set; }
        public Dharwad Dharwad { get; set; }
        public UttaraKannada UttaraKannada { get; set; }
        public DakshinaKannada DakshinaKannada { get; set; }
        public Udupi Udupi { get; set; }
        public Chitradurga Chitradurga { get; set; }
        public Tumakuru Tumakuru { get; set; }
        public Davanagere Davanagere { get; set; }
        public Ballari Ballari { get; set; }
        public Bidar Bidar { get; set; }
        public Bagalkote Bagalkote { get; set; }
        public Belagavi Belagavi { get; set; }
        public BengaluruRural BengaluruRural { get; set; }
    }

    public class Karnataka
    {
        public DistrictData10 districtData { get; set; }
    }

    public class Delta155
    {
        public int confirmed { get; set; }
    }

    public class Pune
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta155 delta { get; set; }
    }

    public class Delta156
    {
        public int confirmed { get; set; }
    }

    public class Mumbai
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta156 delta { get; set; }
    }

    public class Delta157
    {
        public int confirmed { get; set; }
    }

    public class Nagpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta157 delta { get; set; }
    }

    public class Delta158
    {
        public int confirmed { get; set; }
    }

    public class Thane
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta158 delta { get; set; }
    }

    public class Delta159
    {
        public int confirmed { get; set; }
    }

    public class Ahmadnagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta159 delta { get; set; }
    }

    public class Delta160
    {
        public int confirmed { get; set; }
    }

    public class Yavatmal
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta160 delta { get; set; }
    }

    public class Delta161
    {
        public int confirmed { get; set; }
    }

    public class Aurangabad
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta161 delta { get; set; }
    }

    public class Delta162
    {
        public int confirmed { get; set; }
    }

    public class Ratnagiri
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta162 delta { get; set; }
    }

    public class Delta163
    {
        public int confirmed { get; set; }
    }

    public class Sangli
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta163 delta { get; set; }
    }

    public class Delta164
    {
        public int confirmed { get; set; }
    }

    public class Satara
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta164 delta { get; set; }
    }

    public class Delta165
    {
        public int confirmed { get; set; }
    }

    public class Sindhudurg
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta165 delta { get; set; }
    }

    public class Delta166
    {
        public int confirmed { get; set; }
    }

    public class Gondiya
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta166 delta { get; set; }
    }

    public class Delta167
    {
        public int confirmed { get; set; }
    }

    public class Kolhapur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta167 delta { get; set; }
    }

    public class Delta168
    {
        public int confirmed { get; set; }
    }

    public class Gujarat
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta168 delta { get; set; }
    }

    public class Delta169
    {
        public int confirmed { get; set; }
    }

    public class Jalgaon
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta169 delta { get; set; }
    }

    public class Delta170
    {
        public int confirmed { get; set; }
    }

    public class Buldana
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta170 delta { get; set; }
    }

    public class Delta171
    {
        public int confirmed { get; set; }
    }

    public class Nashik
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta171 delta { get; set; }
    }

    public class Delta172
    {
        public int confirmed { get; set; }
    }

    public class Osmanabad
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta172 delta { get; set; }
    }

    public class Delta173
    {
        public int confirmed { get; set; }
    }

    public class Washim
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta173 delta { get; set; }
    }

    public class Delta174
    {
        public int confirmed { get; set; }
    }

    public class Hingoli
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta174 delta { get; set; }
    }

    public class Delta175
    {
        public int confirmed { get; set; }
    }

    public class Unknown5
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta175 delta { get; set; }
    }

    public class Delta176
    {
        public int confirmed { get; set; }
    }

    public class Amravati
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta176 delta { get; set; }
    }

    public class Delta177
    {
        public int confirmed { get; set; }
    }

    public class Latur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta177 delta { get; set; }
    }

    public class DistrictData11
    {
        public Pune Pune { get; set; }
        public Mumbai Mumbai { get; set; }
        public Nagpur Nagpur { get; set; }
        public Thane Thane { get; set; }
        public Ahmadnagar Ahmadnagar { get; set; }
        public Yavatmal Yavatmal { get; set; }
        public Aurangabad Aurangabad { get; set; }
        public Ratnagiri Ratnagiri { get; set; }
        public Sangli Sangli { get; set; }
        public Satara Satara { get; set; }
        public Sindhudurg Sindhudurg { get; set; }
        public Gondiya Gondiya { get; set; }
        public Kolhapur Kolhapur { get; set; }
        public Gujarat Gujarat { get; set; }
        public Jalgaon Jalgaon { get; set; }
        public Buldana Buldana { get; set; }
        public Nashik Nashik { get; set; }
        public Osmanabad Osmanabad { get; set; }
        public Washim Washim { get; set; }
        public Hingoli Hingoli { get; set; }
        public Unknown5 Unknown { get; set; }
        public Amravati Amravati { get; set; }
        public Latur Latur { get; set; }
    }

    public class Maharashtra
    {
        public DistrictData11 districtData { get; set; }
    }

    public class Delta178
    {
        public int confirmed { get; set; }
    }

    public class Amritsar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta178 delta { get; set; }
    }

    public class Delta179
    {
        public int confirmed { get; set; }
    }

    public class ShahidBhagatSinghNagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta179 delta { get; set; }
    }

    public class Delta180
    {
        public int confirmed { get; set; }
    }

    public class SASNagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta180 delta { get; set; }
    }

    public class Delta181
    {
        public int confirmed { get; set; }
    }

    public class Hoshiarpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta181 delta { get; set; }
    }

    public class Delta182
    {
        public int confirmed { get; set; }
    }

    public class Jalandhar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta182 delta { get; set; }
    }

    public class Delta183
    {
        public int confirmed { get; set; }
    }

    public class Ludhiana
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta183 delta { get; set; }
    }

    public class Delta184
    {
        public int confirmed { get; set; }
    }

    public class Patiala
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta184 delta { get; set; }
    }

    public class Delta185
    {
        public int confirmed { get; set; }
    }

    public class Rupnagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta185 delta { get; set; }
    }

    public class Delta186
    {
        public int confirmed { get; set; }
    }

    public class Mansa
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta186 delta { get; set; }
    }

    public class Delta187
    {
        public int confirmed { get; set; }
    }

    public class Pathankot
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta187 delta { get; set; }
    }

    public class Delta188
    {
        public int confirmed { get; set; }
    }

    public class Faridkot
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta188 delta { get; set; }
    }

    public class Delta189
    {
        public int confirmed { get; set; }
    }

    public class Barnala
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta189 delta { get; set; }
    }

    public class DistrictData12
    {
        public Amritsar Amritsar { get; set; }
        public ShahidBhagatSinghNagar ShahidBhagatSinghNagar { get; set; }
        public SASNagar SASNagar { get; set; }
        public Hoshiarpur Hoshiarpur { get; set; }
        public Jalandhar Jalandhar { get; set; }
        public Ludhiana Ludhiana { get; set; }
        public Patiala Patiala { get; set; }
        public Rupnagar Rupnagar { get; set; }
        public Mansa Mansa { get; set; }
        public Pathankot Pathankot { get; set; }
        public Faridkot Faridkot { get; set; }
        public Barnala Barnala { get; set; }
    }

    public class Punjab
    {
        public DistrictData12 districtData { get; set; }
    }

    public class Delta190
    {
        public int confirmed { get; set; }
    }

    public class SPSNellore
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta190 delta { get; set; }
    }

    public class Delta191
    {
        public int confirmed { get; set; }
    }

    public class Prakasam
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta191 delta { get; set; }
    }

    public class Delta192
    {
        public int confirmed { get; set; }
    }

    public class Visakhapatnam
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta192 delta { get; set; }
    }

    public class Delta193
    {
        public int confirmed { get; set; }
    }

    public class EastGodavari
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta193 delta { get; set; }
    }

    public class Delta194
    {
        public int confirmed { get; set; }
    }

    public class Krishna
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta194 delta { get; set; }
    }

    public class Delta195
    {
        public int confirmed { get; set; }
    }

    public class Chittoor
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta195 delta { get; set; }
    }

    public class Delta196
    {
        public int confirmed { get; set; }
    }

    public class Guntur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta196 delta { get; set; }
    }

    public class Delta197
    {
        public int confirmed { get; set; }
    }

    public class Kurnool
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta197 delta { get; set; }
    }

    public class Delta198
    {
        public int confirmed { get; set; }
    }

    public class Anantapur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta198 delta { get; set; }
    }

    public class Delta199
    {
        public int confirmed { get; set; }
    }

    public class WestGodavari
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta199 delta { get; set; }
    }

    public class Delta200
    {
        public int confirmed { get; set; }
    }

    public class YSR
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta200 delta { get; set; }
    }

    public class DistrictData13
    {
        public SPSNellore SPSNellore { get; set; }
        public Prakasam Prakasam { get; set; }
        public Visakhapatnam Visakhapatnam { get; set; }
        public EastGodavari EastGodavari { get; set; }
        public Krishna Krishna { get; set; }
        public Chittoor Chittoor { get; set; }
        public Guntur Guntur { get; set; }
        public Kurnool Kurnool { get; set; }
        public Anantapur Anantapur { get; set; }
        public WestGodavari WestGodavari { get; set; }
        public YSR YSR { get; set; }
    }

    public class AndhraPradesh
    {
        public DistrictData13 districtData { get; set; }
    }

    public class Delta201
    {
        public int confirmed { get; set; }
    }

    public class Dehradun
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta201 delta { get; set; }
    }

    public class Delta202
    {
        public int confirmed { get; set; }
    }

    public class PauriGarhwal
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta202 delta { get; set; }
    }

    public class Delta203
    {
        public int confirmed { get; set; }
    }

    public class UdhamSinghNagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta203 delta { get; set; }
    }

    public class Delta204
    {
        public int confirmed { get; set; }
    }

    public class Nainital
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta204 delta { get; set; }
    }

    public class Delta205
    {
        public int confirmed { get; set; }
    }

    public class Haridwar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta205 delta { get; set; }
    }

    public class DistrictData14
    {
        public Dehradun Dehradun { get; set; }
        public PauriGarhwal PauriGarhwal { get; set; }
        public UdhamSinghNagar UdhamSinghNagar { get; set; }
        public Nainital Nainital { get; set; }
        public Haridwar Haridwar { get; set; }
    }

    public class Uttarakhand
    {
        public DistrictData14 districtData { get; set; }
    }

    public class Delta206
    {
        public int confirmed { get; set; }
    }

    public class Khordha
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta206 delta { get; set; }
    }

    public class Delta207
    {
        public int confirmed { get; set; }
    }

    public class Bhadrak
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta207 delta { get; set; }
    }

    public class Delta208
    {
        public int confirmed { get; set; }
    }

    public class Cuttack
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta208 delta { get; set; }
    }

    public class Delta209
    {
        public int confirmed { get; set; }
    }

    public class Puri
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta209 delta { get; set; }
    }

    public class Delta210
    {
        public int confirmed { get; set; }
    }

    public class Jajapur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta210 delta { get; set; }
    }

    public class Delta211
    {
        public int confirmed { get; set; }
    }

    public class Kalahandi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta211 delta { get; set; }
    }

    public class DistrictData15
    {
        public Khordha Khordha { get; set; }
        public Bhadrak Bhadrak { get; set; }
        public Cuttack Cuttack { get; set; }
        public Puri Puri { get; set; }
        public Jajapur Jajapur { get; set; }
        public Kalahandi Kalahandi { get; set; }
    }

    public class Odisha
    {
        public DistrictData15 districtData { get; set; }
    }

    public class Delta212
    {
        public int confirmed { get; set; }
    }

    public class Mahe
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta212 delta { get; set; }
    }

    public class Delta213
    {
        public int confirmed { get; set; }
    }

    public class Puducherry2
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta213 delta { get; set; }
    }

    public class DistrictData16
    {
        public Mahe Mahe { get; set; }
        public Puducherry2 Puducherry { get; set; }
    }

    public class Puducherry
    {
        public DistrictData16 districtData { get; set; }
    }

    public class Delta214
    {
        public int confirmed { get; set; }
    }

    public class Kolkata
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta214 delta { get; set; }
    }

    public class Delta215
    {
        public int confirmed { get; set; }
    }

    public class North24Parganas
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta215 delta { get; set; }
    }

    public class Delta216
    {
        public int confirmed { get; set; }
    }

    public class Nadia
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta216 delta { get; set; }
    }

    public class Delta217
    {
        public int confirmed { get; set; }
    }

    public class MedinipurEast
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta217 delta { get; set; }
    }

    public class Delta218
    {
        public int confirmed { get; set; }
    }

    public class Kalimpong
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta218 delta { get; set; }
    }

    public class Delta219
    {
        public int confirmed { get; set; }
    }

    public class Hooghly
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta219 delta { get; set; }
    }

    public class Delta220
    {
        public int confirmed { get; set; }
    }

    public class Howrah
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta220 delta { get; set; }
    }

    public class Delta221
    {
        public int confirmed { get; set; }
    }

    public class South24Parganas
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta221 delta { get; set; }
    }

    public class Delta222
    {
        public int confirmed { get; set; }
    }

    public class Unknown6
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta222 delta { get; set; }
    }

    public class DistrictData17
    {
        public Kolkata Kolkata { get; set; }
        public North24Parganas NorthParganas { get; set; }
        public Nadia Nadia { get; set; }
        public MedinipurEast MedinipurEast { get; set; }
        public Kalimpong Kalimpong { get; set; }
        public Hooghly Hooghly { get; set; }
        public Howrah Howrah { get; set; }
        public South24Parganas SouthParganas { get; set; }
        public Unknown6 Unknown { get; set; }
    }

    public class WestBengal
    {
        public DistrictData17 districtData { get; set; }
    }

    public class Delta223
    {
        public int confirmed { get; set; }
    }

    public class Chandigarh2
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta223 delta { get; set; }
    }

    public class DistrictData18
    {
        public Chandigarh2 Chandigarh { get; set; }
    }

    public class Chandigarh
    {
        public DistrictData18 districtData { get; set; }
    }

    public class Delta224
    {
        public int confirmed { get; set; }
    }

    public class Raipur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta224 delta { get; set; }
    }

    public class Delta225
    {
        public int confirmed { get; set; }
    }

    public class Rajnandgaon
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta225 delta { get; set; }
    }

    public class Delta226
    {
        public int confirmed { get; set; }
    }

    public class Bilaspur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta226 delta { get; set; }
    }

    public class Delta227
    {
        public int confirmed { get; set; }
    }

    public class Durg
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta227 delta { get; set; }
    }

    public class Delta228
    {
        public int confirmed { get; set; }
    }

    public class Korba
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta228 delta { get; set; }
    }

    public class DistrictData19
    {
        public Raipur Raipur { get; set; }
        public Rajnandgaon Rajnandgaon { get; set; }
        public Bilaspur Bilaspur { get; set; }
        public Durg Durg { get; set; }
        public Korba Korba { get; set; }
    }

    public class Chhattisgarh
    {
        public DistrictData19 districtData { get; set; }
    }

    public class Delta229
    {
        public int confirmed { get; set; }
    }

    public class Rajkot
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta229 delta { get; set; }
    }

    public class Delta230
    {
        public int confirmed { get; set; }
    }

    public class Surat
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta230 delta { get; set; }
    }

    public class Delta231
    {
        public int confirmed { get; set; }
    }

    public class Ahmadabad
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta231 delta { get; set; }
    }

    public class Delta232
    {
        public int confirmed { get; set; }
    }

    public class Vadodara
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta232 delta { get; set; }
    }

    public class Delta233
    {
        public int confirmed { get; set; }
    }

    public class Gandhinagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta233 delta { get; set; }
    }

    public class Delta234
    {
        public int confirmed { get; set; }
    }

    public class Kachchh
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta234 delta { get; set; }
    }

    public class Delta235
    {
        public int confirmed { get; set; }
    }

    public class Mahesana
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta235 delta { get; set; }
    }

    public class Delta236
    {
        public int confirmed { get; set; }
    }

    public class Bhavnagar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta236 delta { get; set; }
    }

    public class Delta237
    {
        public int confirmed { get; set; }
    }

    public class Porbandar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta237 delta { get; set; }
    }

    public class Delta238
    {
        public int confirmed { get; set; }
    }

    public class GirSomnath
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta238 delta { get; set; }
    }

    public class Delta239
    {
        public int confirmed { get; set; }
    }

    public class PanchMahals
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta239 delta { get; set; }
    }

    public class Delta240
    {
        public int confirmed { get; set; }
    }

    public class Patan
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta240 delta { get; set; }
    }

    public class Delta241
    {
        public int confirmed { get; set; }
    }

    public class ChotaUdaipur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta241 delta { get; set; }
    }

    public class DistrictData20
    {
        public Rajkot Rajkot { get; set; }
        public Surat Surat { get; set; }
        public Ahmadabad Ahmadabad { get; set; }
        public Vadodara Vadodara { get; set; }
        public Gandhinagar Gandhinagar { get; set; }
        public Kachchh Kachchh { get; set; }
        public Mahesana Mahesana { get; set; }
        public Bhavnagar Bhavnagar { get; set; }
        public Porbandar Porbandar { get; set; }
        public GirSomnath GirSomnath { get; set; }
        public PanchMahals PanchMahals { get; set; }
        public Patan Patan { get; set; }
        public ChotaUdaipur ChotaUdaipur { get; set; }
    }

    public class Gujarat2
    {
        public DistrictData20 districtData { get; set; }
    }

    public class Delta242
    {
        public int confirmed { get; set; }
    }

    public class Kangra
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta242 delta { get; set; }
    }

    public class Delta243
    {
        public int confirmed { get; set; }
    }

    public class Una
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta243 delta { get; set; }
    }

    public class Delta244
    {
        public int confirmed { get; set; }
    }

    public class Unknown7
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta244 delta { get; set; }
    }

    public class DistrictData21
    {
        public Kangra Kangra { get; set; }
        public Una Una { get; set; }
        public Unknown7 Unknown { get; set; }
    }

    public class HimachalPradesh
    {
        public DistrictData21 districtData { get; set; }
    }

    public class Delta245
    {
        public int confirmed { get; set; }
    }

    public class Jabalpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta245 delta { get; set; }
    }

    public class Delta246
    {
        public int confirmed { get; set; }
    }

    public class Bhopal
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta246 delta { get; set; }
    }

    public class Delta247
    {
        public int confirmed { get; set; }
    }

    public class Indore
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta247 delta { get; set; }
    }

    public class Delta248
    {
        public int confirmed { get; set; }
    }

    public class Ujjain
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta248 delta { get; set; }
    }

    public class Delta249
    {
        public int confirmed { get; set; }
    }

    public class Gwalior
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta249 delta { get; set; }
    }

    public class Delta250
    {
        public int confirmed { get; set; }
    }

    public class Shivpuri
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta250 delta { get; set; }
    }

    public class Delta251
    {
        public int confirmed { get; set; }
    }

    public class Chhindwara
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta251 delta { get; set; }
    }

    public class Delta252
    {
        public int confirmed { get; set; }
    }

    public class Morena
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta252 delta { get; set; }
    }

    public class Delta253
    {
        public int confirmed { get; set; }
    }

    public class Khargone
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta253 delta { get; set; }
    }

    public class Delta254
    {
        public int confirmed { get; set; }
    }

    public class Unknown8
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta254 delta { get; set; }
    }

    public class DistrictData22
    {
        public Jabalpur Jabalpur { get; set; }
        public Bhopal Bhopal { get; set; }
        public Indore Indore { get; set; }
        public Ujjain Ujjain { get; set; }
        public Gwalior Gwalior { get; set; }
        public Shivpuri Shivpuri { get; set; }
        public Chhindwara Chhindwara { get; set; }
        public Morena Morena { get; set; }
        public Khargone Khargone { get; set; }
        public Unknown8 Unknown { get; set; }
    }

    public class MadhyaPradesh
    {
        public DistrictData22 districtData { get; set; }
    }

    public class Delta255
    {
        public int confirmed { get; set; }
    }

    public class Munger
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta255 delta { get; set; }
    }

    public class Delta256
    {
        public int confirmed { get; set; }
    }

    public class Patna
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta256 delta { get; set; }
    }

    public class Delta257
    {
        public int confirmed { get; set; }
    }

    public class Siwan
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta257 delta { get; set; }
    }

    public class Delta258
    {
        public int confirmed { get; set; }
    }

    public class Nalanda
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta258 delta { get; set; }
    }

    public class Delta259
    {
        public int confirmed { get; set; }
    }

    public class Unknown9
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta259 delta { get; set; }
    }

    public class Delta260
    {
        public int confirmed { get; set; }
    }

    public class Lakhisarai
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta260 delta { get; set; }
    }

    public class Delta261
    {
        public int confirmed { get; set; }
    }

    public class Bhagalpur
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta261 delta { get; set; }
    }

    public class Delta262
    {
        public int confirmed { get; set; }
    }

    public class Gopalganj
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta262 delta { get; set; }
    }

    public class Delta263
    {
        public int confirmed { get; set; }
    }

    public class Gaya
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta263 delta { get; set; }
    }

    public class Delta264
    {
        public int confirmed { get; set; }
    }

    public class Begusarai
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta264 delta { get; set; }
    }

    public class Delta265
    {
        public int confirmed { get; set; }
    }

    public class Saran
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta265 delta { get; set; }
    }

    public class DistrictData23
    {
        public Munger Munger { get; set; }
        public Patna Patna { get; set; }
        public Siwan Siwan { get; set; }
        public Nalanda Nalanda { get; set; }
        public Unknown9 Unknown { get; set; }
        public Lakhisarai Lakhisarai { get; set; }
        public Bhagalpur Bhagalpur { get; set; }
        public Gopalganj Gopalganj { get; set; }
        public Gaya Gaya { get; set; }
        public Begusarai Begusarai { get; set; }
        public Saran Saran { get; set; }
    }

    public class Bihar
    {
        public DistrictData23 districtData { get; set; }
    }

    public class Delta266
    {
        public int confirmed { get; set; }
    }

    public class ImphalWest
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta266 delta { get; set; }
    }

    public class Delta267
    {
        public int confirmed { get; set; }
    }

    public class Unknown10
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta267 delta { get; set; }
    }

    public class DistrictData24
    {
        public ImphalWest ImphalWest { get; set; }
        public Unknown10 Unknown { get; set; }
    }

    public class Manipur
    {
        public DistrictData24 districtData { get; set; }
    }

    public class Delta268
    {
        public int confirmed { get; set; }
    }

    public class Aizawl
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta268 delta { get; set; }
    }

    public class DistrictData25
    {
        public Aizawl Aizawl { get; set; }
    }

    public class Mizoram
    {
        public DistrictData25 districtData { get; set; }
    }

    public class Delta269
    {
        public int confirmed { get; set; }
    }

    public class NorthGoa
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta269 delta { get; set; }
    }

    public class Delta270
    {
        public int confirmed { get; set; }
    }

    public class Unknown11
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta270 delta { get; set; }
    }

    public class DistrictData26
    {
        public NorthGoa NorthGoa { get; set; }
        public Unknown11 Unknown { get; set; }
    }

    public class Goa
    {
        public DistrictData26 districtData { get; set; }
    }

    public class Delta271
    {
        public int confirmed { get; set; }
    }

    public class SouthAndaman
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta271 delta { get; set; }
    }

    public class Delta272
    {
        public int confirmed { get; set; }
    }

    public class NorthAndMiddleAndaman
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta272 delta { get; set; }
    }

    public class Delta273
    {
        public int confirmed { get; set; }
    }

    public class Unknown12
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta273 delta { get; set; }
    }

    public class DistrictData27
    {
        public SouthAndaman SouthAndaman { get; set; }
        public NorthAndMiddleAndaman NorthandMiddleAndaman { get; set; }
        public Unknown12 Unknown { get; set; }
    }

    public class AndamanAndNicobarIslands
    {
        public DistrictData27 districtData { get; set; }
    }

    public class Delta274
    {
        public int confirmed { get; set; }
    }

    public class Ranchi
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta274 delta { get; set; }
    }

    public class Delta275
    {
        public int confirmed { get; set; }
    }

    public class Hazaribagh
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta275 delta { get; set; }
    }

    public class Delta276
    {
        public int confirmed { get; set; }
    }

    public class Bokaro
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta276 delta { get; set; }
    }

    public class DistrictData28
    {
        public Ranchi Ranchi { get; set; }
        public Hazaribagh Hazaribagh { get; set; }
        public Bokaro Bokaro { get; set; }
    }

    public class Jharkhand
    {
        public DistrictData28 districtData { get; set; }
    }

    public class Delta277
    {
        public int confirmed { get; set; }
    }

    public class Cachar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta277 delta { get; set; }
    }

    public class Delta278
    {
        public int confirmed { get; set; }
    }

    public class KamrupMetropolitan
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta278 delta { get; set; }
    }

    public class Delta279
    {
        public int confirmed { get; set; }
    }

    public class Jorhat
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta279 delta { get; set; }
    }

    public class Delta280
    {
        public int confirmed { get; set; }
    }

    public class Goalpara
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta280 delta { get; set; }
    }

    public class Delta281
    {
        public int confirmed { get; set; }
    }

    public class Nalbari
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta281 delta { get; set; }
    }

    public class Delta282
    {
        public int confirmed { get; set; }
    }

    public class SouthSalmaraMancachar
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta282 delta { get; set; }
    }

    public class Delta283
    {
        public int confirmed { get; set; }
    }

    public class Kamrup
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta283 delta { get; set; }
    }

    public class Delta284
    {
        public int confirmed { get; set; }
    }

    public class Morigaon
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta284 delta { get; set; }
    }

    public class Delta285
    {
        public int confirmed { get; set; }
    }

    public class Golaghat
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta285 delta { get; set; }
    }

    public class Delta286
    {
        public int confirmed { get; set; }
    }

    public class Lakhimpur2
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta286 delta { get; set; }
    }

    public class DistrictData29
    {
        public Cachar Cachar { get; set; }
        public KamrupMetropolitan KamrupMetropolitan { get; set; }
        public Jorhat Jorhat { get; set; }
        public Goalpara Goalpara { get; set; }
        public Nalbari Nalbari { get; set; }
        public SouthSalmaraMancachar SouthSalmaraMancachar { get; set; }
        public Kamrup Kamrup { get; set; }
        public Morigaon Morigaon { get; set; }
        public Golaghat Golaghat { get; set; }
        public Lakhimpur2 Lakhimpur { get; set; }
    }

    public class Assam
    {
        public DistrictData29 districtData { get; set; }
    }

    public class Delta287
    {
        public int confirmed { get; set; }
    }

    public class Lohit
    {
        public int confirmed { get; set; }
        public string lastupdatedtime { get; set; }
        public Delta287 delta { get; set; }
    }

    public class DistrictData30
    {
        public Lohit Lohit { get; set; }
    }

    public class ArunachalPradesh
    {
        public DistrictData30 districtData { get; set; }
    }

  
}

