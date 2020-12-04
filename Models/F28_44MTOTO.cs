using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class F28_44MTOTO:EntityData
    {
        [Display(Name = "ID Number")]
        [Range(1, 1000, ErrorMessage = "ID Number?")]
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
        [Range(1, 60, ErrorMessage = "Age of the child in months?")]
        public uint? UmriMtotoMiezi { get; set; }

        //JAZA UZITO WA MIEZI ILIYOONYESHWA HAPO CHINI KOPI GROWTH CARD

        [Display(Name = "1M")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M1 { get; set; }
        [Display(Name = "3M")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M3 { get; set; }
        [Display(Name = "6M")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M6 { get; set; }
        [Display(Name = "9M")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M9 { get; set; }
        [Display(Name = "12M")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M12 { get; set; }
        [Display(Name = "15M")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M15 { get; set; }
        [Display(Name = "18M")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M18 { get; set; }
        [Display(Name = "24M")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M24 { get; set; }
        [Display(Name = "28M")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M28 { get; set; }


        [Display(Name = "Q1. Je mtoto bado ananyonya?")]
        public EFMOK1 Q1 { get; set; }

        [Display(Name = "ameacha na miezi")]
        [Range(1, 60, ErrorMessage = "ameacha na miezi")]
        public uint? Q1_1 { get; set; }


        [Display(Name = "Q2. Kwa nini aliacha kunyonya?")]
        public string Q2 { get; set; }

        [Display(Name = "Q3. Mtoto ameshawahi kupewa dawa ya minyoo tangu alipokuwa na umri wa mwaka mmoja?")]
        public EFMOK1 Q3 { get; set; }

        [Display(Name = "Mara ngapi hadi sasa?")]
        [Range(1, 10, ErrorMessage = "Mara ngapi hadi sasa??")]
        public uint? Q3_1 { get; set; }

        [Display(Name = "Q4. Je mtoto ameshaugua tangu alipokuwa na umri wa miaka miwili (2 years)?")]
        public EFMOK1 Q4 { get; set; }

        [Display(Name = "Taja tatizo na dawa alizopewa ")]
        public string Q4_1 { get; set; }

        [Display(Name = "Q5. Je mtoto ameshalazwa hospitalini tangu ulipokuja kliniki kwa mara ya mwisho?")]
        public EFMOK1 Q5 { get; set; }

        [Display(Name = "tatizo")]
        public string Q5_1 { get; set; }

        [Display(Name = "Q6.Je huyu ni mtoto wako wa ngapi?")]
        [Range(1, 20, ErrorMessage = "Je huyu ni mtoto wako wa ngapi?")]
        public uint? Q6 { get; set; }

        [Display(Name = "Mkubwa wake ana umri gani ")]
        [Range(1, 30, ErrorMessage = "Umri?")]
        public uint? Q6_1 { get; set; }

        [Display(Name = "Mdogo wake ana umri gani ")]
        [Range(1, 30, ErrorMessage = "Umri?")]
        public uint? Q6_2 { get; set; }

        [Display(Name = "7.Je mtoto huyu analishwa mara ngapi kwa siku? (number of meals per day)")]
        [Range(1, 20, ErrorMessage = "analishwa mara ngapi kwa siku?")]
        public uint? Q7 { get; set; }

        [Display(Name = "Q8. Je unampikia mtoto chakula chake mwenyewe, tofauti na cha watu wazima wanachokula nyumbani?")]
        public EFMOK1 Q8 { get; set; }

        //9. Chakula alichokula masaa 24 yaliyopita.Naomba unitajie vyakula na vinywaji vyote 
        //mtoto alivyopewa jana, kuanzia alipoamka asubuhi hadi wakati wa kulala usiku. 
        //(Andika kila kitu anachokitaja). (Last 24 – hours recall)


        [Display(Name = "Asubuhi:")]
        public string Q9_1 { get; set; }
        [Display(Name = "Saa tatu – saa sita:")]
        public string Q9_2 { get; set; }
        [Display(Name = "Mchana:")]
        public string Q9_3 { get; set; }
        [Display(Name = "Saa nane – saa 12 jioni: ")]
        public string Q9_4 { get; set; }
        [Display(Name = "Jioni/Usiku:")]
        public string Q9_5 { get; set; }


        //10. Mara nyingi anakula nini ASUBUHI?   (BREAKFAST)
        [Display(Name = "1.Chai na")]
        public string Q10_1_a { get; set; }
        [Display(Name = "2. Maziwa ya ngombe")]
        public string Q10_1_b { get; set; }
        [Display(Name = "3. Uji wa dona")]
        public string Q10_1_c { get; set; }
        [Display(Name = "4. Uji mchanganyiko (taja")]
        public string Q10_1_d { get; set; }
        [Display(Name = "5. Juice ya ")]
        public string Q10_1_e { get; set; }
        [Display(Name = "6.Yai (Mara ngapi kwa wiki")]
        public string Q10_1_f { get; set; }
        [Display(Name = "7. Vinginevyo (taja")]
        public string Q10_1_g { get; set; }
        [Display(Name = "8. Vinginevyo (taja")]
        public string Q10_1_h { get; set; }

        [Display(Name = "(taja")]
        public string Q10_1_i { get; set; }

        //Anapewa nini KATI YA SAA TATU ASUBUHI HADI SAA SITA MCHANA (In btn breakfast)
        [Display(Name = "1.")]
        public string Q10_2_a { get; set; }
        [Display(Name = "2.")]
        public string Q10_2_b { get; set; }
        [Display(Name = "3.")]
        public string Q10_2_c { get; set; }
        [Display(Name = "4.")]
        public string Q10_2_d { get; set; }

        //Mara nyingi CHAKULA CHA MCHANA (LUNCH)anapewa…. 
        [Display(Name = "1. Uji mchanganyiko (taja")]
        public string Q10_3_a { get; set; }
        [Display(Name = "2. Ugali na ")]
        public string Q10_3_b { get; set; }
        [Display(Name = "3. Wali na ")]
        public string Q10_3_c { get; set; }
        [Display(Name = "4. Mtori")]
        public string Q10_3_d { get; set; }
        [Display(Name = "5. Ndizi zimechanganywa na ")]
        public string Q10_3_e { get; set; }
        [Display(Name = "6. Makande")]
        public string Q10_3_f { get; set; }
        [Display(Name = "7. Viazi na ")]
        public string Q10_3_g { get; set; }
        [Display(Name = "8. Mboga za majani")]
        public string Q10_3_h { get; set; }

        [Display(Name = "(taja")]
        public string Q10_3_i { get; set; }


        //KATI YA SAA NANE MCHANA HADI SAA KUMI NA MBILI JIONI anapewa….
        [Display(Name = "1.")]
        public string Q10_4_a { get; set; }
        [Display(Name = "2.")]
        public string Q10_4_b { get; set; }
        [Display(Name = "3.")]
        public string Q10_4_c { get; set; }
        [Display(Name = "4.")]
        public string Q10_4_d { get; set; }

        //Mara nyingi CHAKULA CHA JIONI (DINNER) anapewa….
        [Display(Name = "1. Uji mchanganyiko (taja")]
        public string Q10_5_a { get; set; }
        [Display(Name = "2. Ugali na ")]
        public string Q10_5_b { get; set; }
        [Display(Name = "3. Wali na ")]
        public string Q10_5_c { get; set; }
        [Display(Name = "4. Mtori")]
        public string Q10_5_d { get; set; }
        [Display(Name = "5. Ndizi zimechanganywa na ")]
        public string Q10_5_e { get; set; }
        [Display(Name = "6. Makande")]
        public string Q10_5_f { get; set; }
        [Display(Name = "7. Viazi na ")]
        public string Q10_5_g { get; set; }
        [Display(Name = "8. Mboga za majani")]
        public string Q10_5_h { get; set; }

        [Display(Name = "(taja")]
        public string Q10_5_i { get; set; }

        [Display(Name = "Q11. Je unampa mtoto samaki?")]
        public EFMOK1 Q11 { get; set; }

        //[Display(Name = "(Mara ngapi kwa wiki")]
        //public string Q11_1 { get; set; }

        [Display(Name = "Mara ngapi kwa wiki")] 
        [Range(1, 20, ErrorMessage = "Ngapi?")]
        public uint? Q11_1 { get; set; }

        [Display(Name = "(Q12. Je unatumia mafuta gani kutayarisha chakula cha mtoto")]
        public string Q12 { get; set; }

        [Display(Name = "(Q13. Maji ya kunywa mnachota wapi?")]
        public EFMO28_13 Q13 { get; set; }

        [Display(Name = "(taja")]
        public string Q13_1 { get; set; }

        [Display(Name = "Q14. Unamchemshia maji ya mtoto ya kunywa?")]
        public EFMOK1 Q14 { get; set; }

        [Display(Name = "Q15.Choo anachotumia mtoto ni ")]
        public EFMO28_15 Q15 { get; set; }

        [Display(Name = "(Vingine")]
        public string Q15_1 { get; set; }

        [Display(Name = "Q16.Amemaliza chanjo zinazotakiwa?")]
        public EFMOK1 Q16 { get; set; }


        //a).Kutayarisha chakula cha mtoto     
        [Display(Name = "1. Mama")]
        public bool Q17_a_1 { get; set; }

        [Display(Name = "2. Binti wa nyumbani")]
        public bool Q17_a_2 { get; set; }

        [Display(Name = "3. Dada/kaka zake")]
        public bool Q17_a_3 { get; set; }

        [Display(Name = "4. Wengine")]
        public bool Q17_a_4 { get; set; }

        [Display(Name = "Wengine")]
        public string Q17_a_5 { get; set; }

        //b).Kumlisha mtoto     
        [Display(Name = "1. Mama")]
        public bool Q17_b_1 { get; set; }

        [Display(Name = "2. Binti wa nyumbani")]
        public bool Q17_b_2 { get; set; }

        [Display(Name = "3. Dada/kaka zake")]
        public bool Q17_b_3 { get; set; }

        [Display(Name = "4. Wengine")]
        public bool Q17_b_4 { get; set; }

        [Display(Name = "Wengine")]
        public string Q17_b_5 { get; set; }

        //c).Kumvalisha mtoto       
        [Display(Name = "1. Mama")]
        public bool Q17_c_1 { get; set; }

        [Display(Name = "2. Binti wa nyumbani")]
        public bool Q17_c_2 { get; set; }

        [Display(Name = "3. Dada/kaka zake")]
        public bool Q17_c_3 { get; set; }

        [Display(Name = "4. Wengine")]
        public bool Q17_c_4 { get; set; }

        [Display(Name = "Wengine")]
        public string Q17_c_5 { get; set; }

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

        //3. Mouth
        [Display(Name = "a. Mid upper arm circumference (MUAC) Cm")]
        [Range(1, 60, ErrorMessage = "Cm?")]
        public uint? Q15_a { get; set; }

        [Display(Name = "b. Blood pressure (BP ")]
        public string Q15_b { get; set; }

        [Display(Name = "c. Stool taken")]
        public EFMOK1? Q15_c { get; set; }
        [Display(Name = "d. Haemoglobin checked")]
        public EFMOK1? Q15_d { get; set; }
        //7. Neurological/ developmental test
        [Display(Name = "7. Neurological/ developmental test")]
        public EFMOK1? Q16_a { get; set; }

        //8. IQ
        [Display(Name = "8. IQ")]
        public EFMOK1? Q17_a { get; set; }

        [Display(Name = "Problems/ Diagnosis")]
        public string ProblemsDsis { get; set; }

        [Display(Name = "Medication prescribed")]
        public string MedicationPres { get; set; }


        [Display(Name = "Date of next visit 32M (2 years and 8 months)")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateVisit32 { get; set; }

    }
    public enum EFMO28_13
    {
        [Display(Name = "1. Bombani")]
        E1 = 1,
        [Display(Name = "2. Kisimani")]
        E2 = 2,
        [Display(Name = "3. Mtoni")]
        E3 = 3,
        [Display(Name = "4. Kwingine")]
        E4 = 4

    }
    public enum EFMO28_15
    {
        [Display(Name = "1. Cha shimo na hakijasakafiwa")]
        E1 = 1,
        [Display(Name = "2. Cha shimo kimesakafiwa")]
        E2 = 2,
        [Display(Name = "3. Cha kuvuta")]
        E3 = 3,
        [Display(Name = "4. Vingine")]
        E4 = 4

    }
}
