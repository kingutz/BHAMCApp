using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class FTISAMAMA:EntityData
    {

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }

        [Display(Name = "ID Number")]
        [Range(1, 1000, ErrorMessage = "ID Number?")]
        public uint? IDNumber { get; set; }

        [Display(Name = "Q1.Have you resumed your menses? Je umeshaanza kutumika tangu ujifungue?")]
        public EFMTISA1 Q1 { get; set; }

        [Display(Name = "tangu mwezi wa baada ya kujifungua")]
        [Range(1, 30, ErrorMessage = "Have you resumed sex Month?")]
        public uint? Q1_1 { get; set; }

        [Display(Name = "Q2.Have you resumed sex Je umeshaanza kukutana kimwili na mume/mwenzi wako?")]
        public EFMTISA1 Q2 { get; set; }

        [Display(Name = "tangu mwezi wa baada ya kujifungua")]
        [Range(1, 24, ErrorMessage = "tangu mwezi wa baada ya kujifungua?")]
        public uint? Q2_1 { get; set; }

        [Display(Name = "Q3. Are you using any contraceptive method? Je  unatumia njia yoyoyte ya kujikinga usipate mimba?")]
        public EFMTISA1 Q3 { get; set; }

        [Display(Name = "Itaje")]
        public string Q3_1 { get; set; }

        //[Display(Name = "Q4.Are you planning to have more babies? Je bado unataka kupata watoto wengine baada ya huyu wa sasa?")]
        //public EFMT1 Q4 { get; set; }
        [Display(Name = "Q4.Are you using condoms? Je mnatumia kondomu wakati mnapokutana kimwili?")]
        public EFMTISA1 Q4 { get; set; }

        //[Display(Name = "Huyu wa sasa akiwa na miaka")]
        //[Range(10, 60, ErrorMessage = "Check Age?")]
        //public uint? Q4_1 { get; set; }

        [Display(Name = "Q5.Are you breastfeeding the infant? Unamyonyesha mtoto?")]
        public EFMTISA1 Q5 { get; set; }

        [Display(Name = "Q6. For those who haven’t informed anybody the HIV test results by 6 months," +
            " have they done so?   Kwa wale ambao hawajamueleza mtu yeyote hadi mwezi wa sita kuhusu majibu ya ukimwi," +
            " je  mpaka sasa umeshamueleza mtu yeyote kuhusu majibu yako ya kipimo cha ukimwi?")]
        public EFMTISA6 Q6 { get; set; }

        [Display(Name = "mtaje   ")]
        public string Q6_1 { get; set; }

        [Display(Name = "Q7. Did you experience any of the following when you informed your partner about the results? " +
            "  Je mume/mwenzi alifanyaje ulipomueleza majibu yako")]
        public EFMTISA8 Q7 { get; set; }

        [Display(Name = "Nyinginezo")]
        public string Q7_1 { get; set; }
        //[Display(Name = "Q8.Did you experience any of the following when you informed your partner about the results? Je mume/mwenzi alifanyaje ulipomueleza majibu yako?")]
        //public EFMT8 Q8 { get; set; }

        //[Display(Name = "Nyinginezo")]
        //public string Q8_1 { get; set; }

        [Display(Name = "Q8.Has your partner come for testing?  Je mume/mwenzi wako naye ameshakuja kupima? ")]
        public EFMTISA1 Q8 { get; set; }

        [Display(Name = "Q9.Why haven’t you told anybody?  Kwanini hujamueleza mtu yeyote")]
        public string Q9 { get; set; }

        [Display(Name = "10.Still living with the husband/father of the child  " +
            "Je bado unaishi na baba wa mtoto wako au mtengana baada ya kujifungua?")]
        public EFMTISA10 Q10 { get; set; }

        [Display(Name = "(Mwezi) baada ya kujifungua?")]
        [Range(1, 10, ErrorMessage = "Still living with the husband?")]
        public uint? Q10_1 { get; set; }

        [Display(Name = "Q11.Do you presently have the following symptoms? Je kwa sasa una dalili zifuatazo?")]
        public EFMTISA11 Q11 { get; set; }

        [Display(Name = "Q12.Have you been hospitalised for medical illness since the last visit? Je umeshalazwa hospitalini tangu ulipokuja kliniki kwa mara ya mwisho?")]
        public EFMTISA1 Q12 { get; set; }

        [Display(Name = "Tatizo")]
        public string Q12_1 { get; set; }

        [Display(Name = "Q13. Any other problem Je mama ana tatizo lingine lolote kuhusiana na afya yake?   Litaje ")]
        public string Q13 { get; set; }

        [Display(Name = "1. Weight(kg)")]
        [Range(10, 120, ErrorMessage = "weight?")]
        public uint? Q14 { get; set; }

        //[Display(Name = "2.BP(mmHg)")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q15 { get; set; }

        [Display(Name = "2. General appearance")]
        public EFMTISA17? Q15 { get; set; }

        //[Display(Name = "4.Mucosa/Conjuctiva")]
        //public EFMTISA18 Q17 { get; set; }

        [Display(Name = "3. Lymphadenopathy (neck, axilla)")]
        public EFMTISA1? Q16 { get; set; }

        //[Display(Name = "7.Mouth")]
        //public EFMTISA20 Q20 { get; set; }

        [Display(Name = "4. Skin")]
        public EFMTISA17? Q17 { get; set; }

        [Display(Name = "5. Gastrointestinal")]
        public EFMTISA18? Q18 { get; set; }

        [Display(Name = "6. Breasts")]
        public EFMTISA19? Q19 { get; set; }

        [Display(Name = "7. Respiratory")]
        public EFMTISA20? Q20 { get; set; }

        [Display(Name = "8. Genitalia")]
        public EFMTISA21? Q21 { get; set; }

        [Display(Name = "9.Vulva")]
        public EFMTISA22? Q22 { get; set; }

        [Display(Name = "10.Vagina")]
        public EFMTISA23? Q23 { get; set; }

        [Display(Name = "10.Vagina")]
        public EFMTISA24? Q24 { get; set; }

        [Display(Name = "Problems/ Diagnosis")]
        public string ProblemsDiagnosis { get; set; }

        [Display(Name = "Management")]
        public string ManagementFT { get; set; }

        [Display(Name = "Date of 12 months visit")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateVisit12 { get; set; }

    }
    //Questions Repeat
    public enum EFMTISA1
    {
        [Display(Name = "0.No  Hapana")]
        No = 0,
        [Display(Name = "1.Yes  Ndiyo")]
        Yes = 1


    }
    public enum EFMTISA6
    {
        [Display(Name = "0.No Sijamwambia mtu")]
        E0 = 0,
        [Display(Name = "1.Partner Nimemwambia mume au mwenzi wangu")]
        E1 = 1,
        [Display(Name = "2.My mother  Mama yangu")]
        E2 = 2,
        [Display(Name = "3.Other specify  Mwingine")]
        E3 = 3


    }
    public enum EFMTISA8
    {
        [Display(Name = "0.Hakufanya kitu")]
        E0 = 0,
        [Display(Name = "1.Alikasirika sababu umeamua kupima")]
        E1 = 1,
        [Display(Name = "2.Alikugombeza/kuleta ugomvi 3.Alikupiga")]
        E2 = 2,
        [Display(Name = "3.Amekuacha sababu ya kupima ")]
        E3 = 3,
        [Display(Name = "4.Nyinginezo")]
        E4 = 4


    }
    public enum EFMTISA9
    {
        [Display(Name = "1.Cracked nipples Chuchu kupata mipasuko na kuuma mtoto anaponyonya")]
        E1 = 1,
        [Display(Name = "2.Bleeding from the nipples Kutoka damu kwenye chuchu")]
        E2 = 2,
        [Display(Name = "3.Pain due to engorged breasts Maumivu kwa ajili ya titi kuvimba")]
        E3 = 3,
        [Display(Name = "4.Breast abscess Jipu la kwenye titi")]
        E4 = 4
    }
    public enum EFMTISA10
    {
        [Display(Name = "1.Tunaishi pamoja")]
        E1 = 1,
        [Display(Name = "2.Tumetengana")]
        E2 = 2
    }
    public enum EFMTISA11
    {
        [Display(Name = "1.Abnormal vaginal discharge Kutoka ute usio wa kawaida ukeni-unanuka, rangi njano n.k")]
        E1 = 1,
        [Display(Name = "2.Genital itching Kuwashwa sehemu za siri")]
        E2 = 2,
        [Display(Name = "3.Genital ulcers Vidonda sehemu za siri")]
        E3 = 3,
        [Display(Name = "4.Dysuria Maumivu wakati wa kwenda kukujoa")]
        E4 = 4,
        [Display(Name = "5.Dyspareunia Maumivu wakati wa kufanya mapenzi")]
        E5 = 5,
        [Display(Name = "6.Oral thrush/ulcers Vidonda au utando mdomoni")]
        E6 = 6,
        [Display(Name = "7.Recurrent fever Homa za mara kwa mara")]
        E7 = 7
    }

    public enum EFMTISA17
    {
        [Display(Name = "1. Normal")]
        E1 = 1,
        [Display(Name = "2. Rashes ")]
        E2 = 2,
        [Display(Name = "3. Ulcers")]
        E3 = 3
    }

    public enum EFMTISA18
    {
        [Display(Name = "1. Normal")]
        E1 = 1,
        [Display(Name = "2. Oral thrush")]
        E2 = 2,
        [Display(Name = "3. Jaundice")]
        E3 = 3
    }
    //public enum EFMTISA20
    //{
    //    [Display(Name = "0.Normal")]
    //    E0 = 0,
    //    [Display(Name = "1.Oral thrush")]
    //    E1 = 1
    //}
    public enum EFMTISA20
    {
        [Display(Name = "1. Normal")]
        E1 = 1,
        [Display(Name = "2. Cyanosed")]
        E2 = 2,
        [Display(Name = "3. Respiratory wheeze")]
        E3 = 3,
        [Display(Name = "4.Air entry good")]
        E4 = 4,
        [Display(Name = "5.Air entry poor")]
        E5 = 5
    }
    public enum EFMTISA21
    {
        [Display(Name = "0. Not circumcised")]
        E0 = 0,
        [Display(Name = "1. Partial clitoridectomy")]
        E1 = 1,
        [Display(Name = "2. Total clitoridectomy")]
        E2 = 2,
        [Display(Name = "3. Clitoridectomy + excised labia minora")]
        E3 = 3,
        [Display(Name = "4. Infibulation")]
        E4 = 4
    }
    public enum EFMTISA19
    {
        [Display(Name = "1. Normal")]
        E1 = 1,
        [Display(Name = "2. Abscess")]
        E2 = 2,
        [Display(Name = "3. Ulcers/cracks")]
        E3 = 3,
        [Display(Name = "4. Lumps")]
        E4 = 4
    }


    public enum EFMTISA22
    {
        [Display(Name = "0. Normal")]
        E0 = 0,
        [Display(Name = "1. Ulcers(single/multiple)")]
        E1 = 1,
        [Display(Name = "2. Warts")]
        E2 = 2
    }

    public enum EFMTISA23
    {
        [Display(Name = "0. Normal")]
        E0 = 0,
        [Display(Name = "1.Yellow discharge")]
        E1 = 1,
        [Display(Name = "2.Thick white discharge")]
        E2 = 2,
        [Display(Name = "3.Greyish discharge")]
        E3 = 3,
        [Display(Name = "4.Warts")]
        E4 = 4
    }

    public enum EFMTISA24
    {
        [Display(Name = "1. Normal cervix")]
        E1 = 1,
        [Display(Name = "2. Cervical discharge (swab test)")]
        E2 = 2,
        [Display(Name = "3.Cervical ectopy")]
        E3 = 3,
        [Display(Name = "4.Ulcer")]
        E4 = 4,
        [Display(Name = "5.Easily induced bleeding")]
        E5 = 5,
        [Display(Name = "6.Cervical cancer")]
        E6 = 6
    }
    

}
