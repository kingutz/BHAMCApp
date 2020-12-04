using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class FKMTOTO : EntityData
    {

        [Display(Name = "Tarehe")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Tarehe { get; set; }

        [Display(Name = "ID Number")]
        [Range(1, 1000, ErrorMessage = "ID Number?")]
        public uint? IDNumber { get; set; }


        [Display(Name = "Sex")]
        public EFMTKSex SexMt { get; set; }

        [Display(Name = "Tarehe ya kuzaliwa")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? TareheKuzaliwa { get; set; }

        [Display(Name = "Umri (miezi)")]
        [Range(1, 60, ErrorMessage = "Umri (miezi)?")]
        public uint? UmriMtotoMiezi { get; set; }

        [Display(Name = "Q1.Je mtoto bado ananyonyeshwa maziwa ya mama?")]
        public EFMOK1 Q1 { get; set; }

        [Display(Name = "-Je alianza kunyonya muda gani baada ya kuzaliwa? Baada ya masaa")]
        [Range(1, 72, ErrorMessage = "masaa ya kunyonya?")]
        public uint? Q1_a { get; set; }

        [Display(Name = "-Je mama alimpa maziwa ya mwanzo (colostrum)?")]
        public EFMOK1? Q1_b { get; set; }

        [Display(Name = "-Je alimpa kitu chochote kama maji au chai kabla ya kuanza kumyonyesha? ")]
        public EFMOK1? Q1_c { get; set; }

        [Display(Name = "2.Kama hapana, ni kwanini?")]
        public string Q2 { get; set; }

        [Display(Name = "3.Zaidi ya maziwa ya mama, je mtoto anapewa maji ya kunywa?")]
        public EFMOK1? Q3 { get; set; }

        [Display(Name = "Tangu alipokuwa na wiki")]
        [Range(1, 52, ErrorMessage = "Tangu alipokuwa na wiki?")]
        public uint? Q3_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q3_b { get; set; }


        [Display(Name = "Q4.Je mtoto ameshaanza kupewa vyakula vingine vilaini zaidi ya maziwa ya mama?")]
        public EFMOK1? Q4 { get; set; }

        //[Display(Name = "5.Aina ya vyakula anavyopewa")]

        //1

        [Display(Name = "1.Maziwa ya")]
        public string Q5_1_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q5_1_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q5_1_c { get; set; }
               
        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q5_1_e { get; set; }

        //2
        [Display(Name = "2.Uji  wa")]
        public string Q5_2_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q5_2_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q5_2_c { get; set; }

        

        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q5_2_e { get; set; }


        //3
        [Display(Name = "3.Supu ya")]
        public string Q5_3_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q5_3_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q5_3_c { get; set; }

       

        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q5_3_e { get; set; }

        //4
        [Display(Name = "4.Juice ya")]
        public string Q5_4_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q5_4_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q5_4_c { get; set; }

        //[Display(Name = "> 125 mls")]
        //public string Q5_4_d { get; set; }

        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q5_4_e { get; set; }


        //5
        [Display(Name = "5.Vingine")]
        public string Q5_5_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q5_5_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q5_5_c { get; set; }

        //[Display(Name = "> 125 mls")]
        //public string Q5_5_d { get; set; }

        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q5_5_e { get; set; }

        [Display(Name = "Q6. Kitovu?")]
        public EFMOK6? Q6 { get; set; }

        //Q7.Je mtoto ameshapata matatizo haya yafuatayo tangu ulipokuja kliniki kwa mara ya mwisho?



        [Display(Name = "1. Fever   Homa au malaria	")]
        public EFMOK1? Q7_1 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q7_1_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_1_b { get; set; }

        //Cough   Kukohoa au kichomi
        [Display(Name = "2.	Cough   Kukohoa au kichomi")]
        public EFMOK1? Q7_2 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q7_2_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_2_b { get; set; }

        // Diarrhoea   Kuharisha
        [Display(Name = "3.	Diarrhoea   Kuharisha")]
        public EFMOK1? Q7_3 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q7_3_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_3_b { get; set; }

        // Ear discharge  Uchafu/usaha toka masikioni		
        [Display(Name = "4.Ear discharge  Uchafu/usaha toka masikioni")]
        public EFMOK1? Q7_4 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q7_4_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_4_b { get; set; }

        // Oral thrush/ulcer   Utando  au vidonda mdomoni		
        [Display(Name = "5.Oral thrush/ulcer   Utando  au vidonda mdomoni")]
        public EFMOK1? Q7_5 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q7_5_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_5_b { get; set; }

        // Skin rashes   Upele au tatizo la ngozi		
        [Display(Name = "6.Skin rashes   Upele au tatizo la ngozi")]
        public EFMOK1? Q7_6 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q7_6_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_6_b { get; set; }

        // Convulsions    Degedege		
        [Display(Name = "7.Convulsions    Degedege")]
        public EFMOK1? Q7_7 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q7_7_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_7_b { get; set; }

        //Other   Mengine, taja		
        [Display(Name = "8.Other   Mengine, taja")]
        public string Q7_8 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q7_8_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_8_b { get; set; }




        [Display(Name = "Q8.Je mtoto ameshalazwa hospitalini tangu ulipokuja kliniki kwa mara ya mwisho?")]
        public EFMOK1 Q8 { get; set; }

        [Display(Name = "Tatizo")]
        public string Q8_1 { get; set; }

        [Display(Name = "Q9.Nani anayemuangalia na kukaa na mtoto zaidi kwa muda wa mchana?")]
        public EFMOK9 Q9 { get; set; }

        [Display(Name = "taja")]
        public string Q9_1 { get; set; }

        //1.General
        [Display(Name = "a. Pallor")]
        public EFMOK1? Q10_a { get; set; }
        [Display(Name = "b. Hair changes")]
        public EFMOK1? Q10_b { get; set; }
        [Display(Name = "c. Oedema")]
        public EFMOK1? Q10_c { get; set; }
        [Display(Name = "d. Parotid enlargement")]
        public EFMOK1? Q10_d { get; set; }
        [Display(Name = "e. Scabies")]
        public EFMOK1? Q10_e { get; set; }

        //2. Lymphadenopathy
        [Display(Name = "a. Cervical")]
        public EFMOK1? Q11_a { get; set; }
        [Display(Name = "b. Axilla")]
        public EFMOK1? Q11_b { get; set; }
        [Display(Name = "c. Inguinal")]
        public EFMOK1? Q11_c { get; set; }

        //3. Mouth
        [Display(Name = "a. Oral thrush")]
        public EFMOK1? Q12_a { get; set; }
        [Display(Name = "b. Oropharyngeal ulcer")]
        public EFMOK1? Q12_b { get; set; }
        [Display(Name = "c. Drooling saliva frequently")]
        public EFMOK1? Q12_c { get; set; }

        //4.Respiratory system
        [Display(Name = "a. Respiratory rate > 40/min")]
        public EFMOK1? Q13_a { get; set; }
        [Display(Name = "b. Any subcostal or intercostal recession")]
        public EFMOK1? Q13_b { get; set; }
        [Display(Name = "c. Any night sweats in the last 6 weeks")]
        public EFMOK1? Q13_c { get; set; }
        [Display(Name = "d. Does your baby get tired when feeding")]
        public EFMOK1? Q13_d { get; set; }
        [Display(Name = "e. Has your baby had a chest X-ray done in the past 6 weeks")]
        public EFMOK1? Q13_e { get; set; }
        [Display(Name = "f. If yes, was it abnormal")]
        public EFMOK1? Q13_f { get; set; }

        //5. Gastro-intestinal Tract
        [Display(Name = "a. Hepatomegaly")]
        public EFMOK1? Q14_a { get; set; }

        [Display(Name = "b. Splenomegaly")]
        public EFMOK1? Q14_b { get; set; }

        [Display(Name = "c. Underweight	(wt ≤ 3rd centile)")]
        public EFMOK1? Q14_c { get; set; }

        [Display(Name = "d. Stunted (length ≤ 3rd centile)")]
        public EFMOK1? Q14_d { get; set; }

        [Display(Name = "e. Weight(Kg )")]
        [Range(1, 20, ErrorMessage = "weight?")]
        public uint? Q14_e { get; set; }

        [Display(Name = "f. Length(Cm)")]
        [Range(1, 60, ErrorMessage = "Length(Cm?")]
        public uint? Q14_f { get; set; }

        [Display(Name = "g. Head circumference(Cm)")]
        [Range(1, 60, ErrorMessage = "circumference(Cm)?")]
        public uint? Q14_g { get; set; }

        //6. Early Triad Assessment / Neurological Status

        //a. Palate
        [Display(Name = "i. High Arched")]
        public EFMOK1? Q15_a { get; set; }
      
        [Display(Name = "ii. Cleft / Other")]
        public EFMOK1? Q15_b { get; set; }
        //b. Hands

        [Display(Name = "i. Adducted Thumbs")]
        public EFMOK1? Q15_c { get; set; }

        [Display(Name = "ii. Fisting")]
        public EFMOK1? Q15_d { get; set; }

        //c. Truncal tone

        [Display(Name = "i. Normal")]
        public EFMOK1? Q15_e { get; set; }

        [Display(Name = "ii. Hyperextension")]
        public EFMOK1? Q15_f { get; set; }

        [Display(Name = "iii. Floppy (↓ tone)")]
        public EFMOK1? Q15_g { get; set; }

        [Display(Name = "d. Overlapping cranial sutures")]
        public EFMOK1? Q15_h { get; set; }

        //7. Neurosensory
        [Display(Name = "a. Can your child hear?")]
        public EFMOK1? Q16_a { get; set; }
        [Display(Name = "b. Can your child see?")]
        public EFMOK1? Q16_b { get; set; }
        [Display(Name = "c. Is your child happy?")]
        public EFMOK1? Q16_c { get; set; }

        [Display(Name = "Problems/ Diagnosis")]
        public string ProblemsDsis { get; set; }

        [Display(Name = "Medication prescribed")]
        public string MedicationPres { get; set; }


        [Display(Name = "Date of 3 months visit")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date3Month { get; set; }
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
    
        public enum EFMOK5
    {
        [Display(Name = "1. < 125mls")]
        E1 = 1,
        [Display(Name = "2. > 125mls")]
        E2 = 2


    }
    public enum EFMOK6
    {
        [Display(Name = "1. Kimepona")]
        E1 = 1,
        [Display(Name = "2. Kina uambukizo")]
        E2 = 2


    }
    public enum EFMOK7
    {
        [Display(Name = "1. <siku 14")]
        E1 = 1,
        [Display(Name = "2. >siku 14")]
        E2 = 2


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
