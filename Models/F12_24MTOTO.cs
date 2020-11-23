using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class F12_24MTOTO:EntityData
            {

        [Display(Name = "ID Number")]
        [Range(10, 60, ErrorMessage = "Check Age?")]
        public uint? IDNumber { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Tarehe { get; set; }


        [Display(Name = "Sex")]
        public EFMTKSex SexMt { get; set; }

        [Display(Name = "Date of birth ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? TareheKuzaliwa { get; set; }

        [Display(Name = "Age of the child in months ")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? UmriMtotoMiezi { get; set; }

        [Display(Name = "Q1. Is the baby still breastfeeding?")]
        public EFMOK1 Q1 { get; set; }

        [Display(Name = "Age stopped breastfeeding in months")]
        [Range(1, 60, ErrorMessage = "months")]
        public uint? Q1_1 { get; set; }

        [Display(Name = "Q2. If not breastfeeding, why?")]
        public string Q2 { get; set; }

        [Display(Name = "Q3. Has the child been sick since the last visit?")]
        public EFMOK1 Q3 { get; set; }

        [Display(Name = "Specify problem")]
        public string Q3_1 { get; set; }

        [Display(Name = "Q4. Has the child been admitted since the last visit?")]
        public EFMOK1 Q4 { get; set; }

        [Display(Name = "Specify problem")]
        public string Q4_1 { get; set; }

        [Display(Name = "Q5. Do you specially prepare food for your child separate from adults?")]
        public EFMOK1 Q5 { get; set; }

        [Display(Name = "Q6.Type of food given  to child")]
        public EFMO12_6 Q6 { get; set; }

        [Display(Name = "Q7. If given adult food, do they get their own portion?	")]
        public EFMOK1 Q7 { get; set; }

        [Display(Name = "Q8.How many times do you feed your child per day")]
        [Range(1, 60, ErrorMessage = "months")]
        public uint? Q8 { get; set; }

        //9.What foods do you feed your child?

        //1

        [Display(Name = "1. Cows milk")]
        public string Q9_1_a { get; set; }

        [Display(Name = "Morning")]
         public EFMOK1 Q9_1_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_1_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_1_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_1_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_1_f { get; set; }


        //2
        [Display(Name = "2. Plain porridge")]
        public string Q9_2_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_2_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_2_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_2_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_2_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_2_f { get; set; }

        //3
        [Display(Name = "3. Mixed porridge")]
        public string Q9_3_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_3_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_3_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_3_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_3_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_3_f { get; set; }

        //4
        [Display(Name = "4. Ugali")]
        public string Q9_4_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_4_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_4_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_4_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_4_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_4_f { get; set; }

        //5
        [Display(Name = "5. Stew")]
        public string Q9_5_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_5_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_5_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_5_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_5_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_5_f { get; set; }

        //6
        [Display(Name = "6. Fruit (Type)")]
        public string Q9_6_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_6_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_6_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_6_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_6_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_6_f { get; set; }

        //7
        [Display(Name = "7.  ")]
        public string Q9_7_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_7_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_7_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_7_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_7_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_7_f { get; set; }

        //8
        [Display(Name = "7.  ")]
        public string Q9_8_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_8_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_8_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_8_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_8_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_8_f { get; set; }
        //9
        [Display(Name = "9.  ")]
        public string Q9_9_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_9_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_9_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_9_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_9_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_9_f { get; set; }

        //10
        [Display(Name = "10.  ")]
        public string Q9_10_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_10_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_10_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_10_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_10_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_10_f { get; set; }

        //11
        [Display(Name = "11.  ")]
        public string Q9_11_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_11_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_11_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_11_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_11_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_11_f { get; set; }

        //12
        [Display(Name = "12.  ")]
        public string Q9_12_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_12_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_12_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_12_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_12_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_12_f { get; set; }

        //13
        [Display(Name = "13.  ")]
        public string Q9_13_a { get; set; }

        [Display(Name = "Morning")]
        public EFMOK1 Q9_13_b { get; set; }
        [Display(Name = "Noon")]
        public EFMOK1 Q9_13_c { get; set; }
        [Display(Name = "Evening")]
        public EFMOK1 Q9_13_d { get; set; }
        [Display(Name = "Night")]
        public EFMOK1 Q9_13_e { get; set; }
        [Display(Name = "Snacks/Other times")]
        public EFMOK1 Q9_13_f { get; set; }

        [Display(Name = "Q10. Does your child eat fish?")]
        public EFMOK1 Q10 { get; set; }

        [Display(Name = "If yes, frequency")]
        public EFMO12_10 Q10_1 { get; set; }

        [Display(Name = "Q11.Does your child eat meat?")]
        public EFMOK1 Q11 { get; set; }

        [Display(Name = "If yes, frequency")]
        public EFMO12_10 Q11_1 { get; set; }

        [Display(Name = "Q12.Do you use oil to prepare your child’s food?")]
        public EFMOK1 Q12 { get; set; }

        [Display(Name = "If yes, types")]
        public EFMO12_12 Q12_1 { get; set; }

        //13.Which vegetables do you give your child at least once a week?
        [Display(Name = "1. Cabbage")]
        public EFMOK1? Q13_1 { get; set; }
        [Display(Name = "2. Spinach")]
        public EFMOK1? Q13_2 { get; set; }
        [Display(Name = "3. Pumpkin leaves (majani ya maboga)")]
        public EFMOK1? Q13_3 { get; set; }
        [Display(Name = "4. Potato leaves  (tembele)")]
        public EFMOK1? Q13_4 { get; set; }
        [Display(Name = "5. Beans leaves")]
        public EFMOK1? Q13_5 { get; set; }
        [Display(Name = "6. Mchicha (DGLV)")]
        public EFMOK1? Q13_6 { get; set; }
        [Display(Name = "7. Carrots")]
        public EFMOK1? Q13_7 { get; set; }

        [Display(Name = "8. Others (please state)")]
        public string Q13_8 { get; set; }

        //14.Which staple foods do you give your child regularly (at least twice a week)

        [Display(Name = "1. Maize porridge")]
        public EFMOK1? Q14_1 { get; set; }
        [Display(Name = "2. Mixed maize porridge")]
        public EFMOK1? Q14_2 { get; set; }
        [Display(Name = "3. Ugali")]
        public EFMOK1? Q14_3 { get; set; }
        [Display(Name = "4. Stew (with onions and tomatoes)")]
        public EFMOK1? Q14_4 { get; set; }
        [Display(Name = "5. Bananas/Mtori")]
        public EFMOK1? Q14_5 { get; set; }
        [Display(Name = "6. Potatoes")]
        public EFMOK1? Q14_6 { get; set; }
        [Display(Name = "7. Legumes/beans")]
        public EFMOK1? Q14_7 { get; set; }
        [Display(Name = "8. Rice")]
        public EFMOK1? Q14_8 { get; set; }
        [Display(Name = "9. Eggs")]
        public EFMOK1? Q14_9 { get; set; }
        [Display(Name = "10. Others (please state)")]
        public string Q14_10 { get; set; }

        //15.Who does the main care of  your child for the following duties? Tick appropriate answer

        //a).Preparing meals         
        [Display(Name = "1. Mother")]
        public bool Q15_a_1 { get; set; }

        [Display(Name = "2. House help")]
        public bool Q15_a_2 { get; set; }

        [Display(Name = "3. Siblings")]
        public bool Q15_a_3 { get; set; }

        [Display(Name = "4. Other")]
        public bool Q15_a_4 { get; set; }

        [Display(Name = "Other")]
        public string Q15_a_5 { get; set; }

        //b).Feeding the child         
        [Display(Name = "1. Mother")]
        public bool Q15_b_1 { get; set; }

        [Display(Name = "2. House help")]
        public bool Q15_b_2 { get; set; }

        [Display(Name = "3. Siblings")]
        public bool Q15_b_3 { get; set; }

        [Display(Name = "4. Other")]
        public bool Q15_b_4 { get; set; }

        [Display(Name = "Other")]
        public string Q15_b_5 { get; set; }

        //c).Dressing the child         
        [Display(Name = "1. Mother")]
        public bool Q15_c_1 { get; set; }

        [Display(Name = "2. House help")]
        public bool Q15_c_2 { get; set; }

        [Display(Name = "3. Siblings")]
        public bool Q15_c_3 { get; set; }

        [Display(Name = "4. Other")]
        public bool Q15_c_4 { get; set; }

        [Display(Name = "Other")]
        public string Q15_c_5 { get; set; }

        //1.General
        [Display(Name = "a. Pallor")]
        public EFMOK1 Q10_a { get; set; }
        [Display(Name = "b. Hair changes")]
        public EFMOK1 Q10_b { get; set; }
        [Display(Name = "c. Oedema")]
        public EFMOK1 Q10_c { get; set; }
        [Display(Name = "d. Parotid enlargement")]
        public EFMOK1 Q10_d { get; set; }
        [Display(Name = "e. Scabies")]
        public EFMOK1 Q10_e { get; set; }

        //2. Lymphadenopathy
        [Display(Name = "a. Cervical")]
        public EFMOK1 Q11_a { get; set; }
        [Display(Name = "b. Axilla")]
        public EFMOK1 Q11_b { get; set; }
        [Display(Name = "c. Inguinal")]
        public EFMOK1 Q11_c { get; set; }

        //3. Mouth
        [Display(Name = "a. Oral thrush")]
        public EFMOK1 Q12_a { get; set; }
        [Display(Name = "b. Oropharyngeal ulcer")]
        public EFMOK1 Q12_b { get; set; }
        [Display(Name = "c. Drooling saliva frequently")]
        public EFMOK1 Q12_c { get; set; }

        //4.Respiratory system
        [Display(Name = "a. Respiratory rate > 40/min")]
        public EFMOK1 Q13_a { get; set; }
        [Display(Name = "b. Any subcostal or intercostal recession")]
        public EFMOK1 Q13_b { get; set; }
        [Display(Name = "c. Any night sweats in the last 6 weeks")]
        public EFMOK1 Q13_c { get; set; }
        [Display(Name = "d. Does your baby get tired when feeding")]
        public EFMOK1 Q13_d { get; set; }
        [Display(Name = "e. Has your baby had a chest X-ray done in the past 6 weeks")]
        public EFMOK1 Q13_e { get; set; }
        [Display(Name = "f. If yes, was it abnormal")]
        public EFMOK1 Q13_f { get; set; }

        //5. Gastro-intestinal Tract
        [Display(Name = "a. Hepatomegaly")]
        public EFMOK1 Q14_a { get; set; }

        [Display(Name = "b. Splenomegaly")]
        public EFMOK1 Q14_b { get; set; }

        [Display(Name = "c. Underweight	(wt ≤ 3rd centile)")]
        public EFMOK1 Q14_c { get; set; }

        [Display(Name = "d. Stunted (length ≤ 3rd centile)")]
        public EFMOK1 Q14_d { get; set; }

        [Display(Name = "e. Weight(Kg )")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q14_e { get; set; }

        [Display(Name = "f. Length(Cm)")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q14_f { get; set; }

        [Display(Name = "g. Head circumference(Cm)")]
        [Range(10, 60, ErrorMessage = "Check weight?")]
        public uint? Q14_g { get; set; }

        //6. Early Triad Assessment / Neurological Status

        //a. Palate
        [Display(Name = "i. High Arched")]
        public EFMOK1 Q15_a { get; set; }

        [Display(Name = "ii. Cleft / Other")]
        public EFMOK1 Q15_b { get; set; }
        //b. Hands

        [Display(Name = "i. Adducted Thumbs")]
        public EFMOK1 Q15_c { get; set; }

        [Display(Name = "ii. Fisting")]
        public EFMOK1 Q15_d { get; set; }

        //c. Truncal tone

        [Display(Name = "i. Normal")]
        public EFMOK1 Q15_e { get; set; }

        [Display(Name = "ii. Hyperextension")]
        public EFMOK1 Q15_f { get; set; }

        [Display(Name = "iii. Floppy (↓ tone)")]
        public EFMOK1 Q15_g { get; set; }

        [Display(Name = "d. Overlapping cranial sutures")]
        public EFMOK1 Q15_h { get; set; }

        //7. Neurosensory
        [Display(Name = "a. Can your child hear?")]
        public EFMOK1 Q16_a { get; set; }
        [Display(Name = "b. Can your child see?")]
        public EFMOK1 Q16_b { get; set; }
        [Display(Name = "c. Is your child happy?")]
        public EFMOK1 Q16_c { get; set; }

        //8. BINS test result (at 3,6,9 & 12 month assessment only)
        [Display(Name = "a. Low Risk")]
        public EFMOK1 Q17_a { get; set; }
        [Display(Name = "b. Moderate Risk")]
        public EFMOK1 Q17_b { get; set; }
        [Display(Name = "c. High Risk")]
        public EFMOK1 Q17_c { get; set; }

        [Display(Name = "Problems/ Diagnosis")]
        public string ProblemsDsis { get; set; }

        [Display(Name = "Medication prescribed")]
        public string MedicationPres { get; set; }


        [Display(Name = "Date of next visit	")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateNext { get; set; }

    }
    public enum EFMO12_6
    {
        [Display(Name = "1. Adult diet")]
        E1 = 1,
        [Display(Name = "2. Pureed diet (semisolids)")]
        E2 = 2,
        [Display(Name = "3. Liquid only")]
        E3 = 3


    }
    public enum EFMO12_10
    {
        [Display(Name = "1. Daily- 3 times a week")]
        E1 = 1,
        [Display(Name = "2. Once a week")]
        E2 = 2,
        [Display(Name = "3. Once a fortnight")]
        E3 = 3,
        [Display(Name = "4. Monthly")]
        E4 = 4,
        [Display(Name = "5. Rarely")]
        E5 = 5
    }
    public enum EFMO12_12
    {
        [Display(Name = "1. Vegetable oil")]
        E1 = 1,
        [Display(Name = "2. Palm oil")]
        E2 = 2,
        [Display(Name = "3. Margarines")]
        E3 = 3,
        [Display(Name = "4. Coconut milk")]
        E4 = 4
        
    }
}
