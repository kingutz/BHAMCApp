using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class FKMAMA : EntityData
    {

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }

        [Display(Name = "ID Number")]
        [Range(1, 1000, ErrorMessage = "ID Number?")]
        public uint? IDNumber { get; set; }

        [Display(Name = "Q1.Did you experience any of the following after delivery? Je umeshapata kati ya haya tangu ujifungue?")]
        public EFMK1 Q1 { get; set; }

        [Display(Name = "Other(specify)")]
        public string OthersQ1 { get; set; }

        [Display(Name = "Q2.Have you resumed your menses? Je umeshaanza kutumika tangu ujifungue?")]
        public EFMK2 Q2 { get; set; }

        [Display(Name = "Q3.Have you resumed sex Je umeshaanza kukutana kimwili na mume/mwenzi wako?")]
        public EFMK2 Q3 { get; set; }

        [Display(Name = "Q4.If yes are you using any contraceptive method? Kama ndiyo, unatumia njia yoyote ya kujikinga usipate mimba?")]
        public EFMK2 Q4 { get; set; }

        [Display(Name = "Itaje ")]
        public string ItajeQ4 { get; set; }

        [Display(Name = "Q5.Have you informed anybody about your HIV test results?   Je umeshamueleza mtu yeyote kuhusu majibu yako ya kipimo cha ukimwi?")]
        public EFMK5 Q5 { get; set; }

        [Display(Name = "mtaje")]
        public string Q5_1 { get; set; }

        [Display(Name = "Q6.Are you breastfeeding the infant?    Unamyonyesha mtoto?")]
        public EFMK2 Q6 { get; set; }

        [Display(Name = "Q7.Have you experienced any of these breast problems since the last visit, including currently?   Je umeshapata matatizo haya ya maziwa tangu ulipojifungua au kwa sasa unayo?")]
        public EFMK7 Q7 { get; set; }


        [Display(Name = "Q8.Do you presently have the following symptoms? Je kwa sasa una dalili zifuatazo? Je umeshapata matatizo haya ya maziwa tangu ulipojifungua au kwa sasa unayo?")]
        public EFMK8 Q8 { get; set; }

        [Display(Name = "9.Any other problem Je mama ana tatizo lingine lolote kuhusiana na afya yake? Litaje")]
        public string Q9 { get; set; }

        //PHYSICAL EXAMINATION
        [Display(Name = "1. Weight(kg)")]
        [Range(10, 120, ErrorMessage = "Weight(kg)?")]
        public uint? Q10 { get; set; }

        [Display(Name = "2. Temperature(oC)")]
        [Range(1, 42, ErrorMessage = "Temperature?")]
        public uint? Q11 { get; set; }

        [Display(Name = "3. BP(mmHg)")]
        public string Q12 { get; set; }

        [Display(Name = "Q4. General appearance")]
        public EFMK13? Q13 { get; set; }

        [Display(Name = "Q5. Mucosa/Conjuctiva")]
        public EFMK14? Q14 { get; set; }

        [Display(Name = "Q6. Oedema")]
        public EFMK2? Q15 { get; set; }

        [Display(Name = "Q7. Lymphadenopathy (neck, axilla)")]
        public EFMK2? Q16 { get; set; }

        [Display(Name = "Q8. Skin")]
        public EFMK17? Q17 { get; set; }

        [Display(Name = "Q9. Mouth	")]
        public EFMK18? Q18 { get; set; }

        [Display(Name = "Q10. Breasts")]
        public EFMK19? Q19 { get; set; }

        [Display(Name = "Q11. Abdominal palpation- uterus")]
        public EFMK20? Q20 { get; set; }

        [Display(Name = "Q12. Lochia")]
        public EFMK21? Q21 { get; set; }

        [Display(Name = "Q13. Vulva")]
        public EFMK22? Q22 { get; set; }

        [Display(Name = "Q14. Any other abnormal finding")]
        public string Q23 { get; set; }

        [Display(Name = "Problems/ Diagnosis")]
        public string ProblemsDiagnosis { get; set; }

        [Display(Name = "Management")]
        public string ManagementFK { get; set; }

        [Display(Name = "Date of 3 months visit")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateVisit3 { get; set; }
    }
    public enum EFMK1
    {
        [Display(Name = "1.Prolonged bleeding (PPH) Damu kutoka kwa muda mrefu baada ya kujifungua")]
        E1 = 1,
        [Display(Name = "2.Foul smelling lochia Uchafu unaotoa harufu ukeni")]
        E2 = 2,
        [Display(Name = "3.Lower abdominal pains Tumbo la kizazi kuuma kwa mfululizo")]
        E3 = 3, 
        [Display(Name = "4.Poor healing of episiotomy Kutopona katika sehemu iliyoongezwa njia")]
        E4 = 4,
        [Display(Name = "5.Dizzness Kizinguzungu cha mara kwa mara na moyo kwenda mbio")]
        E5 = 5, 
        [Display(Name = "6.Other problems, specify  Tatizo lingine, litaje")]
        E6 = 6
     
    }
    //Questions Repeat
    public enum EFMK2
    {
        [Display(Name = "0.No  Hapana")]
        No = 0,
        [Display(Name = "1.Yes  Ndiyo")]
        Yes = 1


    }
    public enum EFMK5
    {
        [Display(Name = "0.No   Sijamwambia mtu")]
        E0 = 0,
        [Display(Name = "1.Partner   Nimemwambia mume au mwenzi wangu")]
        E1 = 1,
        [Display(Name = "2.My mother  Mama yangu	")]
        E2 = 2,
        [Display(Name = "3.My friend   Nimemwambia rafiki yangu")]
        E3 = 3,
        [Display(Name = "4.Other specify  Mwingine, mtaje   ")]
        E4 = 4

    }
    public enum EFMK7
    {
        [Display(Name = "1.Cracked nipples  Chuchu kupata mipasuko na kuuma mtoto anaponyonya")]
        E1 = 1,
        [Display(Name = "2.Bleeding from the nipples Kutoka damu kwenye chuchu")]
        E2 = 2,
        [Display(Name = "3.Pain due to engorged breasts  Maumivu kwa ajili ya titi kuvimba")]
        E3 = 3,
        [Display(Name = "4.Breast abscess Jipu la kwenye titi")]
        E4 = 4
        

    }
    public enum EFMK8
    {
        [Display(Name = "1.Abnormal vaginal discharge Kutoka ute usio wa kawaida ukeni-unanuka, rangi njano n.k")]
        E1 = 1,
        [Display(Name = "2.Genital itching Kuwashwa sehemu za siri")]
        E2 = 2,
        [Display(Name = "3.Genital ulcers Vidonda sehemu za siri")]
        E3 = 3,
        [Display(Name = "4.Dysuria Maumivu wakati wa kwenda kukujoa")]
        E4 = 4,
        [Display(Name = "5.Oral thrush/ulcers Vidonda au utando mdomoni")]
        E5 = 5,
        [Display(Name = "6.Fever Homa kali")]
        E6 = 6


    }
    public enum EFMK13
    {
        [Display(Name = "0.Looks well")]
        E0 = 0,
        [Display(Name = "1.Looks sick")]
        E1 = 1


    }
    public enum EFMK14
    {
        [Display(Name = "0.Normal")]
        E0 = 0,
        [Display(Name = "1.Pale conjuctiva/mucosa")]
        E1 = 1


    }
    public enum EFMK17
    {
        [Display(Name = "1.Normal")]
        E1 = 1,
        [Display(Name = "2. Rashes ")]
        E2 = 2,
        [Display(Name = "3. Ulcers")]
        E3 = 3


    }

    public enum EFMK18
    {
        [Display(Name = "0. Normal")]
        E0 = 0,
        [Display(Name = "1.Oral thrush")]
        E1 = 1
    }
    public enum EFMK19
    {
        [Display(Name = "1.Normal")]
        E1 = 1,
        [Display(Name = "2. Abscess")]
        E2 = 2,
        [Display(Name = "3.Ulcers/cracks")]
        E3 = 3,
        [Display(Name = "4. Lumps")]
        E4 = 4


    }
    public enum EFMK20
    {
        [Display(Name = "0. Normal")]
        E0 = 0,
        [Display(Name = "1. Abnormal-uterus has not involuted and tender ")]
        E1 = 1
    }

    public enum EFMK21
    {
        [Display(Name = "0.Normal not foul smelling")]
        E0 = 0,
        [Display(Name = "1.Foul smelling")]
        E1 = 1
    }

    public enum EFMK22
    {
        [Display(Name = "0 normal")]
        E0 = 0,
        [Display(Name = "1.Ulcers(single/multiple)")]
        E1 = 1,
        [Display(Name = "2.Warts")]
        E2 = 2
    }
}
