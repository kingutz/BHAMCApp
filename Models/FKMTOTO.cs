using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class FKMTOTO
    {

        [Display(Name = "Tarehe")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Tarehe { get; set; }

        [Display(Name = "ID Number")]
        [Range(10, 60, ErrorMessage = "Check Age?")]
        public uint? IDNumber { get; set; }


        [Display(Name = "Sex")]
        public EFMTKSex SexMt { get; set; }

        [Display(Name = "Tarehe ya kuzaliwa")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? TareheKuzaliwa { get; set; }

        [Display(Name = "Umri wa mtoto kwa miezi")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? UmriMtotoMiezi { get; set; }

        [Display(Name = "Q1.Je mtoto bado ananyonyeshwa maziwa ya mama?")]
        public EFMOK1 Q1 { get; set; }

        [Display(Name = "-Je alianza kunyonya muda gani baada ya kuzaliwa? Baada ya masaa")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q1_a { get; set; }

        [Display(Name = "-Je mama alimpa maziwa ya mwanzo (colostrum)?")]
        public EFMOK1 Q1_b { get; set; }

        [Display(Name = "-Je alimpa kitu chochote kama maji au chai kabla ya kuanza kumyonyesha? ")]
        public EFMOK1 Q1_c { get; set; }

        [Display(Name = "2.Kama hapana, ni kwanini?")]
        public string Q2 { get; set; }

        [Display(Name = "3.Zaidi ya maziwa ya mama, je mtoto anapewa maji ya kunywa?")]
        public EFMOK1 Q3 { get; set; }

        [Display(Name = "Tangu alipokuwa na wiki")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q3_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q3_b { get; set; }


        [Display(Name = "Q4.Je mtoto ameshaanza kupewa vyakula vingine vilaini zaidi ya maziwa ya mama?")]
        public EFMOK1 Q4 { get; set; }

        [Display(Name = "Q8.Je mtoto ameshalazwa hospitalini tangu ulipokuja kliniki kwa mara ya mwisho?")]
        public EFMOK1 Q8 { get; set; }

        [Display(Name = "Tatizo")]
        public string Q8_1 { get; set; }

        [Display(Name = "Q9.Nani anayemuangalia na kukaa na mtoto zaidi kwa muda wa mchana?")]
        public EFMOK1 Q9 { get; set; }

        [Display(Name = "taja")]
        public string Q9_1 { get; set; }

    }
    public enum EFMTKSex
    {
        [Display(Name = "Me")]
        E1 = 1,
        [Display(Name = "Ke")]
        E2 = 2
    }

    public enum EFMOK1
    {
        [Display(Name = "0. Hapana")]
        No = 0,
        [Display(Name = "1. Ndiyo")]
        Yes = 1


    }
    public enum EFMOK9
    {
        [Display(Name = "1.Mama")]
        E1= 1,
        [Display(Name = "2.Binti anayesaidia kazi za nyumbani")]
        E2 = 2,
        [Display(Name = "3.Baba wa mtoto")]
        E3 = 3,
        [Display(Name = "4.Wengine")]
        E4 = 4

    }
}
