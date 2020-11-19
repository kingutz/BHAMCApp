using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class F28_44MAMA:EntityData
    {

        [Display(Name = "ID Number")]
        [Range(10, 60, ErrorMessage = "Check Age?")]
        public uint? IDNumber { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }

        [Display(Name = "Tarehe/Mwezi/Mwaka wa kuzaliwa")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateKuzaliwa { get; set; }

        [Display(Name = "Umri wa mama kwa miaka")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? UmriMama { get; set; }

        [Display(Name = "Q1. Je bado unamyonyesha mtoto?")]
        public EFM28_44_1 Q1 { get; set; }

        [Display(Name = "Q2. Je unakutana kimwili na mwenzi wako kwa sasa baada ya kujifungua?")]
        public EFM28_44_1 Q2 { get; set; }

        [Display(Name = "Q3. Je unatumia njia yoyoyte ya kujikinga usipate mimba?")]
        public EFM28_44_1 Q3 { get; set; }

        [Display(Name = "Q4. Je mnatumia kondomu wakati mnapokutana kimwili na mwenzi?")]
        public EFM28_44_1 Q4 { get; set; }

        [Display(Name = "Q5.Je bado unaishi na baba wa mtoto huyu aliye kwenye utafiti au mtengana baada ya kujifungua?")]
        public EFM28_44_5 Q5 { get; set; }

        [Display(Name = "(Mwezi)baada ya kujifungua")]
        [Range(1, 24, ErrorMessage = "Mwezi?")]
        public uint? Q5_1 { get; set; }


        [Display(Name = "Q6.Kama mmetengana, je una mwenzi/mume mwingine mpya?")]
        public EFM28_44_6 Q6 { get; set; }

        [Display(Name = "Q7. Je bado unataka kupata watoto wengine baada ya huyu wa sasa aliye kwenye utafiti?")]
        public EFM28_44_7 Q7 { get; set; }

        [Display(Name = "(Huyu wa sasa akiwa na miaka")]
        [Range(1, 24, ErrorMessage = "Mwezi?")]
        public uint? Q7_1 { get; set; }

        [Display(Name = "(umri")]
        [Range(1, 24, ErrorMessage = "umri?")]
        public uint? Q7_2 { get; set; }

        [Display(Name = "Q8. Je mpaka sasa umeshashirikiana majibu yako ya kipimo cha UKIMWI (HIV) na mume au mwenzi?")]
        public EFM28_44_1 Q8 { get; set; }

        [Display(Name = "Q9.Je unajua hali ya mwenza wako kuhusiana na kipimo au majibu ua UKIMWI ? (Know his serostatus?)")]
        public EFM28_44_1 Q9 { get; set; }

        [Display(Name = "Q10.Je zaidi ya mwenzi umejadiliana majibu yako ya kipimo cha UKIMWI na mtu mwingine yeyote?)")]
        public EFM28_44_1 Q10 { get; set; }

        [Display(Name = "(Mtaje/Wataje")]
        public string Q10_1 { get; set; }

        [Display(Name = "Q11.Kama ana watoto wenye zaidi ya miaka 10 na zaidi, je" +
            " amejadiliana nao majibu yake ya kipimo cha UKIMWI ?")]
        public EFM28_44_1 Q11 { get; set; }

        [Display(Name = "Q12.Je mume/mwenzi wako naye ameshakuja kupima UKIMWI (HIV)?")]
        public EFM28_44_1 Q12 { get; set; }

        [Display(Name = "Q13. Je unashafisha ndani ya uke? ")]
        public EFM28_44_1 Q13 { get; set; }

        [Display(Name = "(Unatumia nini kuoshea?")]
        public string Q13_1 { get; set; }

        [Display(Name = "(Unakuosha mara ngapi kwa siku?")]
        [Range(1, 24, ErrorMessage = "Siku?")]
        public uint? Q13_2 { get; set; }

        [Display(Name = "(Unatumia kifaa gani kuoshea?Mfano kidole, kitambaa etc")]
        public string Q13_3 { get; set; }

        //Q14. Je tangu uje kliniki mara ya mwisho au kwa sasa una dalili zifuatazo?"
        

        [Display(Name = "1. Abnormal vaginal discharge Kutoka ute usio wa kawaida ukeni-unanuka, rangi njano")]
        public EFM28_44_1 Q14_1 { get; set; }

        [Display(Name = "2. Genital itching Kuwashwa sehemu za siri")]
        public EFM28_44_1 Q14_2 { get; set; }

        [Display(Name = "3. Genital ulcers Vidonda sehemu za siri")]
        public EFM28_44_1 Q14_3 { get; set; }

        [Display(Name = "4. Dysuria Maumivu wakati wa kwenda kukujoa")]
        public EFM28_44_1 Q14_4 { get; set; }

        [Display(Name = "5. Dyspareunia  Maumivu wakati wa kufanya mapenzi")]
        public EFM28_44_1 Q14_5 { get; set; }

        [Display(Name = "6. Lower abdominal pain Maumivu katika tumbo la uzazi")]
        public EFM28_44_1 Q14_6 { get; set; }

        //Kama ana shida kati ya hizo mpe tiba syndromically kabla hata majibu ya HVS hayajaja

        [Display(Name = "Q15. Je umeshalazwa hospitalini tangu ulipokuja kliniki kwa mara ya mwisho?")]
        public EFM28_44_1 Q15 { get; set; }

        [Display(Name = "(Tatizo")]
        public string Q15_1 { get; set; }

        [Display(Name = "Q16. Je kwa sasa unafanya shughuli gani ya kukuingizia kipato?")]
        public EFM28_44_16 Q16 { get; set; }

        [Display(Name = "(Q17. Kama hapana, unamtegemea mwenzi kwa matumizi yote?")]
        public string Q17 { get; set; }

        [Display(Name = "(Q18. Je mama ana tatizo lingine lolote kuhusiana na afya yake?  Litaje ")]
        public string Q18 { get; set; }

        //19.Mara nyingi unakulaga vyakula gani(List aina zote anazotaja)
        [Display(Name = "(Asubuhi")]
        public string Q19_1 { get; set; }

        [Display(Name = "(Mchana: ")]
        public string Q19_2 { get; set; }

        [Display(Name = "(Jioni/Usiku: ")]
        public string Q19_3 { get; set; }


        //PHYSICAL EXAMINATION

        [Display(Name = "1. Weight(kg)")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q20 { get; set; }

        [Display(Name = "2. Height")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q21 { get; set; }

        [Display(Name = "3. BP(mmHg)")]
        public string Q22 { get; set; }

        [Display(Name = "4. Waist /Kiuno (cm")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q23 { get; set; }

        [Display(Name = "Hip (cm)")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q24 { get; set; }

        [Display(Name = "3.General appearance")]
        public EFMT17 Q25 { get; set; }

        [Display(Name = "4.Mucosa/Conjuctiva")]
        public EFMT18 Q26 { get; set; }

        [Display(Name = "5.Lymphadenopathy (neck, axilla)")]
        public EFMT1 Q27 { get; set; }

        [Display(Name = "7.Mouth")]
        public EFMT20 Q28 { get; set; }

        [Display(Name = "8. Haemoglobin")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q29 { get; set; }

        [Display(Name = "9. Random Blood Glucose (RBG")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q30 { get; set; }

        [Display(Name = "Problems/ Diagnosis")]
        public string ProblemsDiagnosis { get; set; }

        [Display(Name = "Management")]
        public string ManagementFT { get; set; }

        [Display(Name = "Tarehe ya next visit (32M  2 YEARS AND 8 MONTHS)")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateVisit32 { get; set; }
    }

    public enum EFM28_44_1
    {
        [Display(Name = "0. Hapana")]
        Hapana = 0,
        [Display(Name = "1. Ndiyo")]
        Ndiyo = 1
    }

    public enum EFM28_44_5
    {
        [Display(Name = "1. Tunaishi pamoja")]
        E1 = 1,
        [Display(Name = "2. Tumetengana")]
        E2 = 2
    }

    public enum EFM28_44_6
    {
        [Display(Name = "0. Hapana")]
        E0 = 0,
        [Display(Name = "1. Ndiyo")]
        E1 = 1,
        [Display(Name = "2. Haihusiki")]
        E2 = 2
    }


    public enum EFM28_44_7
    {
        [Display(Name = "0. Hapana")]
        E0 = 0,
        [Display(Name = "1. Ndiyo")]
        E1 = 1,
        [Display(Name = "2. Ana mwingine")]
        E2 = 2
    }

    public enum EFM28_44_14
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

    public enum EFM28_44_16
    {
        [Display(Name = "0. Sina shughuli")]
        E0 = 0,
        [Display(Name = "1. Shughuli")]
        E1 = 1
    }

}
