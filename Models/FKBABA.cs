using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class FKBABA : EntityData
    {

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }

        [Display(Name = "ID Number")]
        [Range(1, 1000, ErrorMessage = "ID Number?")]
        public uint? IDNumber { get; set; }

        [Display(Name = "Q1. Have you resumed sex? Je mmeshaanza kukutana kimwili na mama?")]
        public EFMKM1 Q1 { get; set; }

        [Display(Name = "tangu mwezi wa baada ya kujifungua")]
        [Range(1, 24, ErrorMessage = "tangu mwezi wa baada ya kujifungua?")]
        public uint? Q1_1 { get; set; }

        [Display(Name = "Q2. Contraceptive method? Mmeshajadiliana na mama kuhusu kutumia kinga asipte mimba?")]
        public EFMKM1 Q2 { get; set; }

        [Display(Name = "Anatumia njia ipi")]
        public string Q2_1 { get; set; }

        [Display(Name = "Q3.Are you using condoms? Je mnatumia kondomu wakati mnapokutana kimwili?")]
        public EFMKM1 Q3 { get; set; }

        [Display(Name = "Q4.Have you informed anybody about your HIV test results?  " +
            "Je  mpaka sasa umeshashirikiana na  mtu yeyote kuhusu majibu yako ya kipimo cha ukimwi?")]
        public EFMK5 Q4 { get; set; }

        [Display(Name = "Mwingine, mtaje")]
        public string Q4_1 { get; set; }

        [Display(Name = "Q5.How long did you take to inform him/them?  " +
            " Je ulichukua muda gani tangu upimwe hadi ulipomueleza mwenzi au ndugu?")]
        [Range(1, 24, ErrorMessage = "How long did you take to inform?")]
        public uint? Q5 { get; set; }

        [Display(Name = "Q6. First time to check for HIV  Je ulishawahi kupima ukimwi " +
            "au tulivyokupima ilikuwa ni mara ya kwanza?")]
        public EFKBA6 Q6 { get; set; }

        [Display(Name = "Q7.Change of character Je tangu upimwe na kuchukua majibu, imekufanya ubadili mwenendo au ?")]
        public EFKBA7 Q7 { get; set; }

        [Display(Name = "Q8.If has changed how? Kama umebadili ni kwa vipi?")]
        public string Q8 { get; set; }

        [Display(Name = "Q9. Je unadhani kuwapima wanaume kipimo cha UKIMWI inasaidia? Na kwa vipi?")]
        public string Q9 { get; set; }

        // Q10.Do you presently have the following symptoms? Je kwa sasa una dalili zifuatazo?
        [Display(Name = "1.Urethral discharge  Kutoka ute/usaha sehemu za siri")]
        public EFMKM1? Q10_1 { get; set; }

        [Display(Name = "2.Genital ulcers Vidonda sehemu za siri")]
        public EFMKM1? Q10_2 { get; set; }

        [Display(Name = "3.Dysuria Maumivu wakati wa kwenda kukujoa")]
        public EFMKM1? Q10_3 { get; set; }

        [Display(Name = "4.Scrotal swelling Kuvimba makende/kokwa")]
        public EFMKM1? Q10_4 { get; set; }

        [Display(Name = "Problems/ Diagnosis")]
        public string ProblemsDiagnosis { get; set; }
    

        [Display(Name = "Management")]
        public string ManagementFT { get; set; }

        [Display(Name = "Date of next follow-up")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateFollowup { get; set; }

    }
    public enum EFKBA6
    {
        [Display(Name = "1. Nimeshawahi kupima kwingine")]
        E1 = 1,
        [Display(Name = "2. Ni mara ya kwanza")]
        E2 = 2


    }

    public enum EFKBA7
    {
        [Display(Name = "1. Nimebadili mwenendo")]
        E1 = 1,
        [Display(Name = "2. Niko vile vile")]
        E2 = 2


    }
}
