using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class FTISAMTOTO:EntityData
    {

        [Display(Name = "ID Number")]
        [Range(1, 1000, ErrorMessage = "ID Number maximum 1000?")]
        public uint? IDNumber { get; set; }

        [Display(Name = "Tarehe")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Tarehe { get; set; }


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

        [Display(Name = "ameacha (miezi)")]
        [Range(1, 60, ErrorMessage = "(miezi)?")]
        public uint? Q1_1 { get; set; }

        //[Display(Name = "-Je alianza kunyonya muda gani baada ya kuzaliwa? Baada ya masaa")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q1_a { get; set; }

        //[Display(Name = "-Je mama alimpa maziwa ya mwanzo (colostrum)?")]
        //public EFMOK1 Q1_b { get; set; }

        //[Display(Name = "-Je alimpa kitu chochote kama maji au chai kabla ya kuanza kumyonyesha? ")]
        //public EFMOK1 Q1_c { get; set; }

        [Display(Name = "2.Kama hapana, ni kwanini?")]
        public string Q2 { get; set; }

        //[Display(Name = "Q3. Je mtoto ameshaanza kupewa vyakula vingine zaidi ya maziwa ya mama?")]
        //public EFMOK1 Q3 { get; set; }

        //[Display(Name = "Tangu alipokuwa na mwezi/miezi")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q3_a { get; set; }

        //[Display(Name = "Mara ngapi kwa siku")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q3_b { get; set; }


        //[Display(Name = "Q4.Je mtoto ameshaanza kupewa vyakula vingine vilaini zaidi ya maziwa ya mama?")]
        //public EFMOK1 Q4 { get; set; }

        // 3.Je mtoto anapewa vyakula gani vingine zaidi ya maziwa ya mama?	
        //(Andika vyote anavyotaja  kwenye nafasi  iliyoachwa)


        //1

        [Display(Name = "1.")]
        public string Q1_1_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q1_1_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q1_1_c { get; set; }

        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q1_1_e { get; set; }

        //2
        [Display(Name = "2.")]
        public string Q2_2_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q2_2_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q2_2_c { get; set; }



        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q2_2_e { get; set; }


        //3
        [Display(Name = "3.")]
        public string Q3_3_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q3_3_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q3_3_c { get; set; }



        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q3_3_e { get; set; }

        //4
        [Display(Name = "4.Juice ya")]
        public string Q4_4_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q4_4_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q4_4_c { get; set; }

        //[Display(Name = "> 125 mls")]
        //public string Q5_4_d { get; set; }

        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q4_4_e { get; set; }


        //5
        [Display(Name = "5.")]
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

        //6
        [Display(Name = "6.")]
        public string Q6_5_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q6_5_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q6_5_c { get; set; }

        //[Display(Name = "> 125 mls")]
        //public string Q5_5_d { get; set; }

        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q6_5_e { get; set; }

        //6
        [Display(Name = "7.")]
        public string Q7_5_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q7_5_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q7_5_c { get; set; }

        //[Display(Name = "> 125 mls")]
        //public string Q5_5_d { get; set; }

        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q7_5_e { get; set; }

        //8
        [Display(Name = "8.")]
        public string Q8_5_a { get; set; }

        [Display(Name = "Mara ngapi kwa siku")]
        [Range(1, 12, ErrorMessage = "Mara ngapi kwa siku?")]
        public uint? Q8_5_b { get; set; }

        [Display(Name = "mls")]
        public EFMOK5? Q8_5_c { get; set; }

        //[Display(Name = "> 125 mls")]
        //public string Q5_5_d { get; set; }

        [Display(Name = "Umri alipoanzishwa")]
        [Range(1, 10, ErrorMessage = "Umri alipoanzishwa?")]
        public uint? Q8_5_e { get; set; }

       

       


        //Q4.Je mtoto ameshapata matatizo haya yafuatayo tangu ulipokuja kliniki kwa mara ya mwisho?



        [Display(Name = "1. Fever   Homa au malaria	")]
        public EFMOK1? Q4_1 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q4_1_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_1_b { get; set; }

        //Cough   Kukohoa au kichomi
        [Display(Name = "2.	Cough   Kukohoa au kichomi")]
        public EFMOK1? Q4_2 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q4_2_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_2_b { get; set; }

        // Diarrhoea   Kuharisha
        [Display(Name = "3.	Diarrhoea   Kuharisha")]
        public EFMOK1? Q4_3 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q4_3_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_3_b { get; set; }

        // Ear discharge  Uchafu/usaha toka masikioni		
        [Display(Name = "4.Ear discharge  Uchafu/usaha toka masikioni")]
        public EFMOK1? Q4_4 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q4_4_aa { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_4_b { get; set; }

        // Oral thrush/ulcer   Utando  au vidonda mdomoni		
        [Display(Name = "5.Oral thrush/ulcer   Utando  au vidonda mdomoni")]
        public EFMOK1? Q4_5 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q4_5_aa { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_5_b { get; set; }

        // Skin rashes   Upele au tatizo la ngozi		
        [Display(Name = "6.Skin rashes   Upele au tatizo la ngozi")]
        public EFMOK1? Q4_6 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q4_6_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_6_b { get; set; }

        // Convulsions    Degedege		
        [Display(Name = "7.Convulsions    Degedege")]
        public EFMOK1? Q4_7 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q4_7_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_7_b { get; set; }

        //Other   Mengine, taja		
        [Display(Name = "8.Other   Mengine, taja")]
        public string Q4_8 { get; set; }

        [Display(Name = "Siku")]
        public EFMOK7? Q4_8_a { get; set; }

        //[Display(Name = "> siku 14")]
        //[Range(10, 60, ErrorMessage = "Check weight?")]
        //public uint? Q7_8_b { get; set; }




        [Display(Name = "Q5.Je mtoto ameshalazwa hospitalini tangu ulipokuja kliniki kwa mara ya mwisho?")]
        public EFMOK1? Q5 { get; set; }

        [Display(Name = "Tatizo")]
        public string Q5_1 { get; set; }

        //[Display(Name = "Q8.Nani anayemuangalia na kukaa na mtoto zaidi kwa muda wa mchana?")]
        //public EFMOK9 Q8 { get; set; }

        //[Display(Name = "taja")]
        //public string Q8_1 { get; set; }


        //7.Nani anayefanya shughuli zifuatazo zaidi wakati wa mchana?	Tiki panapostahili


        //a).Kumuangalia mtoto      
        [Display(Name = "1. Mama")]
        public bool Q6_a_1 { get; set; }

        [Display(Name = "2. Binti wa nyumbani")]
        public bool Q6_a_2 { get; set; }

        [Display(Name = "3. Dada/kaka zake")]
        public bool Q6_a_3 { get; set; }

        [Display(Name = "4. Wengine")]
        public bool Q6_a_4 { get; set; }

        [Display(Name = "Wengine")]
        public string Q6_a_5 { get; set; }

        //b).Kumbadilisha nepi     
        [Display(Name = "1. Mama")]
        public bool Q6_b_1 { get; set; }

        [Display(Name = "2. Binti wa nyumbani")]
        public bool Q6_b_2 { get; set; }

        [Display(Name = "3. Dada/kaka zake")]
        public bool Q6_b_3 { get; set; }

        [Display(Name = "4. Wengine")]
        public bool Q6_b_4 { get; set; }

        [Display(Name = "Wengine")]
        public string Q6_b_5 { get; set; }

        //(b).Kutayarisha chakula cha mtoto   
        [Display(Name = "1. Mama")]
        public bool Q6_c_1 { get; set; }

        [Display(Name = "2. Binti wa nyumbani")]
        public bool Q6_c_2 { get; set; }

        [Display(Name = "3. Dada/kaka zake")]
        public bool Q6_c_3 { get; set; }

        [Display(Name = "4. Wengine")]
        public bool Q6_c_4 { get; set; }

        [Display(Name = "Wengine")]
        public string Q6_c_5 { get; set; }

        //c).Kumlisha mtoto          
        [Display(Name = "1. Mama")]
        public bool Q6_d_1 { get; set; }

        [Display(Name = "2. Binti wa nyumbani")]
        public bool Q6_d_2 { get; set; }

        [Display(Name = "3. Dada/kaka zake")]
        public bool Q6_d_3 { get; set; }

        [Display(Name = "4. Wengine")]
        public bool Q6_d_4 { get; set; }

        [Display(Name = "Wengine")]
        public string Q6_d_5 { get; set; }




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

        //8. BINS test result (at 3,6,9 & 12 month assessment only)
        [Display(Name = "a. Low Risk")]
        public EFMOK1? Q17_a { get; set; }
        [Display(Name = "b. Moderate Risk")]
        public EFMOK1? Q17_b { get; set; }
        [Display(Name = "c. High Risk")]
        public EFMOK1? Q17_c { get; set; }

        [Display(Name = "Problems/ Diagnosis")]
        public string ProblemsDsis { get; set; }

        [Display(Name = "Medication prescribed")]
        public string MedicationPres { get; set; }


        [Display(Name = "Date of 12 months visit")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date6Month { get; set; }
    }
}
