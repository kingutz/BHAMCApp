using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class Bhamc: EntityData
    {
        //......APPENDEX 1A - QUESTIONNAIRE....
        //public uint ID { get; set; }

        [Display(Name = "Questionnaire No")]
        public int QuestionnaireNo { get; set; }

        [Display(Name = "Number of antenatal care visit")]
        public string AntenatalCare { get; set; }

        [Display(Name = "Gestational age (GA)")]
        public string GestationalAge { get; set; }

        [Display(Name = "Date of last normal menstruation ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateMenstruation { get; set; }

        [Display(Name = "Expected date of delivery")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ExpectedDate { get; set; }

        [Display(Name = "Name of Hospital")]
        public string HospitalName { get; set; }

        [Display(Name = "Hospital expected to bring the baby for post-natal care")]
        public string PostNatalCare { get; set; }

        [Display(Name = "Name of interviewer")]
        public string InterviewerName { get; set; }

        [Display(Name = "Date of interview ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InterviewDate { get; set; }

        //'''''SOCIO-DEMOGRAPHIC CHARACTERISTICS'''''''''''''''

        [Display(Name = "Q1. Month and year of birth ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Q1 { get; set; }

        [Display(Name = "Q2. Age (years)")]
        [Range(10,60, ErrorMessage = "Check Age?")]
        public uint? Q2 {get; set; }


        [Display(Name = "Q3. What is your religion?")]
        public E3 Q3 { get; set; }

        [Display(Name = "4. Other(specify)")]
        public string OthersQ3 { get; set; }

        [Display(Name = "Q4. What is your tribe?")]
        public E4 Q4 { get; set; }

        [Display(Name = "4. Other(specify)")]
        public string OthersQ4 { get; set; }

        [Display(Name = "Q5. Marital status ")]
        public E5 Q5 { get; set; }

        [Display(Name = "Q6. Are you in polygamous marriage?")]
        public E6? Q6 { get; set; }


        [Display(Name = "Q7. How long have you being living together?")]
        [Range(1, 40, ErrorMessage = "check??")]
        public uint? Q7 { get; set; }

        [Display(Name = "Q8. What is the highest level of education? ")]
        public E8 Q8 { get; set; }

        [Display(Name = "Q9. Had you been employed in work which gave you monthly salary in the past 12 months?")]
        public E9 Q9 { get; set; }

        [Display(Name = "Q10. What is your occupation?")]
        public E10 Q10 { get; set; }

        [Display(Name = "6. Other(specify)")]
        public string OthersQ10 { get; set; }

        [Display(Name = "Q11. What is your approximate income per month?(Tanzanian shillings)")]
        [Range(1000, 5000000, ErrorMessage = "Amount!!!")]
        public uint? Q11 { get; set; }

        //Q12 Do you own the following? (write yes or no)

        [Display(Name = "1. Television")]
        public bool Q12_1 { get; set; }
        [Display(Name = "2. Radio")]
        public bool Q12_2 { get; set; }
        [Display(Name = "3. Fridge")]
        public bool Q12_3 { get; set; }
        [Display(Name = "4. Car")]
        public bool Q12_4 { get; set; }
        [Display(Name = "5. Bicycles")]
        public bool Q12_5 { get; set; }
        [Display(Name = "6. Motorcycles")]
        public bool Q12_6 { get; set; }
        [Display(Name = "7. Land")]
        public bool Q12_7 { get; set; }

        //[Display(Name = "Do you own the following? (write yes or no)")]
        //public E12 Q12 { get; set; }

        [Display(Name = "Q13. House ownership?")]
        public E13 Q13 { get; set; }

        [Display(Name = "5. Other(specify)")]
        public string OthersQ13 { get; set; }



        [Display(Name = "Q14.How much do you pay per month?")]
        [Range(1000, 3000000, ErrorMessage = "Amount!!!")]
        public uint? Q14 { get; set; }

        [Display(Name = "Q15. Walls of your house?")]
        public E15 Q15 { get; set; }

        [Display(Name = "5. Other(specify)")]
        public string OthersQ15 { get; set; }

        [Display(Name = "Q16. Toilet facility?")]
        public E16 Q16 { get; set; }

        [Display(Name = "Q17. Do you share the toilet with other family?")]
        public E9 Q17 { get; set; }

        [Display(Name = "Q18. Where do you get your water?")]
        public E18 Q18 { get; set; }

        [Display(Name = "5. Other(specify)")]
        public string OthersQ18 { get; set; }

        [Display(Name = "Q19. Does your house have electric supply?")]
        public E9 Q19 { get; set; }

        [Display(Name = "Q20. How frequent do get your meal?(breakfast inclusive)")]
        public E20 Q20 { get; set; }

        [Display(Name = "4. More than three(specify)")]
        public string OthersQ20 { get; set; }

        [Display(Name = "Q21. Do you drink alcohol?")]
        public E21 Q21 { get; set; }

        //[Display(Name = "Of what kind?")]
        //public E70 Q22 { get; set; }

        //[Display(Name = "4 More than three(specify)")]
        //public string OthersQ22 { get; set; }

        //Of what kind? Q22
        [Display(Name = "1. Local brew")]
        public bool Q22_1 { get; set; }
        [Display(Name = "2. Beer")]
        public bool Q22_2 { get; set; }
        [Display(Name = "3. Viroba/konyagi")]
        public bool Q22_3 { get; set; }
        [Display(Name = "4. Others")]
        public bool Q22_4 { get; set; }

        [Display(Name = "4. Other(specify)")]
        public string OthersQ22_4 { get; set; }

        [Display(Name = "Q23. Do you often travel away from your home?")]
        public E23 Q23 { get; set; }


        //..........REPRODUCTIVE HEALTH...........

        [Display(Name = "Q24. Gravida")]
        [Range(0, 15, ErrorMessage = "Not applicable!!")]
        public uint Q24{ get; set; }


        [Display(Name = "Q25. History of miscarriage/abortion")]
        public E9? Q25 { get; set; }

        [Display(Name = "Q26. Parity")]
        [Range(0, 15, ErrorMessage = "Not applicable!!")]
        public uint? Q26 { get; set; }

        [Display(Name = "Q27. History of stillbirth")]
        public E9? Q27 { get; set; }

        [Display(Name = "Q28. Did you give birth to live baby then died?")]
        public E9? Q28 { get; set; }

        [Display(Name = "Q29. Number of living children")]
        [Range(0, 20, ErrorMessage = "Not applicable!!")]
        public uint? Q29 { get; set; }


        [Display(Name = "Q30. What is the age of your last born(in years)")]
        [Range(0, 100, ErrorMessage = "Not applicable!!")]
        public uint? Q30 { get; set; }

        [Display(Name = "Q31. Did you delivered in the hospital/clinic?(your last born)")]
        public E9? Q31 { get; set; }


        [Display(Name = "Q32. Do all children of the same father? (including pregnancy")]
        public E9? Q32 { get; set; }

        [Display(Name = "(number of fathers)")]
        [Range(0, 20, ErrorMessage = "Not applicable!!")]
        public uint? Q32_1 { get; set; }

        [Display(Name = "Q33. Do you usually clean inside the vagina?(Elaborate the difference between vagina and vulva)")]
        public E9 Q33 { get; set; }

        [Display(Name = "Q34. Number of times per day")]
        public E34? Q34 { get; set; }

        [Display(Name = "Q35. What do you use")]
        public E35? Q35 { get; set; }

        [Display(Name = "4. Other(specify)")]
        public string OthersQ35 { get; set; }

        [Display(Name = "Q36. What do you use to wash with")]
        public E36? Q36 { get; set; }

        [Display(Name = "4. Other(specify)")]
        public string OthersQ36 { get; set; }


        [Display(Name = "Q37. Why do you wash inside the vagina and not only the vulva area?")]
        public string Q37 { get; set; }

        //.............INFORMATION ON PARTNER AND INFECTIOUS DISEASE..........
        [Display(Name = "Q38. Age at sexual debut?")]
        [Range(8, 20, ErrorMessage = "Not applicable!!")]
        public uint? Q38 { get; set; }

        [Display(Name = "Q39. Was it voluntary or involuntary?")]
        public E39 Q39 { get; set; }

        [Display(Name = "Q40. Including your current partner, how many partners did you have in the past 12 months?")]
        [Range(0, 100, ErrorMessage = "Not applicable!!")]
        public uint? Q40 { get; set; }

        [Display(Name = "Q41. How many partners did you have since sexual debut until now?")]
        [Range(0, 100, ErrorMessage = "Not applicable!!")]
        public uint? Q41 { get; set; }

        [Display(Name = "Q42. Have you ever used condom?")]
        public E42 Q42 { get; set; }

        // Q43 Have you been treated or got the following symptoms in the past 12 months?
        [Display(Name = "1. Abnormal vaginal discharge")]
        public bool Q43_1 { get; set; }
        [Display(Name = "2. Genital ulcers ")]
        public bool Q43_2 { get; set; }
        [Display(Name = "3. Genital itching")]
        public bool Q43_3 { get; set; }
        [Display(Name = "4. Genital warts")]
        public bool Q43_4 { get; set; }
        [Display(Name = "5. Painful micturation")]
        public bool Q43_5 { get; set; }
        [Display(Name = "6. Pain during sex")]
        public bool Q43_6 { get; set; }

        //...................HIV AND SYPHILIS TESTING AND PARTNER’S DISCLOSURE

        [Display(Name = "Q44. Have ever tested for HIV")]
        public E9 Q44 { get; set; }

        [Display(Name = "Q45. Did you test for HIV status in past pregnancies?")]
        public E9? Q45 { get; set; }


        [Display(Name = "Q46. HIV status")]
        public E46? Q46 { get; set; }

        [Display(Name = "Q47. Have you tested for HIV status in this (current)  pregnancy")]
        public E47 Q47 { get; set; }


        [Display(Name = "Q48. How many times have you tested for HIV status?")]
        [Range(0, 30, ErrorMessage = "Not applicable!!")]
        public uint? Q48 { get; set; }

        [Display(Name = "Q49. If tested in this pregnancy have you told your partner? ")]
        public E9 Q49 { get; set; }

        [Display(Name = "Q50. If no why?")]
        public string Q50 { get; set; }

        [Display(Name = "Q51. What time passed before telling your partner? (in days)")]
        [Range(1, 361, ErrorMessage = "Not applicable!!")]
        public uint? Q51 { get; set; }

        [Display(Name = "Q52. What was his response?")]
        public string Q52 { get; set; }

        [Display(Name = "Q53. Did your partner come to test for HIV in this clinic or any other place?")]
        public E9 Q53 { get; set; }

        [Display(Name = "Q54. If you tested positive")]
        public E46? Q54 { get; set; }

        //.......Q54 If you were tested positive
        [Display(Name = "When?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Q54_1 { get; set; }

        [Display(Name = "Before this pregnancy?")]
        public E9? Q54_2 { get; set; }

        [Display(Name = "Are you using drugs for PMTCT of HIV?(write name of the drug")]
        public E9? Q54_3 { get; set; }

        [Display(Name = "Write name of the drug")]
        public E9? Q54_4 { get; set; }

        [Display(Name = "Q55. Have you tested for syphilis?")]
        public E9 Q55 { get; set; }

        [Display(Name = "Q56. Syphilis status?")]
        public E46? Q56 { get; set; }

        //Q57 Can you discuss issues regarding HIV/AIDS with(tick the appropriate)

        [Display(Name = "1. Family member(s)")]
        public bool Q56_1 { get; set; }
        [Display(Name = "2. Spouse ")]
        public bool Q56_2 { get; set; }
        [Display(Name = "3. Friends")]
        public bool Q56_3 { get; set; }
        [Display(Name = "4. Farmer")]
        public bool Q56_4 { get; set; }
        [Display(Name = "5. Others(specify)")]
        public bool Q56_5 { get; set; }

        [Display(Name = "5 Others(specify)")]
        public string OthersQ56 { get; set; }

        //Q58 Have you ever discussed with your partner about matter relating to (tick were appropriate)
        [Display(Name = "1. Condom use")]
        public bool Q58_1 { get; set; }
        [Display(Name = "2. Sexual satisfaction/sexuality")]
        public bool Q58_2 { get; set; }
        [Display(Name = "3. About HIV ")]
        public bool Q58_3 { get; set; }
        [Display(Name = "4. About STIs")]
        public bool Q58_4 { get; set; }


        //Q59 Do you have any of the following symptoms? 
        [Display(Name = "1. Pain during urination")]
        public bool Q59_1 { get; set; }
        [Display(Name = "2. Vaginal discharge- a) white discharge b) yellow/green/brown discharge c) smelly discharge")]
        public bool Q59_2 { get; set; }
        [Display(Name = "3. Itching or soreness in private parts")]
        public bool Q59_3 { get; set; }
        [Display(Name = "4. Sores or ulcers in private parts")]
        public bool Q59_4 { get; set; }
        [Display(Name = "5. Warts on private parts")]
        public bool Q59_5 { get; set; }
        [Display(Name = "6. Pain during sex")]
        public bool Q59_6 { get; set; }


        [Display(Name = "Q60. Have you tested for syphilis in this pregnancy?")]
        public E9 Q60 { get; set; }

        //.......Q60 Did you receive treatment for STIs within the past 2 weeks?
        [Display(Name = "1. If Yes, Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Q60_1 { get; set; }

        [Display(Name = "1. Diagnosis")]
        public string Q60_2 { get; set; }

        [Display(Name = "1. Treatment")]
        public string Q60_3 { get; set; }

        //.....Q61 What symptoms have you been treated?
        [Display(Name = "1. Vaginal discharge")]
        public bool Q61_1 { get; set; }
        [Display(Name = "2. Sores or ulcers in private parts")]
        public bool Q61_2 { get; set; }
        [Display(Name = "3. Itching or soreness in private parts")]
        public bool Q61_3 { get; set; }
        [Display(Name = "4. Warts on private parts")]
        public bool Q61_4 { get; set; }
        [Display(Name = "5. Pain during urination")]
        public bool Q61_5 { get; set; }
        [Display(Name = "6. Pain during sex")]
        public bool Q61_6 { get; set; }

        [Display(Name = "Q62. If you are tested and found to be infected, will you be able to bring your partner for treatment?")]
        public E9 Q62 { get; set; }

        [Display(Name = "Q63. If not why?")]
        public string Q63 { get; set; }


        //......Q64 Who else would you tell that you have STI apart from your partner?

        [Display(Name = "1. Friend ")]
        public bool Q64_1 { get; set; }
        [Display(Name = "2. Family/relative")]
        public bool Q64_2 { get; set; }
        [Display(Name = "3. Work mate")]
        public bool Q64_3 { get; set; }
        [Display(Name = "4. Neighbour")]
        public bool Q64_4 { get; set; }
        [Display(Name = "5. Other")]
        public bool Q64_5 { get; set; }

        //........PARTNER’S INFORMATION..........
        //[Display(Name = "Q65. Age of your partner")]
        //public E65 Q65 { get; set; }

        [Display(Name = "Q65. Age of your partner")]
        [Range(0, 50, ErrorMessage = "Fill 999 if dont know")]
        public uint? Q65 { get; set; }

        [Display(Name = "Q66. What is his highest level of formal education attained?")]
        public E66 Q66 { get; set; }

        //[Display(Name = "fill 999 if you dont know")]
        //[Range(0, 1000, ErrorMessage = "Not applicable!!")]
        //public uint? Q65_1 { get; set; }

        [Display(Name = "Q67.Partner’s occupation?")]
        public E10 Q67 { get; set; }
        [Display(Name = "5. Others(specify)")]
        public string OthersQ67 { get; set; }

        [Display(Name = "Q68. Does your partner travel frequently outside the region")]
        public E9 Q68 { get; set; }

        //Q68 if Yes, per week/month
        [Display(Name = "if Yes, per week/month")]
        public E68Yes? Q68Yes { get; set; }

        [Display(Name = "Q69. Does your partner drink alcohol?")]
        public E21 Q69 { get; set; }

        //[Display(Name = "Of what kind?")]
        //public E70 Q70 { get; set; }

        //Of what kind? Q70
        [Display(Name = "1. Local brew")]
        public bool Q70_1 { get; set; }
        [Display(Name = "2. Beer")]
        public bool Q70_2 { get; set; }
        [Display(Name = "3. Viroba/konyagi")]
        public bool Q70_3 { get; set; }
        [Display(Name = "4. Others")]
        public bool Q70_4 { get; set; }

        [Display(Name = "4. Other(specify)")]
        public string OthersQ70_4 { get; set; }



        //.........MOTHER’S DIET DURING PREGNANCY
        [Display(Name = "Q71. In this pregnancy have you been tested for Hb? (Check the ANC card")]
        public E9 Q71 { get; set; }

        [Display(Name = "Hb levels")]
        [Range(0, 50, ErrorMessage = "Not applicable!!")]
        public uint? Q71_1 { get; set; }

        [Display(Name = "Q72. In this pregnancy have you been given FeFo ?")]
        public E9 Q72 { get; set; }

        [Display(Name = "Q73. Do you have a habit of eating things that are not food in this pregnancy (soil, uncooked rice, charcoal etc)")]
        public E9 Q73 { get; set; }

        [Display(Name = "Q74. Before getting pregnant how many meals were you eating per day?")]
        public E74 Q74 { get; set; }

        [Display(Name = "Q75. How many times have you eaten meat in the past one week")]
        public E75 Q75 { get; set; }

        [Display(Name = "Q76. How many times have you eaten fish in the past one week?")]
        public E75 Q76 { get; set; }

        [Display(Name = "Q77. In the past one year did you face food scarcity?")]
        public E77 Q77 { get; set; }

        [Display(Name = "Q78. How many times do you eat during this pregnancy period?")]
        public E78 Q78 { get; set; }

        [Display(Name = "Q79. Can you please mention what have you eaten in the past 24hrs since you woke up till you went back to bed.(write from Morning to evening meals she mentions)")]
        public string Q79 { get; set; }


        //......INFANT FEEDING INFORMATION

        [Display(Name = "Q80. Have you received counseling in infant feeding in this clinic?")]
        public E9 Q80 { get; set; }

        //Q81 If Yes, what kind of counselling did you receive
        [Display(Name = "1. Position")]
        public bool Q81_1 { get; set; }
        [Display(Name = "2. Attachemnt of the baby on breast")]
        public bool Q81_2 { get; set; }
        [Display(Name = "3. Breast problems handling")]
        public bool Q81_3 { get; set; }
        [Display(Name = "4. Feeding the infant colostrum")]
        public bool Q81_4 { get; set; }
        [Display(Name = "5. EBF")]
        public bool Q81_5 { get; set; }
        [Display(Name = "6. Others")]
        public bool Q81_6 { get; set; }


        //....Q82 Where else have you heard about breast feeding and infant feeding?

        [Display(Name = " 1. Family members(mothers /mother in law)")]
        public bool Q82_1 { get; set; }
        [Display(Name = "2. Media(Radio/tv/newpaper)")]
        public bool Q82_2 { get; set; }
        [Display(Name = "3. Friends and neighbours")]
        public bool Q82_3 { get; set; }
        [Display(Name = "4. Mobile")]
        public bool Q82_4 { get; set; }
        [Display(Name = "5. Others")]
        public bool Q82_5 { get; set; }

        [Display(Name = "Q83. How long does it take to start BF after delivery?")]
        public E83 Q83 { get; set; }

        [Display(Name = "Q84. What is the meaning of exclusive brastfeeding?")]
        public E84 Q84 { get; set; }

        [Display(Name = "Q85. What is the approprate duration for EBF?")]
        public E85 Q85 { get; set; }

        //[Display(Name = "If you dont know write 0")]
        //[Range(0, 1000, ErrorMessage = "Not applicable!!")]
        //public uint? Q85_1 { get; set; }

        [Display(Name = "Q86. What is the appropriate time to start complementary feeding?")]
        public E85 Q86 { get; set; }

        //[Display(Name = "If you dont know write 0")]
        //[Range(0, 1000, ErrorMessage = "Not applicable!!")]
        //public uint? Q86_1 { get; set; }

        [Display(Name = "Q87. What is the appropriate time for breastfeeding cessation? ")]
        public E87 Q87 { get; set; }

        //[Display(Name = "If you dont know write 0")]
        //[Range(0, 1000, ErrorMessage = "Not applicable!!")]
        //public uint? Q87_1 { get; set; }

        [Display(Name = "Q88. Does a woman with HIV allowed to breastfeed?")]
        public E9 Q88 { get; set; }

        [Display(Name = "Q89.If Yes for how does she allowed to breastfeed?")]
        public E9? Q89 { get; set; }

        [Display(Name = "Q90. If No, Why?")]
        public E90? Q90 { get; set; }

        [Display(Name = "Others")]
        public string OthersQ90 { get; set; }

        [Display(Name = "Q91. Is it necessary to feed newborn with colostrums?")]
        public E9 Q91 { get; set; }

        [Display(Name = "Q92. If no why?")]
        public E92? Q92 { get; set; }


        [Display(Name = "Others")]
        public string OthersQ92 { get; set; }

        [Display(Name = "Q93. If Yes why?")]
        public E93? Q93 { get; set; }

        [Display(Name = "Q94. What are the causes of cracked nipples?")]
        public E94 Q94 { get; set; }

        [Display(Name = "Q95. After delivery what method of infant feeding are you planning to use ?")]
        public E95 Q95 { get; set; }

        [Display(Name = "(Q96. If the mother is HIV positive For how long are you planning to breastfeed your child ?")]
        [Range(0, 100, ErrorMessage = "Not applicable!!")]
        public uint? Q96 { get; set; }

        [Display(Name = "Q97. In your own opinion do you think it is possible to practice EBF?")]
        public E9 Q97 { get; set; }

        //...........CLINICAL EXAMINATION OF GENITALIA


        //Q98 External genitalia (tick where appropriate
        [Display(Name = "1. Normal")]
        public bool Q98_1 { get; set; }
        [Display(Name = "2.	Irritation/redness")]
        public bool Q98_2 { get; set; }
        [Display(Name = "3.	Swelling")]
        public bool Q98_3 { get; set; }
        [Display(Name = "4. Blisters")]
        public bool Q98_4 { get; set; }
        [Display(Name = "5. Sores/ulcers")]
        public bool Q98_5 { get; set; }
        [Display(Name = "6. Genital warts")]
        public bool Q98_6 { get; set; }


        //Q99 Internal genitalia (tick where appropriate)

        [Display(Name = "1. Normal")]
        public bool Q99_1 { get; set; }
        [Display(Name = "2. Irritation/redness")]
        public bool Q99_2 { get; set; }
        [Display(Name = "3. Blisters")]
        public bool Q99_3 { get; set; }
        [Display(Name = "4. Sores/ulcers")]
        public bool Q99_4 { get; set; }
        [Display(Name = "5. Genital warts")]
        public bool Q99_5 { get; set; }


        //Q100 Vaginal secretion (tick where appropriate
        [Display(Name = "1. Normal")]
        public E9 Q100_1_1 { get; set; }

        //2.Amount
        //[Display(Name = "1. Scarce")]
        //public bool Q100_2_1 { get; set; }
        //[Display(Name = "2. Moderate")]
        //public bool Q100_2_2 { get; set; }
        //[Display(Name = "3. Profuse")]
        //public bool Q100_2_3 { get; set; }
       
        [Display(Name = "2. Amount")]
        public EA100 QEA100 { get; set; }

        //3.Colour 
        //[Display(Name = "1. Clear")]
        //public bool Q100_3_1 { get; set; }
        //[Display(Name = "2. White")]
        //public bool Q100_3_2 { get; set; }
        //[Display(Name = "3. Brown")]
        //public bool Q100_3_3 { get; set; }
        //[Display(Name = "4. Cream/yellow")]
        //public bool Q100_3_4 { get; set; }
        [Display(Name = "3.Colour")]
        public EC100 QEC100 { get; set; }
        //4.Consistency

        //[Display(Name = "1. Thick")]
        //public bool Q100_4_1 { get; set; }
        //[Display(Name = "2. Thin")]
        //public bool Q100_4_2 { get; set; }
        //[Display(Name = "3. Foamy")]
        //public bool Q100_4_3 { get; set; }
        //[Display(Name = "4. Curdlike")]
        //public bool Q100_4_4 { get; set; }
        //[Display(Name = "5. Homogenous")]
        //public bool Q100_4_5 { get; set; }
        [Display(Name = "4.Consistency")]
        public ECO100 QECO100 { get; set; }

        //5.Coating of vaginal walls
        [Display(Name = "5. Coating of vaginal walls")]
        public E9 Q100_5_1 { get; set; }

        //6.Smelling
        [Display(Name = "6. Smelling")]
        public E9 Q100_6_1 { get; set; }

        //Q101 Sample collected from (tick where appropriate)
        //[Display(Name = "1. Blood")]
        //public bool Q101_1 { get; set; }
        //[Display(Name = "2. Vaginal")]
        //public bool Q101_2 { get; set; }
        //[Display(Name = "3. Urin")]
        //public bool Q101_3 { get; set; }

        [Display(Name = "Q101. Sample taken")]
        public ECOO100 QECOO100 { get; set; }

        //Vaginal sample          
        [Display(Name = "(Q102. pH value")]
        [Range(0, 20, ErrorMessage = "Not applicable!!")]
        public uint? Q102 { get; set; }

        //Whiff’s test    
        [Display(Name = "Q103. Whiff’s test")]
        public E103 Q103 { get; set; }

        //[Display(Name = "Created Date")]
        //public DateTime CreatedDate { get; set; }
        //}
    }

    public enum E3
    {
        [Display(Name = "1. Christian")]
        Christian=1,
        [Display(Name = "2. Muslim")]
        Muslim=2,
        [Display(Name = "3. Traditional")]
        Traditional=3,
        [Display(Name = "4. Other(specify)")]
        Others=4
    }
    public enum E4
    {
        [Display(Name = "1. Chaga")]
        Chaga = 1,
        [Display(Name = "2. Pare")]
        Pare = 2,
        [Display(Name = "3. Sambaa")]
        Sambaa = 3,
        [Display(Name = "4. Other(specify)")]
        Others = 4
    }
    public enum E5
    {
        [Display(Name = "1. Married")]
        Married = 1,
        [Display(Name = "2. Cohabiting ")]
        Cohabiting = 2,
        [Display(Name = "3. Single")]
        Single = 3,
        [Display(Name = "4. Widow")]
        Widow = 4,
        [Display(Name = "5. Separated/divorced")]
        Separated_divorced = 5
    }
    public enum E6
    {
        [Display(Name = "0 . No")]
        No = 0,
        [Display(Name = "1 .Yes")]
        Yes = 1,
        [Display(Name = "2 . I don’t know")]
        Dontknow = 2

    }
    public enum E8
    {
        [Display(Name = "1. Not attended formal education")]
        Noeducation = 1,
        [Display(Name = "2. Primary school")]
        Primaryschool = 2,
        [Display(Name = "3. Secondary school")]
        Secondaryschool = 3,
        [Display(Name = "4. College and above ")]
        Collegeabove = 4,
        [Display(Name = "5. Certificate or technical education")]
        CertificateTechnicalEducation = 5

    }
    //Questions Repeat
    public enum E9
    {
        [Display(Name = "0. No")]
        No = 0,
        [Display(Name = "1. Yes")]
        Yes = 1


    }

    //Questions Repeat
    public enum E10
    {
        [Display(Name = "1. Unemployed")]
        Unemployed = 1,
        [Display(Name = "2. Employed")]
        Employed = 2,
        [Display(Name = "3. Business")]
        Business = 3,
        [Display(Name = "4. Farmer")]
        Farmer = 4,
        [Display(Name = "5. Student")]
        Student = 5,
        [Display(Name = "6. Others ")]
        Others = 6


    }
    public enum E12
    {
        [Display(Name = "1. Television")]
        Television = 1,
        [Display(Name = "2. Radio")]
        Radio = 2,
        [Display(Name = "3. Fridge")]
        Fridge = 3,
        [Display(Name = "4. Car")]
        Car = 4,
        [Display(Name = "5. Bicycles")]
        Bicycles = 5,
        [Display(Name = "6. Motorcycles")]
        Motorcycles = 6,
        [Display(Name = "7. Land ")]
        Land = 7


    }
    public enum E13
    {
        [Display(Name = "1. Own house")]
        Ownhouse = 1,
        [Display(Name = "2. Rent house")]
        Renthouse = 2,
        [Display(Name = "3. Rent room/rooms")]
        Rentrooms = 3,
        [Display(Name = "4. Living with relative/my family/parents")]
        LivingWithFamily = 4,
        [Display(Name = "5. Others(specify")]
        Others = 5
    }
    public enum E15
    {
        [Display(Name = "1. Brick/brock")]
        Brick_brock = 1,
        [Display(Name = "2. Wood")]
        Wood = 2,
        [Display(Name = "3. Mud")]
        Mud = 3,
        [Display(Name = "4. Others(specify)")]
        Others= 4

    }
    public enum E16
    {
        [Display(Name = "1. No toilet")]
        Notoilet = 1,
        [Display(Name = "2. In the house")]
        InTheHouse = 2,
        [Display(Name = "3. Outside the house")]
        OutsideTheHouse = 3,
        [Display(Name = "4. Inside and outside the house")]
        InsideOutsideHouse = 4

    }
    public enum E18
    {
        [Display(Name = "1. Tap inside the house")]
        TapInsideHouse = 1,
        [Display(Name = "2. Tap outside the house")]
        TapOutsideHouse = 2,
        [Display(Name = "3. Common supply")]
        CommonSupply = 3,
        [Display(Name = "4. Well/river/spring")]
        InsideOutsideHouse = 4,
        [Display(Name = "5. Others")]
        Others = 5

    }
    public enum E20
    {
        [Display(Name = "1. Once")]
        Once = 1,
        [Display(Name = "2. Twice")]
        Twice = 2,
        [Display(Name = "3. Thrice")]
        Thrice = 3,
        [Display(Name = "4. More than three(specify)")]
        MoreThanThree = 4


    }
    //Questions Repeat
    public enum E21
    {
        [Display(Name = "1. No")]
         No = 1,
        [Display(Name = "2. Occasionally(week)")]
        Twice = 2,
        [Display(Name = "3. Every day")]
        Thrice = 3

    }
    public enum E23
    {
        [Display(Name = "1. No")]
        No = 1,
        [Display(Name = "2. Occasionally")]
        Occasionally = 2,
        [Display(Name = "3. Several times(month)")]
        SeveralTime = 3

    }
    public enum E34
    {
        [Display(Name = "1. Once")]
        Once = 1,
        [Display(Name = "2. Twice")]
        Twice = 2,
        [Display(Name = "3. Three or more")]
        ThreeOrMore = 3

    }
    public enum E35
    {
        [Display(Name = "1. Plain water")]
        PlainWater = 1,
        [Display(Name = "2. Soap")]
        Soap = 2,
        [Display(Name = "3. Detergent(eg dettol)")]
        Detergent = 3,
        [Display(Name = "4. Others(specify)")]
        Others = 4

    }
    public enum E36
    {
        [Display(Name = "1. Fingers")]
        Fingers = 1,
        [Display(Name = "2. Cloth")]
        Cloth = 2,
        [Display(Name = "3. Paper(eg toilet paper)")]
        Paper= 3,
        [Display(Name = "4. Others(specify)")]
        Others = 4

    }


    public enum E39
    {
        [Display(Name = "1. Voluntary")]
        Voluntary = 1,
        [Display(Name = "2. Involuntary")]
        Involuntary = 2
        

    }

    public enum E42
    {
        [Display(Name = "0. No")]
        No = 0,
        [Display(Name = "1. Yes")]
        Yes = 1,
        [Display(Name = "2. Occasionaly")]
        Occasionaly = 2


    }

    // Questions repeat
    public enum E46
    {
        [Display(Name = "1. Positive")]
        Positive = 1,
        [Display(Name = "2. Negative")]
        Negative = 2,
        [Display(Name = "3. Unknown")]
        Unknown = 3


    }

    public enum E47
    {
        [Display(Name = "1. Positive")]
        Positive = 1,
        [Display(Name = "2. Negative")]
        Negative = 2,
        [Display(Name = "3. Unknown (counsel and test)")]
        Unknown = 3,
        [Display(Name = "4. Not tested (counsel and test)")]
        Nottested = 4
       


    }
    public enum E54
    {
        [Display(Name = "a). When?")]
        When_a = 1,
        [Display(Name = "b). Before this pregnancy?")]
        BeforePregnancy = 2,
        [Display(Name = "c). Are you using drugs for PMTCT of HIV? (write name of the drug")]
        PMTCTofHIV = 3
    }

    public enum E65
    {
        [Display(Name = "1. Age (years)")]
        Age = 1,
        [Display(Name = "2. I don’t know")]
        donknow = 2,

    }
    public enum E66
    {
        [Display(Name = "1. No formal education")]
        Noeducation = 1,
        [Display(Name = "2. Primary school")]
        Primaryschool = 2,
        [Display(Name = "3. Secondary school")]
        Secondaryschool = 3,
        [Display(Name = "4. Higher education")]
        HigherEdu = 4,
        [Display(Name = "5. Certificate or technical education")]
        CertificateTechnicalEducation = 5

    }
    public enum E68Yes
    {
        [Display(Name = "1. Week")]
        Weekn = 1,
        [Display(Name = "2. Month")]
        Monthn = 2
        

    }
    // Questions repeat
    public enum E70
    {
        [Display(Name = "1. Local brew")]
         Localbrew = 1,
        [Display(Name = "2. Beer")]
        Beer = 2,
        [Display(Name = "3. Viroba/konyagi")]
        Viroba_konyagi = 3,
        [Display(Name = "4. Others(specify)")]
        Monthn = 4


    }
    public enum E74
    {
        [Display(Name = "1. One")]
        One = 1,
        [Display(Name = "2. Two")]
        Two = 2,
        [Display(Name = "3. Three")]
        Three = 3,
        [Display(Name = "4. more than three")]
        MoreThree = 4
    }
    // Questions repeat
    public enum E75
    {
        [Display(Name = "1. None")]
        None = 1,
        [Display(Name = "2. Once")]
        Once = 2,
        [Display(Name = "3. Twice")]
        Twice = 3,
        [Display(Name = "4. Mention")]
        Mention = 4,
        [Display(Name = "5. Everyday")]
        Everyday = 5
    }
    public enum E77
    {
        [Display(Name = "1. No")]
        No = 1,
        [Display(Name = "2. Often")]
        Often = 2,
        [Display(Name = "3. Seldom")]
        Seldom = 3,
        [Display(Name = "4. Sometimes")]
        Sometimes = 4,
    }

    public enum E78
    {
        [Display(Name = "1. Twice")]
        Twice = 1,
        [Display(Name = "2. Thrice")]
        Thrice = 2,
        [Display(Name = "3. Four times")]
        Fourtimes = 3,
        [Display(Name = "4. Five times ")]
        Fivetimes = 4
    }
    public enum E83
    {
        [Display(Name = "0. Dont know")]
        Dontknoow = 0,
        [Display(Name = "1. within 1hr")]
        within1hr = 1,
        [Display(Name = "2. 1-24hrs")]
        after1hr = 2,
        [Display(Name = "3. after 24hrs")]
        after24hrs = 3
    }
    public enum E84
    {
        [Display(Name = "1. To feed the child mothers milk only without mixing with anything else for the first 6 months of life.")]
        MonthLife = 1,
        [Display(Name = "2. To feed water and breastmilk")]
        WaterandBreastmilk = 2,
        [Display(Name = "3. To give breastmilk and infant formula")]
        BreastmilkandInfant = 3,
        [Display(Name = "4. Others")]
        within24hrs = 4,
        
    }

    // Questions repeat
    public enum E85
    {
            [Display(Name = "0. Don’t know")]
            Dontknow = 0,
            [Display(Name = "1. (6 months)")]
            Monthn3 = 1,
            [Display(Name = "2. < 6 months)")]
            Monthn6 = 2,
            [Display(Name = "3. > 6 months)")]
            Monthn63 = 3


        }
    public enum E87
    {
        [Display(Name = "0. Don’t know")]
        Dontknow = 0,
        [Display(Name = "1. 2Years")]
        Monthn = 1,
        [Display(Name = "1. < 2Years")]
        Monthn1 = 2,
        [Display(Name = "1. > 2Years")]
        Monthn2 = 3


        }
    public enum E90
    {
        [Display(Name = "1. She will infect her child")]
        InfectHerChild = 1,
        [Display(Name = "2. HIV positive mother is not allowed to breastfeed")]
        HIVPositiveMother = 2,
        [Display(Name = "3. Don’t Know")]
        Dontknow = 3,
        [Display(Name = "4. Others")]
        Monthn = 4
    }
    public enum E92
    {
        [Display(Name = "1. not good for the baby")]
        GoodBaby = 1,
        [Display(Name = "2. they are dirty")]
        Dirty = 2,
        [Display(Name = "3. not important to the child")]
        TheChild = 3,
        [Display(Name = "4. Others")]
        Others = 4
    }
    public enum E93
    {
        [Display(Name = "1. Its good for the health of the child")]
        GoodChild = 1,
        [Display(Name = "2. We were told in the clinic")]
        TheClinic = 2,
        [Display(Name = "3. Others")]
        Others = 3
    }
    public enum E94
    {
        [Display(Name = "1. Poor positioning")]
        PoorPositioning = 1,
        [Display(Name = "2. Diseases")]
        Diseases = 2,
        [Display(Name = "3. Don’t know")]
        Dontknow = 3,
        [Display(Name = "4. Others")]
        Others = 4

            

    }
    public enum E95
    {
        [Display(Name = "1. EBF")]
        EBF = 1,
        [Display(Name = "2. Infant formula")]
        InfantFormula = 2,
        [Display(Name = "3. Cow’s Milk")]
        CowMilk = 3,
        [Display(Name = "4. Mixed feeding(breast milk and other milk)")]
        OtherMilk = 4
    }
    public enum EA100
    {
        [Display(Name = "1. Scarce")]
        Scarce = 1,
        [Display(Name = "2. Moderate")]
        Moderate = 2,
        [Display(Name = "3. Profuse")]
        Profuse = 3
        
    }
    public enum EC100
    {
        [Display(Name = "1. Clear")]
        Clear = 1,
        [Display(Name = "2. White")]
        White = 2,
        [Display(Name = "3. Brown")]
        Brown = 3

    }
    public enum ECO100
    {
        [Display(Name = "1. Thick")]
        Thick = 1,
        [Display(Name = "2. Thin")]
        Thin = 2,
        [Display(Name = "3. Foamy")]
        Foamy = 3,
        [Display(Name = "4. Curdlike")]
        Curdlike = 4
        
        

    }
    public enum ECOO100
    {
        [Display(Name = "1. Blood")]
        Blood = 1,
        [Display(Name = "2. Vaginal")]
        Vaginal = 2,
        [Display(Name = "3. Urin")]
        Urin = 3

    }
    public enum E103
    {
        [Display(Name = "1. Negative")]
        Negative = 1,
        [Display(Name = "2. Positive")]
        Positive = 2
        
    }



}