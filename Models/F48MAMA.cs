using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class F48MAMA:EntityData
    {
        [Display(Name = "ID Number")]
        [Range(1, 1000, ErrorMessage = "ID Number?")]
        public uint? IDNumber { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }

        [Display(Name = "Miaka aliyoishi Moshi")]
        [Range(1, 70, ErrorMessage = "Miaka aliyoishi Moshi?")]
        public uint? MiakaMoshi { get; set; }

        [Display(Name = "Tarehe/Mwezi/Mwaka wa kuzaliwa")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateKuzaliwa { get; set; }

        [Display(Name = "Umri wa mama kwa miaka")]
        [Range(10, 120, ErrorMessage = "Umri wa mama kwa (miaka)?")]
        public uint? UmriMama { get; set; }

        [Display(Name = "1. Je ana umri gani ? (Miaka)")]
        [Range(10, 120, ErrorMessage = "Je ana umri gani ? (Miaka)?")]
        public uint? Q1 { get; set; }

        [Display(Name = "Q2. Je umeajiriwa na unapokea mshahara mwisho wa mwezi ? ")]
        public EFM48_1 Q2 { get; set; }

        [Display(Name = "(Kazi")]
        public string Q2_1 { get; set; }

        [Display(Name = "Q3. Kama hujaajiriwa, kwa sasa unafanya shughuli gani ya kukuingizia kipato?")]
        public EFM48_3 Q3 { get; set; }

        [Display(Name = "(itaje ")]
        public string Q3_1 { get; set; }

        [Display(Name = "Q4. Kama huna, unamtegemea mwenzi kwa matumizi yote? (mfano kwa kodi na chakula)")]
        public EFM48_1 Q4 { get; set; }

        [Display(Name = "(Taja Nini unategemea ")]
        public string Q4_1 { get; set; }

        [Display(Name = "Q5. Je nyumba mnayoishi ?")]
        public EFM48_5 Q5 { get; set; }

        [Display(Name = "Q6. Kama mmepanga, je mnalipia kodi ya shilingi ngapi kwa mwezi? ")]
        [Range(1000, 1000000, ErrorMessage = "mnalipia kodi ya shilingi ngapi kwa mwezi??")]
        public uint? Q6 { get; set; }

        [Display(Name = "Q7. Kwa kukadiria kipato chako cha mwezi ni kiasi gani? ")]
        [Range(1000, 1000000, ErrorMessage = "kipato chako cha mwezi??")]
        public uint? Q7 { get; set; }

        [Display(Name = "Q8. Nyumbani, mko watu wa ngapi kwa ujumla ? (idadi ya wote wanaolala na kula)")]
        [Range(1, 50, ErrorMessage = "mko watu wa ngapi?!!!!")]
        public uint? Q8 { get; set; }

        [Display(Name = "Kati ya hao waliotajwa, wangapi ni watoto chini ya miaka 5 ? ")]
        [Range(1, 50, ErrorMessage = "watoto chini ya miaka 5?!!!!")]
        public uint? Q8_1 { get; set; }

        [Display(Name = "Wangapi ni watu wazima zaidi ya miaka 15, na wanajitegemea ? ")]
        [Range(1, 50, ErrorMessage = "Wangapi ni watu wazima zaidi ya miaka 15?!!!!")]
        public uint? Q8_2 { get; set; }

        [Display(Name = "Q9. Je unasafiri mara kwa mara kwenda nje ya mji/mkoa ? ")]
        public EFM48_9 Q9 { get; set; }

        [Display(Name = "mara ngapi kwa mwezi?")]
        [Range(1, 31, ErrorMessage = "mara ngapi kwa mwezi ?!!!!")]
        public uint? Q9_1 { get; set; }

        [Display(Name = "mara ngapi kwa mwezi ?")]
        [Range(1, 31, ErrorMessage = "mara ngapi kwa mwezi ?!!!!")]
        public uint? Q9_2 { get; set; }

        [Display(Name = "(b) Kwa wasafiri, ukiwa umesafiri ni nani anamuangalia mtoto ?")]
        public string Q9_3 { get; set; }

        [Display(Name = "Q10. Je unakunywa pombe ?")]
        public EFM48_1 Q10 { get; set; }

        [Display(Name = "Q11. Je unatumia njia yoyote ya kujikinga usipate mimba?")]
        public EFM48_1 Q11 { get; set; }

        [Display(Name = "Itaje/Zitaje")]
        public string Q11_1 { get; set; }

        [Display(Name = "Q12. Je mnatumia kondomu wakati mnapokutana kimwili na mwenzi?")]
        public EFM48_1 Q12 { get; set; }

        [Display(Name = "Q13. Je hali yako ya unyumba kwa sasa ikoje?")]
        public EFM48_13 Q13 { get; set; }

        [Display(Name = "Ni bwana au chuo cha ngapi?")]
        [Range(1, 50, ErrorMessage = "Ni bwana au chuo cha ngapi?")]
        public uint? Q13_1 { get; set; }

        [Display(Name = "Ni bwana wa ngapi? ")]
        [Range(1, 50, ErrorMessage = "Ni bwana wa ngapi?")]
        public uint? Q13_2 { get; set; }

        [Display(Name = "Tumetengana kwa miaka")]
        [Range(1, 50, ErrorMessage = "kwa miaka ?")]
        public uint? Q13_3 { get; set; }

        [Display(Name = "Q14. Je mmeishi pamoja kwa muda gani?")]
        [Range(1, 30, ErrorMessage = "kwa miaka ?!!!!")]
        public uint? Q14 { get; set; }

        [Display(Name = "Q15. Kama hujaolewa, mmetengana, au mjane je una mwenzi wa kila siku?")]
        public EFM48_1? Q15 { get; set; }

        [Display(Name = "Q16. Je bado unaishi na baba wa mtoto huyu aliye kwenye utafiti?")]
        public EFM48_16 Q16 { get; set; }

        [Display(Name = "Mwaka wa ngapi baada ya kujifungua")]
        [Range(1, 30, ErrorMessage = "Mwaka wa ngapi baada ya kujifungua?")]
        public uint? Q16_1 { get; set; }

        [Display(Name = "Q17. Je umeolewa au unaishi na mume/mwenzi mwenye wake wengi ? (uke wenza)")]
        public EFM48_1 Q17 { get; set; }

        [Display(Name = "wewe ni mke wa ngapi? ")]
        [Range(1, 30, ErrorMessage = "mke wa ngapi? !!!!")]
        public uint? Q17_1 { get; set; }

        [Display(Name = "Q18. Ukiacha mke/wake, je mume/mwenzi wako ana wanawake wengine nje ya ndoa?")]
        public EFM48_18 Q18 { get; set; }

        [Display(Name = "Q19. Kama umeolewa/ au mnaishi bila ndoa, je wewe na mwenzi wako mnaishije?")]
        public EFM48_19 Q19 { get; set; }

        [Display(Name = "mara ngapi kwa wiki?")]
        [Range(1, 7, ErrorMessage = "ngapi? !!!!")]
        public uint? Q19_1 { get; set; }

        [Display(Name = "anakuja mara ngapi kwa mwaka")]
        [Range(1, 52, ErrorMessage = "ngapi? !!!!")]
        public uint? Q19_2 { get; set; }

        [Display(Name = "Q20. Mume au mwenzi wako wa sasa ana umri gani? (Miaka) ")]
        [Range(1, 120, ErrorMessage = "Miaka? !!!!")]
        public uint? Q20 { get; set; }

        [Display(Name = "(Anafanya kazi au shughuli gani?")]
        public string Q20_1 { get; set; }

        [Display(Name = "(Je anasafiri mara kwa mara?")]
        public EFM48_1? Q20_2 { get; set; }

        [Display(Name = "mara ngapi kwa mwezi")]
        [Range(1, 31, ErrorMessage = "ngapi? !!!!")]
        public uint? Q20_2_1 { get; set; }

        [Display(Name = "(Je anakunywa pombe?")]
        public EFM48_1? Q20_3 { get; set; }

        [Display(Name = "(Kila siku/Mara moja kwa wiki/Mara moja moja")]
        public EFM48_20? Q20_3_1 { get; set; }

        [Display(Name = "Q21. Je kwa ujumla ukimuweka mume/mwenzi wako wa sasa," +
            " umeshakuwa na wenzi/wapenzi wangapi tangu ulipokutana kimwili kwa" +
            " mara ya kwanza hadi sasa hivi?  Idadi")]
        [Range(1, 50, ErrorMessage = "idadi ya wapenzi?")]
        public uint? Q21 { get; set; }

        [Display(Name = "(Q22. Na je ni watu wangapi tofauti ambao umekutana nao kimwili kwa kipindi" +
            " cha miezi 12 iliyopita ukiacha   mume/mwenzi wako?")]
        public EFM48_1 Q22 { get; set; }

        [Display(Name = "idadi")]
        [Range(1, 50, ErrorMessage = "idadi?")]
        public uint? Q22_1 { get; set; }

        [Display(Name = "(Q23. Je mpaka sasa umeshashirikiana majibu yako ya kipimo cha UKIMWI (HIV) " +
            "na mume au mwenzi?")]
        public EFM48_1 Q23 { get; set; }

        [Display(Name = "(Q24. Je unajua hali ya mwenza wako kuhusiana na kipimo au majibu ua UKIMWI ?" +
            " (Know his serostatus?)")]
        public EFM48_1 Q24 { get; set; }

        [Display(Name = "Q25.Je zaidi ya mwenzi umejadiliana majibu yako ya kipimo cha UKIMWI na mtu mwingine yeyote?")]
        public EFM48_1 Q25 { get; set; }

        [Display(Name = "Mtaje/Wataje")]
        [Range(1, 30, ErrorMessage = "idadi ? !!!!")]
        public uint? Q25_1 { get; set; }

        [Display(Name = "Q26. Je mume/mwenzi wako naye ameshakuja kupima UKIMWI (HIV)? ")]
        public EFM48_1 Q26 { get; set; }

        [Display(Name = "Q27. Je una jumla ya watoto wangapi walio hai? ")]
        [Range(0, 30, ErrorMessage = " Je una jumla ya watoto wangapi walio hai?")]
        public uint? Q27 { get; set; }

        [Display(Name = "Umri wa mtoto wa kwanza:")]
        [Range(1, 70, ErrorMessage = "Umri wa mtoto wa kwanza?")]
        public uint? Q27_1 { get; set; }

        [Display(Name = "Umri wa mtoto wa mwisho:")]
        [Range(1, 70, ErrorMessage = "Umri wa mtoto wa mwisho?")]
        public uint? Q27_2 { get; set; }

        [Display(Name = "Je watoto wote wana baba mmoja?")]
        public EFM48_1 Q27_3 { get; set; }

        [Display(Name = "Q28. Je ukifikiria, unajiona uko au hauko kwenye hatari ya kuambukizwa virusi vya ugonjwa wa UKIMWI ")]
        public EFM48_28 Q28 { get; set; }


        [Display(Name = "(Kwanini hujui?")]
        public string Q28_1 { get; set; }

        [Display(Name = "(Q29. Kwa nini unaona huna hatari? ")]
        public string Q29 { get; set; }

        [Display(Name = "(Q30. Kwa nini unajiona uko kwenye hatari? ")]
        public string Q30 { get; set; }

        [Display(Name = "Q31. Je umewahi kumjua mtu mwenye VVU (UKIMWI) hapo unapoishi?")]
        public EFM48_1 Q31 { get; set; }

        [Display(Name = "-Umeshakuwa na ndugu ambaye ameathirika au kufariki na UKIMWI?	")]
        public EFM48_1 Q31_1 { get; set; }

        [Display(Name = "-Watu walioathirika na UKIMWI wana haki ya kutomwambia mtu" +
            " au unadhani hali hiyo iwe wazi kwa jamii wanapoishi?")]
        public EFM48_31_2 Q31_2 { get; set; }

        [Display(Name = "-Je ukiwa na ndugu aliyeathirika na VVU, uko tayari kuishi naye au kumlea nyumbani kwako? ")]
        public EFM48_31_3 Q31_3 { get; set; }

        [Display(Name = "-Mwalimu aliyeathirika na VVU, na anafundisha shule anayosoma mwanao," +
            " je aruhusiwe kuendelea  kufundisha au aachishwe ? ")]
        public EFM48_31_4 Q31_4 { get; set; }

        [Display(Name = "-Je ukiwa unajua muuzaji wa mboga gengeni ameathirika na VVU, " +
            "utaendelea kununua mboga toka kwenye genge / kibanda au utahama ?")]
        public EFM48_31_5 Q31_5 { get; set; }

        [Display(Name = "Q32. Je tangu uje kliniki mara ya mwisho au kwa sasa una dalili zifuatazo?")]
        public EFM48_1 Q32 { get; set; }

        //32.Je tangu uje kliniki mara ya mwisho au kwa sasa una dalili zifuatazo?

        [Display(Name = "1. Abnormal vaginal discharge  Kutoka ute usio wa kawaida ukeni-unanuka, rangi njano ")]
        public EFM48_1? Q32_1 { get; set; }

        [Display(Name = "2. Genital itching Kuwashwa sehemu za siri")]
        public EFM48_1? Q32_2 { get; set; }

        [Display(Name = "3.Genital ulcers Vidonda sehemu za siri")]
        public EFM48_1? Q32_3 { get; set; }

        [Display(Name = "4. Dysuria Maumivu wakati wa kwenda kukujoa")]
        public EFM48_1? Q32_4 { get; set; }

        [Display(Name = "5. Dyspareunia  Maumivu wakati wa kufanya mapenzi")]
        public EFM48_1? Q32_5 { get; set; }

        [Display(Name = "6. Lower abdominal pain Maumivu katika tumbo la uzazi")]
        public EFM48_1? Q32_6 { get; set; }

        //Kama ana shida kati ya hizo, toa HVS, mpe tiba syndromically kabla hata majibu ya HVS hayajaja

        [Display(Name = "Q33. Je umeshalazwa hospitalini tangu ulipokuja kliniki kwa mara ya mwisho?")]
        public EFM48_1? Q33 { get; set; }

        [Display(Name = "Tatizo")]
        public string Q33_1 { get; set; }

        [Display(Name = "Q34. Je kwa kawaida unakula mara ngapi kwa siku ukiweka kifungua kinywa/breakfast?")]
        [Range(1, 24, ErrorMessage = "unakula mara ngapi kwa siku??")]
        public uint? Q34 { get; set; }

        //35.Mara nyingi unakula vyakula gani(List aina zote anazotaja + mboga na matunda)

        [Display(Name = "Asubuhi hadi saa sita")]
        public string Q35_1 { get; set; }

        [Display(Name = "Mchana:")]
        public string Q35_2 { get; set; }

        [Display(Name = "Jioni/Usiku: ")]
        public string Q35_3 { get; set; }

        //PHYSICAL EXAMINATION

        [Display(Name = "1. Weight(kg)")]
        [Range(10, 120, ErrorMessage = "weight?")]
        public uint? Q36 { get; set; }

        [Display(Name = "2. Height")]
        [Range(10, 60, ErrorMessage = "Height?")]
        public uint? Q37 { get; set; }

        [Display(Name = "4. Waist /Kiuno (cm")]
        [Range(10, 60, ErrorMessage = "Waist?")]
        public uint? Q38 { get; set; }

        [Display(Name = "Hip (cm)")]
        [Range(10, 60, ErrorMessage = "Hip?")]
        public uint? Q39 { get; set; }

        [Display(Name = "3. BP(mmHg)")]
        public string Q40 { get; set; }

        [Display(Name = "Mid upper arm circumference (cm)")]
        [Range(10, 60, ErrorMessage = "Waist?")]
        public uint? Q41 { get; set; }


        [Display(Name = "Palor-mucosa and conjuctiva")]
        public EFM48_42? Q42 { get; set; }

        [Display(Name = "Oral thrush")]
        public EFM48_43? Q43 { get; set; }

        [Display(Name = "Oral thrush")]
        public EFM48_43? Q44 { get; set; }

        [Display(Name = "Problems/ Diagnosis")]
        public string ProblemsDiagnosis { get; set; }

        [Display(Name = "Management")]
        public string ManagementFT { get; set; }

        [Display(Name = "Tarehe ya next visit 52 months(4YEARS AND 4 MONTHS) ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateVisit52 { get; set; }

    }

    public enum EFM48_1
    {
        [Display(Name = "0. Hapana")]
        Hapana = 0,
        [Display(Name = "1. Ndiyo")]
        Ndiyo = 1
    }

    public enum EFM48_3
    {
        [Display(Name = "0. Sina shughuli")]
        E0 = 0,
        [Display(Name = "1. Shughuli")]
        E1 = 1
    }

    public enum EFM48_5
    {
        [Display(Name = "1. Ni yenu wenyewe")]
        E1 = 1,
        [Display(Name = "2. Au mmepanga?")]
        E2 = 2
    }

    public enum EFM48_9
    {
        [Display(Name = "0. Hapana")]
        E0 = 0,
        [Display(Name = "1. Mara chache")]
        E1 = 1,
        [Display(Name = "2. Mara nyingi")]
        E2 = 2
    }

    public enum EFM48_13
    {
        [Display(Name = "1. Nimeolewa")]
        E1 = 1,
        [Display(Name = "2. Tunaishi")]
        E2 = 2,
        [Display(Name = "3. Sijaolewa")]
        E3 = 3,
        [Display(Name = "4. Tumetengana")]
        E4 = 4
    }

    public enum EFM48_16
    {
        [Display(Name = "1. Tunaishi pamoja")]
        E1 = 1,
        [Display(Name = "2. Tumetengana")]
        E2 = 2
    }

    public enum EFM48_18
    {
        [Display(Name = "0. Hapana")]
        E0 = 0,
        [Display(Name = "1. Ndiyo")]
        E1 = 1,
        [Display(Name = "2. Sijui")]
        E2 = 2
    }

    public enum EFM48_19
    {
        [Display(Name = "1. Pamoja wakati wote")]
        E1 = 1,
        [Display(Name = "2. Ananitembelea/Visits")]
        E2 = 2,
        [Display(Name = "3. Tunaishi mbali mbali kwa zaidi ya miezi sita")]
        E3 = 3
    }

    public enum EFM48_20
    {
        [Display(Name = "1. Kila siku")]
        E1 = 1,
        [Display(Name = "2. Mara moja kwa wiki")]
        E2 = 2,
        [Display(Name = "3. Mara moja moja")]
        E3 = 3
    }

    public enum EFM48_28
    {
        [Display(Name = "1. Hapana sina hatari (no risk) ")]
        E1 = 1,
        [Display(Name = "2. Niko kwenye hatari kidogo (small risk) ")]
        E2 = 2,
        [Display(Name = "3. Niko kwenye hatari kiasi (moderate risk) ")]
        E3 = 3,
        [Display(Name = "4. Niko kwenye hatari sana/hatari kubwa (High risk) ")]
        E4 = 4,
        [Display(Name = "5. Sijui (Don’t know) ")]
        E5 = 5

    }

    public enum EFM48_31_2
    {
        [Display(Name = "0. Iwe siri yao")]
        E0 = 0,
        [Display(Name = "1. Iwe wazi kwa jamii")]
        E1 = 1,
        [Display(Name = "2. Sijui")]
        E2 = 2
    }

    public enum EFM48_31_3
    {
        [Display(Name = "0. Nitaishi naye")]
        E0 = 0,
        [Display(Name = "1. Siwezi kuishi naye")]
        E1 = 1
    }

    public enum EFM48_31_4
    {
        [Display(Name = "0. Afundishe")]
        E0 = 0,
        [Display(Name = "1. Aachishwe ")]
        E1 = 1
    }

    public enum EFM48_31_5
    {
        [Display(Name = "0. Nitaendelea kununua")]
        E0 = 0,
        [Display(Name = "1. Nitamuhama")]
        E1 = 1
    }

    public enum EFM48_32
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
        [Display(Name = "6.Lower abdominal pain	Maumivu katika tumbo la uzazi")]
        E6 = 6
        


    }
    public enum EFM48_42
    {
        [Display(Name = "0. Normal")]
        E0 = 0,
        [Display(Name = "1. Pale")]
        E1 = 1
    }

    public enum EFM48_43
    {
        [Display(Name = "0. Absent")]
        E0 = 0,
        [Display(Name = "1. Present")]
        E1 = 1
    }
}
