using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class FTMAMA:EntityData
    {
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }

        [Display(Name = "ID Number")]
        [Range(1, 1000, ErrorMessage = "ID Number?")]
        public uint? IDNumber { get; set; }

        [Display(Name = "Q1.Have you resumed your menses? Je umeshaanza kutumika tangu ujifungue?")]
        public EFMT1 Q1 { get; set; }

        [Display(Name = "tangu mwezi wa baada ya kujifungua")]
        [Range(1, 24, ErrorMessage = "Have you resumed your menses?")]
        public uint? Q1_1 { get; set; }

        [Display(Name = "Q2.Have you resumed sex Je umeshaanza kukutana kimwili na mume/mwenzi wako?")]
        public EFMT1 Q2 { get; set; }

        [Display(Name = "tangu mwezi wa baada ya kujifungua")]
        [Range(1, 30, ErrorMessage = "Have you resumed sex Month?")]
        public uint? Q2_1 { get; set; }

        [Display(Name = "Q3.If yes are you using any contraceptive method? Kama ndiyo, unatumia njia yoyoyte ya kujikinga ")]
        public EFMT1 Q3 { get; set; }

        [Display(Name = "Itaje")]
        public string Q3_1 { get; set; }

        [Display(Name = "Q4.Are you planning to have more babies? Je bado unataka kupata watoto wengine baada ya huyu wa sasa?")]
        public EFMT1 Q4 { get; set; }

        [Display(Name = "Huyu wa sasa akiwa na miaka")]
        [Range(1, 15, ErrorMessage = "Huyu wa sasa akiwa na miaka?")]
        public uint? Q4_1 { get; set; }

        [Display(Name = "Q5.Are you breastfeeding the infant? Unamyonyesha mtoto?")]
        public EFMT1 Q5 { get; set; }

        [Display(Name = "Q6.Have you informed anybody about your HIV test results? Je umeshamueleza mtu yeyote kuhusu majibu yako ya kipimo cha ukimwi?")]
        public EFMT6 Q6 { get; set; }

        [Display(Name = "mtaje   ")]
        public string Q6_1 { get; set; }

        [Display(Name = "Q7.How long did you take to inform him/them? Je ulichukua muda gani tangu upimwe hadi ulipomueleza/waeleza?")]
        [Range(1, 10, ErrorMessage = "How long did you take to inform him/them?")]
        public uint? Q7 { get; set; }

        [Display(Name = "Q8.Did you experience any of the following when you informed your partner about the results? Je mume/mwenzi alifanyaje ulipomueleza majibu yako?")]
        public EFMT8 Q8 { get; set; }

        [Display(Name = "Nyinginezo")]
        public string Q8_1 { get; set; }

        [Display(Name = "Q9.Has your partner come for testing?  Je mume/mwenzi wako naye ameshakuja kupima? ")]
        public EFMT1 Q9 { get; set; }

        [Display(Name = "Q10.Why haven’t you told anybody?  Kwanini hujamueleza mtu yeyote")]
        public string Q10 { get; set; }

        [Display(Name = "Q11.Have you experienced any of these breast problems since the last visit, including currently? Je umeshapata matatizo haya ya maziwa tangu ulipohudhuria kliniki mara ya mwisho?")]
        public EFMT11 Q11 { get; set; }

        [Display(Name = "12.Do you presently have the following symptoms? Je kwa sasa una dalili zifuatazo?")]
        public EFMT12 Q12 { get; set; }

        [Display(Name = "Q13.Have you been hospitalised for medical illness since the last visit? Je umeshalazwa hospitalini tangu ulipokuja kliniki kwa mara ya mwisho?")]
        public EFMT1 Q13 { get; set; }

        [Display(Name = "Tatizo")]
        public string Q13_1 { get; set; }

        [Display(Name = "Q14.Any other problem Je mama ana tatizo lingine lolote kuhusiana na afya yake?   Litaje ")]
        public string Q14 { get; set; }

        [Display(Name = "1.Weight(kg)")]
        [Range(10, 120, ErrorMessage = "Weight(kg)?")]
        public uint? Q15 { get; set; }

        [Display(Name = "2.BP(mmHg)")]
        public string Q16 { get; set; }

        [Display(Name = "3.General appearance")]
        public EFMT17? Q17 { get; set; }

        [Display(Name = "4.Mucosa/Conjuctiva")]
        public EFMT18? Q18 { get; set; }

        [Display(Name = "5.Lymphadenopathy (neck, axilla)")]
        public EFMT1? Q19 { get; set; }

        [Display(Name = "7.Mouth")]
        public EFMT20? Q20 { get; set; }


        [Display(Name = "8.Breasts")]
        public EFMT20? Q21 { get; set; }

        [Display(Name = "9.Vulva")]
        public EFMT22? Q22 { get; set; }

        [Display(Name = "10.Vagina")]
        public EFMT23? Q23 { get; set; }

        [Display(Name = " 11.Cervix")]
        public EFMT24? Q24 { get; set; }

        [Display(Name = "12.Bi-manual palpation")]
        public EFMT25? Q25 { get; set; }

        [Display(Name = "13.Pap smear")]
        public EFMT26? Q26 { get; set; }

        [Display(Name = "Problems/ Diagnosis")]
        public string ProblemsDiagnosis { get; set; }

        [Display(Name = "Management")]
        public string ManagementFT { get; set; }

        [Display(Name = "Date of 6 months visit")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateVisit6 { get; set; }

    }
        //Questions Repeat
        public enum EFMT1
    {
        [Display(Name = "0.No  Hapana")]
        No = 0,
        [Display(Name = "1.Yes  Ndiyo")]
        Yes = 1


    }
    public enum EFMT6
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
    public enum EFMT8
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
        public enum EFMT11
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
    public enum EFMT12
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

    public enum EFMT17
    {
        [Display(Name = "0.Looks well")]
        E0 = 0,
        [Display(Name = "1.Looks sick")]
        E1 = 1
    }

    public enum EFMT18
    {
        [Display(Name = "0.Normal")]
        E0 = 0,
        [Display(Name = "1.Pale conjuctiva/mucosa")]
        E1 = 1
    }
    public enum EFMT20
    {
        [Display(Name = "0.Normal")]
        E0 = 0,
        [Display(Name = "1.Oral thrush")]
        E1 = 1
    }
    public enum EFMT21
    {
        [Display(Name = "0. Normal")]
        E1 = 1,
        [Display(Name = "2. Abscess")]
        E2 = 2,
        [Display(Name = "3. Ulcers/cracks")]
        E3 = 3,
        [Display(Name = "4. Lumps")]
        E4 = 4
    }


    public enum EFMT22
    {
        [Display(Name = "0. Normal")]
        E0 = 0,
        [Display(Name = "1. Ulcers(single/multiple)")]
        E1 = 1,
        [Display(Name = "2. Warts")]
        E2 = 2
    }

    public enum EFMT23
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

    public enum EFMT24
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
    public enum EFMT25
    {
        [Display(Name = "1. Normal")]
        E1 = 1,
        [Display(Name = "2. Adnexa.tenderness")]
        E2 = 2,
        [Display(Name = "3. Adnexa mass")]
        E3 = 3,
        [Display(Name = "4. Cervical excitation positive")]
        E4 = 4
    }

    public enum EFMT26
    {
        [Display(Name = "1. Taken")]
        E1 = 1,
        [Display(Name = "2. Not taken")]
        E2 = 2
    }

}
