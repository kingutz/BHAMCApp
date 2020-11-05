using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class FKMMAMA
    {


        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }

        [Display(Name = "ID Number")]
        [Range(10, 60, ErrorMessage = "Check Age?")]
        public uint? IDNumber { get; set; }

        [Display(Name = "Q1.Have you resumed your menses? Je umeshaanza kutumika tangu ujifungue?")]
        public EFMKM1 Q1 { get; set; }

        [Display(Name = "tangu mwezi wa baada ya kujifungua")]
        [Range(10, 60, ErrorMessage = "Check Age?")]
        public uint? Q1_1 { get; set; }

        [Display(Name = "Q2.Have you resumed sex Je umeshaanza kukutana kimwili na mume/mwenzi wako?")]
        public EFMKM1 Q2 { get; set; }

        //[Display(Name = "tangu mwezi wa baada ya kujifungua")]
        //[Range(10, 60, ErrorMessage = "Check Age?")]
        //public uint? Q2_1 { get; set; }

        [Display(Name = "Q3. Are you using any contraceptive method? Je  unatumia njia yoyoyte ya kujikinga usipate mimba?")]
        public EFMKM1 Q3 { get; set; }

        [Display(Name = "Itaje")]
        public string Q3_1 { get; set; }

        //[Display(Name = "Q4.Are you planning to have more babies? Je bado unataka kupata watoto wengine baada ya huyu wa sasa?")]
        //public EFMT1 Q4 { get; set; }
        [Display(Name = "Q4.Are you using condoms? Je mnatumia kondomu wakati mnapokutana kimwili?")]
        public EFMKM1 Q4 { get; set; }

        //[Display(Name = "Huyu wa sasa akiwa na miaka")]
        //[Range(10, 60, ErrorMessage = "Check Age?")]
        //public uint? Q4_1 { get; set; }

        [Display(Name = "Q5.Are you breastfeeding the infant? Unamyonyesha mtoto?")]
        public EFMKM1 Q5 { get; set; }

        //[Display(Name = "Q6. For those who haven’t informed anybody the HIV test results by 6 months," +
        //    " have they done so?   Kwa wale ambao hawajamueleza mtu yeyote hadi mwezi wa sita kuhusu majibu ya ukimwi," +
        //    " je  mpaka sasa umeshamueleza mtu yeyote kuhusu majibu yako ya kipimo cha ukimwi?")]
        //public EFMTISA6 Q6 { get; set; }

        //[Display(Name = "mtaje   ")]
        //public string Q6_1 { get; set; }
        [Display(Name = "Q6. Have you shared your HIV results with your partner? " +
            "Je mpaka sasa umeshashirikiana majibu yako ya kipimo cha ukimwi na mume au mwenzi?")]
        public EFMKM1 Q6 { get; set; }

        //[Display(Name = "Q7. Did you experience any of the following when you informed your partner about the results? " +
        //    "  Je mume/mwenzi alifanyaje ulipomueleza majibu yako")]
        //public EFMTISA8 Q7 { get; set; }

        //[Display(Name = "Nyinginezo")]
        //public string Q7_1 { get; set; }

        [Display(Name = "Q7. Apart from the partner have you discussed your HIV results with anybody else? " +
            "Je zaidi ya mume/mwenzi umejadiliana majibu yako ya kipimo cha UKIMWI na mtu mwingine yeyote?	")]
        public EFMKM1 Q7 { get; set; }


        [Display(Name = "mtaje   ")]
        public string Q7_1 { get; set; }


        //[Display(Name = "Q8.Did you experience any of the following when you informed your partner about the results? Je mume/mwenzi alifanyaje ulipomueleza majibu yako?")]
        //public EFMT8 Q8 { get; set; }

        //[Display(Name = "Nyinginezo")]
        //public string Q8_1 { get; set; }

        [Display(Name = "Q8.Has your partner come for testing? Je mume/mwenzi wako naye ameshakuja kupima? ")]
        public EFMKM1 Q8 { get; set; }


        //[Display(Name = "Q9.Why haven’t you told anybody?  Kwanini hujamueleza mtu yeyote")]
        //public string Q9 { get; set; }

        [Display(Name = "Q9. Still living with the husband/father of the child  " +
            "Je bado unaishi na baba wa mtoto wako au mtengana baada ya kujifungua?")]
        public EFMKM9 Q9 { get; set; }

        [Display(Name = "Q10.Do you presently have the following symptoms? Je kwa sasa una dalili zifuatazo?")]
        public EFMKM10 Q10 { get; set; }

        [Display(Name = "Q11. Have you been hospitalised for medical illness since the last visit? Je umeshalazwa hospitalini tangu ulipokuja kliniki kwa mara ya mwisho?")]
        public EFMKM1 Q11 { get; set; }

        [Display(Name = "Tatizo")]
        public string Q11_1 { get; set; }

        [Display(Name = "Q12. Any other problem Je mama ana tatizo lingine lolote kuhusiana na afya yake?   Litaje ")]
        public string Q13 { get; set; }

        [Display(Name = "1. Weight(kg)")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q14 { get; set; }

        [Display(Name = "2.BP(mmHg)")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q15 { get; set; }

        [Display(Name = "3. Height")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q16 { get; set; }

        

    }
    //Questions Repeat
    public enum EFMKM1
    {
        [Display(Name = "0.No  Hapana")]
        No = 0,
        [Display(Name = "1.Yes  Ndiyo")]
        Yes = 1


    }
    
   
   
    public enum EFMKM9
    {
        [Display(Name = "1.Tunaishi pamoja")]
        E1 = 1,
        [Display(Name = "2.Tumetengana")]
        E2 = 2
    }
    public enum EFMKM10
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

    

    
    //public enum EFMTISA20
    //{
    //    [Display(Name = "0.Normal")]
    //    E0 = 0,
    //    [Display(Name = "1.Oral thrush")]
    //    E1 = 1
    //}
   
    

   

   


}