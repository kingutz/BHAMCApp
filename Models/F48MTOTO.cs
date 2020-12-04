using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class F48MTOTO:EntityData
    {
        [Display(Name = "ID Number")]
        [Range(1, 1000, ErrorMessage = "ID Number?")]
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
        [Range(1, 60, ErrorMessage = "Umri (miezi)???")]
        public uint? UmriMtotoMiezi { get; set; }

        //JAZA UZITO WA MIEZI ILIYOONYESHWA HAPO CHINI KOPI GROWTH CARD

        [Display(Name = "36M:")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M36 { get; set; }
        [Display(Name = "40M:")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M40 { get; set; }
        [Display(Name = "44M:")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M44 { get; set; }
        [Display(Name = "48M:")]
        [Range(1, 30, ErrorMessage = "Uzito?")]
        public uint? M48 { get; set; }

        [Display(Name = "Q1. Je mtoto bado ananyonya?")]
        public EFMOK1 Q1 { get; set; }

        [Display(Name = "Ameacha na umri gani")]
        [Range(1, 60, ErrorMessage = "Umri?")]
        public uint? Q1_1 { get; set; }

        [Display(Name = "Q2. Je mtoto ameshawahi kuugua tangu alipokuwa na umri wa miaka mitatu hadi sasa (3-4 years)?  ")]
        public EFMOK1 Q2 { get; set; }

        [Display(Name = "Taja tatizo na dawa alizopewa")]
        public string Q2_1 { get; set; }

        [Display(Name = "Q3.Je mtoto ameshalazwa hospitalini katika kipindi alipokuwa na miaka mitatu hadi minne (3-4 years?)")]
        public EFMOK1 Q3 { get; set; }

        [Display(Name = "Tatizo ")]
        public string Q3_1 { get; set; }

        [Display(Name = "Q4.Mtoto ameshawahi kupewa dawa ya minyoo tangu alipokuwa na umri wa miaka mitatu?")]
        public EFMOK1 Q4 { get; set; }

        [Display(Name = "Mara ngapi hadi sasa?")]
        [Range(1, 10, ErrorMessage = "Mara ngapi hadi sasa??")]
        public uint? Q4_1 { get; set; }

        [Display(Name = "Q5.Je huyu ni mtoto wako wa ngapi? ")]
        [Range(1, 20, ErrorMessage = "Je huyu ni mtoto wako wa ngapi?")]
        public uint? Q5 { get; set; }

        [Display(Name = "Mkubwa wake aliyemuachia ziwa ana umri gani")]
        [Range(1, 30, ErrorMessage = "Umri?")]
        public uint? Q5_1 { get; set; }

        [Display(Name = "Mdogo wake ana umri gani")]
        [Range(1, 60, ErrorMessage = "Umri?")]
        public uint? Q5_2 { get; set; }

        [Display(Name = "Q6.Mtoto wako anakula mara ngapi kwa siku tangu anapoamka asubuhi hadi usiku?")]
        [Range(1, 30, ErrorMessage = "Umri?")]
        public uint? Q6 { get; set; }

        [Display(Name = "Q7. Je bado unampikia chakula chake mwenyewe tofauti na cha watu wazima, ukitoa uji?")]
        public EFMOK1 Q7 { get; set; }


        //8. Kwa kawaida ni vyakula gani na vinywaji gani unampa mtoto kila siku tangu anapoamka hadi usiku?.
        //Jaza vile anavyotaja mwenyewe  (Dietery frequency)  
        //ASUBUHI ANAPOAMKA / BREAKFAST

        //10. Mara nyingi anakula nini ASUBUHI?   (BREAKFAST)
        [Display(Name = "1.Chai na")]
        public string Q8_1_a { get; set; }
        [Display(Name = "2. Maziwa ya ngombe")]
        public string Q8_1_b { get; set; }
        [Display(Name = "3. Uji wa dona")]
        public string Q8_1_c { get; set; }
        [Display(Name = "4. Uji mchanganyiko (taja")]
        public string Q8_1_d { get; set; }
        [Display(Name = "5. Juice ya ")]
        public string Q8_1_e { get; set; }
        [Display(Name = "6.Yai (Mara ngapi kwa wiki")]
        public string Q8_1_f { get; set; }

        //Anapewa nini KATI YA SAA TATU ASUBUHI HADI SAA SITA MCHANA (In btn breakfast)

        [Display(Name = "1.")]
        public string Q8_2_a { get; set; }
        [Display(Name = "2.")]
        public string Q8_2_b { get; set; }
        [Display(Name = "3.")]
        public string Q8_2_c { get; set; }
        [Display(Name = "4.")]
        public string Q8_2_d { get; set; }

        //CHAKULA CHA MCHANA (LUNCH) anapewa….  
        [Display(Name = "1. Uji mchanganyiko (taja")]
        public string Q8_3_a { get; set; }
        [Display(Name = "2. Ugali na ")]
        public string Q8_3_b { get; set; }
        [Display(Name = "3. Wali na ")]
        public string Q8_3_c { get; set; }
        [Display(Name = "4. Mtori")]
        public string Q8_3_d { get; set; }
        [Display(Name = "5. Ndizi zimechanganywa na ")]
        public string Q8_3_e { get; set; }
        [Display(Name = "6. Makande")]
        public string Q8_3_f { get; set; }
        [Display(Name = "7. Viazi na ")]
        public string Q8_3_g { get; set; }
        [Display(Name = "8. Mboga za majani")]
        public string Q8_3_h { get; set; }

        [Display(Name = "(taja")]
        public string Q8_3_i { get; set; }

        //KATI YA SAA NANE MCHANA HADI SAA KUMI NA MBILI JIONI anapewa….

        [Display(Name = "1.")]
        public string Q18_4_a { get; set; }
        [Display(Name = "2.")]
        public string Q8_4_b { get; set; }
        [Display(Name = "3.")]
        public string Q8_4_c { get; set; }
        [Display(Name = "4.")]
        public string Q8_4_d { get; set; }

        //CHAKULA CHA JIONI (DINNER) anapewa….
        [Display(Name = "1. Uji mchanganyiko (taja")]
        public string Q8_5_a { get; set; }
        [Display(Name = "2. Ugali na ")]
        public string Q8_5_b { get; set; }
        [Display(Name = "3. Wali na ")]
        public string Q8_5_c { get; set; }
        [Display(Name = "4. Mtori")]
        public string Q8_5_d { get; set; }
        [Display(Name = "5. Ndizi zimechanganywa na ")]
        public string Q8_5_e { get; set; }
        [Display(Name = "6. Makande")]
        public string Q8_5_f { get; set; }
        [Display(Name = "7. Viazi na ")]
        public string Q8_5_g { get; set; }
        [Display(Name = "8. Mboga za majani")]
        public string Q8_5_h { get; set; }

        [Display(Name = "(taja")]
        public string Q8_5_i { get; set; }

        //9. Na katika masaa 24 yaliyopita au jana, ni vyakula na vinywaji gani mtoto 
        //alipewa kuanzia alipoamka asubuhi hadi wakati wa kulala usiku. 
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

        [Display(Name = "Q10.Je unampa mtoto samaki?")]
        public EFMOK1 Q10 { get; set; }

        [Display(Name = "Mara ngapi kwa wiki")]
        [Range(1, 20, ErrorMessage = "Ngapi?")]
        public uint? Q10_1 { get; set; }

        [Display(Name = "Q11. Je unatumia mafuta gani kutayarisha chakula cha mtoto ")]
        public string Q11 { get; set; }

        [Display(Name = "Q12. Maji ya kunywa mnachota wapi ?")]
        public EFMO28_13 Q12 { get; set; }

        [Display(Name = "Taja")]
        public string Q12_1 { get; set; }

        [Display(Name = "Q13. Unamchemshia mtoto maji ya kunywa?")]
        public EFMOK1 Q13 { get; set; }

        [Display(Name = "Q14. Je mtoto ameshaweza kutumia choo au bado anatumia poti/ kujisaidia pembeni?")]
        public EFMO48_14 Q14 { get; set; }

        [Display(Name = "Q15. Choo anachotumia mtoto ni ")]
        public EFMO28_15 Q15 { get; set; }

        [Display(Name = "Q16. Je mama amerudi kwenye shughuli za kumuingizia kipato?")]
        public EFMOK1 Q16 { get; set; }


        //a).Kutayarisha chakula cha mtoto     
        [Display(Name = "1. Mama")]
        public bool Q16_a_1 { get; set; }

        [Display(Name = "2. Binti wa nyumbani")]
        public bool Q16_a_2 { get; set; }

        [Display(Name = "3. Dada/kaka zake")]
        public bool Q16_a_3 { get; set; }

        [Display(Name = "4. Wengine")]
        public bool Q16_a_4 { get; set; }

        [Display(Name = "Wengine")]
        public string Q16_a_5 { get; set; }

        //b).Kumlisha mtoto/ kuangalia mtoto anakula   
        [Display(Name = "1. Mama")]
        public bool Q16_b_1 { get; set; }

        [Display(Name = "2. Binti wa nyumbani")]
        public bool Q16_b_2 { get; set; }

        [Display(Name = "3. Dada/kaka zake")]
        public bool Q16_b_3 { get; set; }

        [Display(Name = "4. Wengine")]
        public bool Q16_b_4 { get; set; }

        [Display(Name = "Wengine")]
        public string Q16_b_5 { get; set; }

        //c).Kushinda na kumuangalia mtoto         
        [Display(Name = "1. Mama")]
        public bool Q16_c_1 { get; set; }

        [Display(Name = "2. Binti wa nyumbani")]
        public bool Q16_c_2 { get; set; }

        [Display(Name = "3. Dada/kaka zake")]
        public bool Q16_c_3 { get; set; }

        [Display(Name = "4. Wengine")]
        public bool Q16_c_4 { get; set; }

        [Display(Name = "Wengine")]
        public string Q16_c_5 { get; set; }

        [Display(Name = "Q17.Je mtoto ameshaanza shule? ")]
        public EFMOK1 Q17 { get; set; }

        [Display(Name = "Kama bado unategemea kumuanzisha akiwa na umri gani? ")]
        [Range(1, 60, ErrorMessage = "Ngapi?")]
        public uint? Q17_1 { get; set; }

        [Display(Name = "Q18. Kama hajaanza, au ameanza shule, je unaweza kuendelea kumleta ili apate huduma? ")]
        public EFMOK1 Q18 { get; set; }

        [Display(Name = "Kama ni hapana, tukimuhitaji katika muda unaotakiwa tutampataje?")]
         public string Q18_1 { get; set; }

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

    public enum EFMO48_14
    {
        [Display(Name = "1. Anatumia poti")]
        E1 = 1,
        [Display(Name = "2. Anajisaidia mwenyewe chooni")]
        E2 = 2
       

    }
}
