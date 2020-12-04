using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class F15_24MAMA:EntityData
    {
        [Display(Name = "ID Number")]
        [Range(10, 60, ErrorMessage = "Check Age?")]
        public uint? IDNumber { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }

       

        [Display(Name = "Q1.Have you resumed your menses? Je umeshaanza kutumika tangu ujifungue?")]
        public EFMTISA1 Q1 { get; set; }

        [Display(Name = "tangu mwezi wa baada ya kujifungua")]
        [Range(10, 60, ErrorMessage = "Check Age?")]
        public uint? Q1_1 { get; set; }


        [Display(Name = "Q2.Are you using any contraceptive method?Je  unatumia njia yoyoyte ya kujikinga usipate mimba?")]
        public EFMTISA1 Q2 { get; set; }


        [Display(Name = "Itaje")]
        public string Q2_1 { get; set; }
        


        [Display(Name = "Q3.Are you using condoms? Je mnatumia kondomu wakati mnapokutana kimwili?")]
        public EFMTISA1 Q3 { get; set; }


        [Display(Name = "Q4.Are you breastfeeding the infant? Unamyonyesha mtoto?")]
        public EFMTISA1 Q4 { get; set; }

        [Display(Name = "•Kama ndiyo mchana ananyonya kama mara ngapi? ")]
        [Range(1, 10, ErrorMessage = "Check Age?")]
        public uint? Q4_1 { get; set; }

        [Display(Name = "•Usiku anaweza kunyonya kama mara ngapi?")]
        [Range(1, 10, ErrorMessage = "Check Age?")]
        public uint? Q4_2 { get; set; }

        [Display(Name = "Q5.Have you shared your HIV results with your partner?" +
            "Je mpaka sasa umeshashirikiana majibu yako ya kipimo cha ukimwi na mume au mwenzi?")]
        public EFMTISA1 Q5 { get; set; }

        [Display(Name = "6.Apart from the partner have you discussed your HIV results with anybody else?  " +
            "  Je zaidi ya mume/mwenzi umejadiliana majibu yako ya kipimo cha UKIMWI na mtu mwingine yeyote?")]
        public EFMTISA1 Q6 { get; set; }

        [Display(Name = "mtaje   ")]
        public string Q6_1 { get; set; } 

        [Display(Name = "Q7.Has your partner come for testing?  Je mume/mwenzi wako naye ameshakuja kupima? ")]
        public EFMTISA1 Q7 { get; set; }

        [Display(Name = "Q8. Still living with the husband/father of the child  " +
            "Je bado unaishi na baba wa mtoto wako au mtengana baada ya kujifungua?")]
        public EFMTISA10 Q8 { get; set; }

        [Display(Name = "(Mwezi) baada ya kujifungua?")]
        [Range(1, 10, ErrorMessage = "Still living with the husband?")]
        public uint? Q8_1 { get; set; }

        [Display(Name = "Q9.Do you presently have the following symptoms? Je kwa sasa una dalili zifuatazo?")]
        public EFMTISA11 Q9 { get; set; }

        [Display(Name = "Q10.Have you been hospitalised for medical illness since the last visit? Je umeshalazwa hospitalini tangu ulipokuja kliniki kwa mara ya mwisho?")]
        public EFMTISA1 Q10 { get; set; }

        [Display(Name = "Tatizo")]
        public string Q10_1 { get; set; }


        [Display(Name = "Q11. Any other problem Je mama ana tatizo lingine lolote kuhusiana na afya yake?   Litaje ")]
        public string Q11 { get; set; }

      




    }
}
