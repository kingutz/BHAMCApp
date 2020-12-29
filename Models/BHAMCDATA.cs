using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BHAMCApp.Models
{
    public class BHAMCDATA : EntityData
    {
        //Questionnaire- Female

        [Display(Name = "Respondent   identification   number:")]
        public int Rid { get; set; }

        [Display(Name = "Clinic:")]
        public string Clinic { get; set; }

        [Display(Name = "Gravida(Number  of pregnancies):")]
        public int Gravida { get; set; }

        [Display(Name = "Parity:")]
        public int Parity { get; set; }

        [Display(Name = "Matatizo  katika  ujauzito  huu?")]
        public E9 Matatizo { get; set; }

        [Display(Name = "Kama ndiyo  ni yapi?")]
        public string Kama_ndiyo { get; set; }

        [Display(Name = "Umri wa mimba")]
        [Range(1, 60, ErrorMessage = "Umri wa mimba ?")]
        public uint? Umri_wa_mimba { get; set; }

        [Display(Name = "Mahali  anapotaka  kuzalia")]
        public DateTime Tarehekuzalia { get; set; }

        [Display(Name = "Miaka  aliyoishi  Moshi")]
        [Range(1, 60, ErrorMessage = "Miaka  aliyoishi  Moshi?")]
        public uint? Miaka_Moshi { get; set; }

        [Display(Name = "Jina la anayedodosa?")]
        public string Jina_anayedodosa { get; set; }

        [Display(Name = "Tarehe")]
        public DateTime Tarehe { get; set; }

        [Display(Name = "Q1. How  old are you? Je una umri gani? years/miaka")]
        [Range(1, 60, ErrorMessage = "years/miaka?")]
        public uint? Q1 { get; set; }

        [Display(Name = "Q2. What  is your religion?  Dini")]
        public E3 Q2 { get; set; }

        [Display(Name = "Q3. What  is your tribe?  Kabila  lako?")]
        public E4 Q3 { get; set; }

        [Display(Name = "Q4. Are  you formally  employed  in which you receive  a regular  salary? Je una kazi ambayo  unapokea")]
        public E9 Q4 { get; set; }

        [Display(Name = "Q5. What  is your job?  Je unafanya  kazi gani?")]
        public E7? Q5 { get; set; }

        [Display(Name = "Q6. How  do you generate  your cash? Je unafanya  shughuli  gani  inayokupatia    kipato?")]
        public EB6? Q6 { get; set; }

        [Display(Name = "Q7. What  additional   activities  do you do to subsidise  your  income?  Je unayo  shughuli  zaidi ya  kaii yako ya sasa  inayokuongezea   kipato?")]
        public E9 Q7 { get; set; }

        [Display(Name = " Taja")]
        public string Q7_1 { get; set; }

        [Display(Name = "Q8. What  is your  approximate   income  per  month  Kwa kukadiria   kipato  chako  cha  mwezi  ni kiasi  gani?")]
        public EB8 Q8 { get; set; }

        [Display(Name = "Q9. Level  of education (number  of years of full time education  completed)  Kiwango  cha elimu uliyofikia-andika   namba ya miaka  aliyomaliza")]
        public EB9 Q9 { get; set; }

        [Display(Name = "10. House ownership  Je nyumba  unayoishi?")]
        public E13 Q10 { get; set; }

        [Display(Name = " Taja")]
        public string Q10_1 { get; set; }

        [Display(Name = "11. Walls Kuta za nyumba")]
        public E15 Q11 { get; set; }

        [Display(Name = " Nyinginezo")]
        public string Q11_1 { get; set; }

        [Display(Name = "Q12. Toilet  facility  Choo  unachotumia")]
        public EB12 Q12 { get; set; }

        [Display(Name = "Q13. you share  the toilet  with other families?  Je mnashirikiana   choo na familia   nyingine  au mnaturnia wenyewe ?")]
        public EB13 Q13 { get; set; }

        [Display(Name = "Q14. Where  do you get your water  from Maji yenu ya  matumizi  mnapata")]
        public EB14 Q14 { get; set; }

        [Display(Name = "Q15. Cooking   facility   Mara  nyingi  mnatumia  nini kwa kupikia?")]
        public EB15 Q15 { get; set; }

        //Q16 Do you own the following? (write yes or no)

        [Display(Name = "1. Radio	Redio")]
        public bool Q16_1 { get; set; }
        [Display(Name = "2. Television Televisheni")]
        public bool Q16_2 { get; set; }
        [Display(Name = "3. Fridge Friji")]
        public bool Q16_3 { get; set; }
        [Display(Name = "4. Bicycle Baisikeli")]
        public bool Q16_4 { get; set; }
        [Display(Name = "5. Car  Gari")]
        public bool Q16_5 { get; set; }
        [Display(Name = "6. Telephone  Simu")]
        public bool Q16_6 { get; set; }

        [Display(Name = "Q17. You often travel  away from your home? Je unasafiri  mara kwa mara  na kwenda  nje ya mjilmkoa    (unakaa  zaidi ya siku)?")]
        public EB17 Q17 { get; set; }

        [Display(Name = "Q18. What  is your marital  status    Hali yako ya  unyumba  kwa sasa  ikoje?")]
        public EB18 Q18 { get; set; }

        [Display(Name = "19.How  long have you lived together  Je mmeishi  pamoja  kwa muda gani?(years)")]
        [Range(1, 60, ErrorMessage = "years/miaka?")]
        public uint Q19 { get; set; }

        [Display(Name = "Q20. If  single,  divorced,  widowed  or separated  do you have a steady  partner?  Kana  hujaolewa, mmetengana,   mtalaka,  au mjane je  una mwenzi  wa kila siku?")]
        public EB20? Q20 { get; set; }

        [Display(Name = "Q21. lf  married/cohabiting    or have a steady  partner  are you in a polygamous  marriage  or relationship?Je umeolewa  au unaishi  na mume  mwenye  wake wengi ?")]
        public EB20? Q21 { get; set; }

        [Display(Name = "Namba ya wake")]
        [Range(1, 20, ErrorMessage = "Namba ya wake?")]
        public uint Q21_1 { get; set; }

        [Display(Name = "Q22. Does	your partner  have other women  outside  marriage?    Ukiacha  wake, je  mumelmwenzi   wako  ana wanawake   wengine  nje ya ndoa?")]
        public EB22? Q22 { get; set; }

        [Display(Name = "Q23. lf married/cohabiting,	how do you and your spouse/partner live? Kama  umeolewa  kuishi pamojaje wewe  na mumelmwenzi   wako  mnaishije?")]
        public EB23? Q23 { get; set; }

        [Display(Name = "mara ngapi kwa wiki")]
        [Range(1, 20, ErrorMessage = "mara ngapi kwa wiki?")]
        public uint Q23_1 { get; set; }

        [Display(Name = "0ther/Nyinginezo")]
        public string Q23_2 { get; set; }

        [Display(Name = "Q24. Have  you had other partners  before  your current  spouse/partner?Je umeshakuwa   na mwenzi/ wapenzi  wengine  kabla ya huyu mume / mwenzi   wako wa sasa ?")]
        public EB20? Q24 { get; set; }

        [Display(Name = "How many years")]
        [Range(1, 60, ErrorMessage = "How many years")]
        public uint Q24_1 { get; set; }

        [Display(Name = "Q25. How  old were you when you got married/cohabited  for the  l  time ? Ulikuwa  na umri gam ulipoolewa   kwa mara ya  kwanza (years /miaka)")]
        [Range(1, 60, ErrorMessage = "years")]
        public uint Q25 { get; set; }

        //Q26.Have  you ever   experienced   any of the following  forms of violence  from your partner?
        //Je umeshawahi   kufanyiwa  yafuatayo   na mumelmwenzi   wako?                  

        [Display(Name = "1. Verbal use Kutukanwa,kusemwa  kwa kejeli")]
        public EB20? Q26_1 { get; set; }

        [Display(Name = "No of times")]
        [Range(1, 30, ErrorMessage = "No of times")]
        public uint Q26_1_1 { get; set; }

        [Display(Name = "2. Physical  assault Kupigwa  au kutandikwa")]
        public EB20? Q26_2 { get; set; }

        [Display(Name = "No of times")]
        [Range(1, 30, ErrorMessage = "No of times")]
        public uint Q26_2_1 { get; set; }

        [Display(Name = "3. Sexual  abuse   Kufazimishwa   kufanya  mapenzi  bila idhiniyako")]
        public EB20? Q26_3 { get; set; }

        [Display(Name = "No of times")]
        [Range(1, 30, ErrorMessage = "No of times")]
        public uint Q26_3_1 { get; set; }

        [Display(Name = "4. 0ther   specify  Nyinginezo")]
        public string Q26_4 { get; set; }

        [Display(Name = "No of times")]
        [Range(1, 30, ErrorMessage = "No of times")]
        public uint Q26_4_1 { get; set; }

        [Display(Name = "Q27. Have  you ever  been forced  to have sex without  your consent?   Je umeshawahi  kulazimishawa kufanya  mapenzi  kwa nguvu  bila idhini yako  au kubakwa?")]
        public EB20? Q27 { get; set; }

        [Display(Name = "na nani")]
        public string Q27_1 { get; set; }

        [Display(Name = "Q28a. Do  you drink  alcohol? Je  unakunywa  pombe ?")]
        public EB20 Q28a { get; set; }

        [Display(Name = "Q28b. If yes, how often? Kana  ndiyo  ni kwa kiasi gani?")]
        public EB28b Q28b { get; set; }

        [Display(Name = "Q28c. Do  you smoke  or take any of the following Je unavuta  au kutumia  vitu vifuatavyo ?")]
        public EB28c Q28c { get; set; }


        // AM  GOING TO ASK YOU A FEW QUESTIONS CONCERNING YOUR PARTNER
        // NITAKUULIZA MASWALI MACHACHE KUHUSU  MWENZI WAKO

        [Display(Name = "Q29. How  old is your present  partner   Mume/mwenzi   wako ana umri gani (years)")]
        [Range(1, 120, ErrorMessage = "How  old?")]
        public uint Q29 { get; set; }

        [Display(Name = "Q30. What is the highest  level of formal  education  he has completed Kiwango  cha elimu  aliyofikia?")]
        public EB30 Q30 { get; set; }

        [Display(Name = "Q31. What is your partner's main occupation? Je mume/mwenzi wako  anafanya  kazi gani?")]
        public EB31 Q31 { get; set; }

        [Display(Name = "Nyingine")]
        public string Q31_1 { get; set; }

        [Display(Name = "Q32. Does  your partner  travel  out of town frequently? Je mwenzi  wako  anasajiri  mara  kwa mara?")]
        public EB20 Q32 { get; set; }

        [Display(Name = "times  a month")]
        [Range(1, 31, ErrorMessage = "month?")]
        public uint Q32_1 { get; set; }

        [Display(Name = "Q33. ls  he circumcised? Je ametahiriwa?")]
        public EB20 Q33 { get; set; }

        [Display(Name = "Q34. Does  your partner  drink alcohol Je mumelmwenzi   wako  anakunywa  pombe ?")]
        public EB34 Q34 { get; set; }

        [Display(Name = "(Q34b). Does your partner  smoke  or take any of the following   Je anavuta  au kutumia  vitu vifuatavyo?")]
        public EB28c Q34b { get; set; }

        //KNOWLEDGE	OF STIs lHIV    NITAKUULIZA   MASWALI MACHACHE   KUPATA  MAWAZO YAKO JINSI
        //UNAVYOELEWA   KUHUSU  MAGONJWA YA ZINAA  NA  UKIMWI

        //Q35. Can  you please  mention  any sexually  transmitted  disease(s)  you know?  (Inteviewer  record  all the
        //responses but do not prompt  participant)  Je unaweza  ukaniambia ni magonjwa gani  unayoyajua ambayo 
        //hutokana na kukutana kimwili/  kujamiiana? (Usidodose, andika majibu yote  mama anayoyataja)

        [Display(Name = "0. None  Sifahamu")]
        public bool Q35_0 { get; set; }

        [Display(Name = "1. Gonorrhoea Kisonono")]
        public bool Q35_1 { get; set; }

        [Display(Name = "2. Syphilis Kaswende")]
        public bool Q35_2 { get; set; }

        [Display(Name = "3. Chancroid Pangusa")]
        public bool Q35_3 { get; set; }

        [Display(Name = "4. HIV/AIDS UKIMWI")]
        public bool Q35_4 { get; set; }

        [Display(Name = "5. Genital  herpes Herpes")]
        public bool Q35_5 { get; set; }

        [Display(Name = "6. Genital  ulcer Vidonda sehemu ya siri")]
        public bool Q35_6 { get; set; }
        [Display(Name = "7. Trichomoniasis Trikomona")]
        public bool Q35_7 { get; set; }

        [Display(Name = "8. Chlamydia Klamedia")]
        public bool Q35_8 { get; set; }

        [Display(Name = "9. Pubic  lice!crabs chawa sehemu  Za siri")]
        public bool Q35_9 { get; set; }

        [Display(Name = "10. Genital  warts Kuota nyama sehemu za siri")]
        public bool Q35_10 { get; set; }

        [Display(Name = "11. Others")]
        public bool Q35_11 { get; set; }

        [Display(Name = "Others")]
        public string Q35_12 { get; set; }

        //Q36.a) Do  you think  a woman  infected  with STOs   Je  unadhani    mwanamke    
        //akiwa   na  magonjwa    ya  zinaa
        // (msomee majibu    na achague lililo  sahihi)

        [Display(Name = "1. Will always  have symptoms Ni  lazima   awelaonyeshe dalili za  ugonjwa mara yote")]
        public bool Q36_1 { get; set; }

        [Display(Name = "2. Sometimes   they will not have symptoms Kuna   wakati atakuwa hanalhaonyeshi dalili")]
        public bool Q36_2 { get; set; }

        [Display(Name = "3. Never  have symptoms Mara zote  anakuwa  hana  dalili za ugonjwa")]
        public bool Q36_3 { get; set; }

        [Display(Name = "4. 1 don't  know Sifahamu")]
        public bool Q36_4 { get; set; }

        //Q36b).Can  you mention  symptoms  that might cause you to suspect  that you have an STO?
        //(Inteviewer record  all the responses  but do not prompt   participant)  
        //Je  unadhani  ni  dalili gal1l  ambazo mwanamke	atakuwa    nazo   akiwa   na magonjwa    ya  zinaa/yaletwayo   na kujamiiana?

        [Display(Name = "O. None Sifahamu")]
        public bool Q36b_0 { get; set; }

        [Display(Name = "1. Genital  ulcers  Vidonda sehemu za siri")]
        public bool Q36b_1 { get; set; }

        [Display(Name = "2. Genital itch Kuwashwa")]
        public bool Q36b_2 { get; set; }
        [Display(Name = "3. Spotting Domu siku ambazo sio za mwezi")]
        public bool Q36b_3 { get; set; }

        [Display(Name = "4. Abnormal vaginal discharge Kutoka lite  usio  wa  kawaida-mwingi, harufu mbaya ukeni")]
        public bool Q36b_4 { get; set; }

        [Display(Name = "5. Lower  abdominal	pain  Kuumwa tumbo   kwenye    kizazi   all  upande   wa  chini")]
        public bool Q36b_5 { get; set; }

        [Display(Name = "6. Pain during  sex	Kupata maumivu wakati wa  kufanya mapenzi")]
        public bool Q36b_6 { get; set; }

        [Display(Name = "7. Pain Micturation Kupata  maumivu  wakati  wa  unapoenda haja ndogo/kukojoa")]
        public bool Q36b_7 { get; set; }

        [Display(Name = "8. Others  Nyinginezo")]
        public bool Q36b_8 { get; set; }

        [Display(Name = "Others  Nyinginezo")]
        public string Q36b_9 { get; set; }

        //Q37 Do  you know any consequences   of untreated  STOs?  (Inteviewer  record  all the responses  
        //but do not prompt  participant) Je  unajua   ni  madhara    gani   mwanamke
        // anaweza    kupata    akiwa na  magonjwa yo zinaa?(Usidodose, andika majibu yote mama anayoyataja)

        [Display(Name = "O. None Sijui")]
        public bool Q37_0 { get; set; }

        [Display(Name = "1. Infertility Ugumba/kutopata mtoto")]
        public bool Q37_1 { get; set; }

        [Display(Name = "2. PID/Pelvic pain Maumivu  makali ya  mara kwa mara katika sehemu ya kizazi")]
        public bool Q37_2 { get; set; }

        [Display(Name = "3. Recurrent  abortions/stillbirths/PROM/Pre-term delivery (adverse  pregnancy outcomes)Mimba   kuharibika /kuzaa mtoto kuzaa  kabla ya muda")]
        public bool Q37_3 { get; set; }

        [Display(Name = "4. Transmit	the infections  to the newborn-opthalmia neonatorum,  pneumonia,  congenital syphilis,  HIV Kumwambukiza mtoto magonjwa wakati anapozaliwa")]
        public bool Q37_4 { get; set; }

        [Display(Name = "5. Can easily get or transmit  HIV-I Kupatwa au kuambukiza UKIMWI kwa  urahisi")]
        public bool Q37_5 { get; set; }

        [Display(Name = "6. Others  Nyinginezo")]
        public bool Q37_6 { get; set; }

        [Display(Name = "Others  Nyinginezo")]
        public string Q37_7 { get; set; }

        //Q38.Name ways you know of preventing  STOs.  (Record all the responses)   Unaweza kuniambia   ni njia
        //zipi utatumia  ili kuepuka/kujikinga kupata  magonjwa ya zinaa

        [Display(Name = "O. None Sijui")]
        public bool Q38_0 { get; set; }

        [Display(Name = "1. Abstinance  Kuacha    kufanya    mapenzi    kabisa")]
        public bool Q38_1 { get; set; }

        [Display(Name = "2. Consistent   condom  use Kutumia  kondomu  kila  wakati wa kujamiiana")]
        public bool Q38_2 { get; set; }

        [Display(Name = "3.Monogamy Kuwa   na  mpenzi/mwenzi mmoja   tu")]
        public bool Q38_3 { get; set; }

        [Display(Name = "4. Get tested  before  marriage/before  starting  new relationships Kupima kabla ya kuanza kujamiiana/au  kabla ya ndoa")]
        public bool Q38_4 { get; set; }

        [Display(Name = "5. Others  Nyinginezo")]
        public bool Q38_5 { get; set; }

        [Display(Name = "Others  Nyinginezo")]
        public string Q38_6 { get; set; }

        [Display(Name = "Q39. Would  a man infected  with an STOs have symptoms?   Je  kama   mwanaume akiwa na magonjwa ya zinaa, atakuwa    na  dalili   zozote ?")]
        public EB39 Q39 { get; set; }


        //Q40. What symptoms  or signs he might have?  (Record  all responses  do not prompt).
        //Ni  dalili   zipi atakazokuwa   nazo?

        [Display(Name = "1. Penile  discharge Kutoka uchafu  all usaha sehemu za siri")]
        public bool Q40_1 { get; set; }

        [Display(Name = "2. Genital  ulcer Vidonda sehemu za siri")]
        public bool Q40_2 { get; set; }

        [Display(Name = "3. Painful  micturation Maumivu makali wakati akikojoa")]
        public bool Q40_3 { get; set; }

        [Display(Name = "4. Scrotal  swelling  Kuvimba  makende")]
        public bool Q40_4 { get; set; }

        [Display(Name = "5. Others  Nyingine")]
        public bool Q40_5 { get; set; }

        [Display(Name = "Others/Nyingine")]
        public string Q40_6 { get; set; }


        [Display(Name = "Q41. Have  you known  anyone  with HIV/ Al OS in this/your  community? yeyote aliyepatwa na  UKlMWI kwenye jumuiya yako ?")]
        public EB20 Q41 { get; set; }

        [Display(Name = "(Q41b). Have  you had a close relative  who has been infected  or died with HIV/AIDS? Je umeshawahi kupata    ndugu   wa  karibu   ambaye    ameathirika     au  kufa   kutokana    na  UKlMWI?")]
        public EB20? Q41b { get; set; }

        [Display(Name = "Q42.  Do  you think  a person  infected  with HIV always shows signs or can such a person  look perfectly healthy?	Je mtu anaweza kuwa  na virusi vya UKIMWI bila kuonyesha dalili za ugonjwa?")]
        public EB42 Q42 { get; set; }

        [Display(Name = "Q43. Can  someone  who looks healthy  but who has the HIV virus pass it on to other people? Je mill anayeonekana   kuwa na afya nzuri lakini  ana virusi vya  UKlMWI  anaweza  kuwaambukiza   wengine ?")]
        public EB22 Q43 { get; set; }

        [Display(Name = "Q44. Can  a woman  pass HIV-1  her baby? (Do  not probe)    Je mama  aliyeathirika   na viini vya  UKIMWI anaweza  kumuambukiza   mwanae  aliye tumboni ?")]
        public EB22 Q44 { get; set; }

        [Display(Name = "(Q44b). If yes,when does this happen?  (Do not probe  record  all the responses)   Kama  ndiyo,  inawez a kutokea  wakati  gani?")]
        public EB44b? Q44b { get; set; }

        [Display(Name = "Q45. How  do you rate your chances  of being  infected  by HIV  Je ukijikiria,  unajiona  upo kwenye  hatari ya  kuambukizwa   ugonjwa  wa UKlMWf?")]
        public EB45 Q45 { get; set; }

        //Q46. Why do you feel you have no risk?  Kwa nini unaona huna hatari?

        [Display(Name = "1. I am married Nimeolewa")]
        public bool Q46_1 { get; set; }

        [Display(Name = "2. Had  only one sexual  partner  in my lifetime  Nimekuwa  na mwenzi/mpenzi mmoja  tu kwa maisha yangu  yote")]
        public bool Q46_2 { get; set; }

        [Display(Name = "3. Currently, [ have only one sexual  partner  Kwa sasa nina mpenzi/mwenzi mmoja  tu")]
        public bool Q46_3 { get; set; }

        [Display(Name = "4. [ trust my partner/he is faithful Mume wangu  ni mwaminifu/  ninamuamini")]
        public bool Q46_4 { get; set; }

        [Display(Name = "5.[ always  use condom  during  sex Ninatumia  kondomu  kila ninapofanya   mapenzi")]
        public bool Q46_5 { get; set; }

        [Display(Name = "6. 0thers  Nyinginezo")]
        public bool Q46_6 { get; set; }

        [Display(Name = "0thers/Nyinginezo")]
        public string Q46_7 { get; set; }

        //Q47. Why do you feel you are at risk? Kwa nini unajiona  uko kwenye  hatari ya  kuambukizwa?

        [Display(Name = "1. Partner  cannot  be trusted Simuamini  mume/  mwenzi  wangu")]
        public bool Q47_1 { get; set; }

        [Display(Name = "2. Partner  has other sexual  partners Mume/mwenzi   wangu  ana wapenzi  wengine/  wengi")]
        public bool Q47_2 { get; set; }

        [Display(Name = "3. I have more than one partner  Nina wapenzi  wengi")]
        public bool Q47_3 { get; set; }

        [Display(Name = "4. We  don't  use condoms  Situmii  kondomu  wakati  ninapofanya   mapenzi")]
        public bool Q47_4 { get; set; }

        [Display(Name = "5. [ am in polygamous  marriage/relationship Niko kwenye  hali ya  uke wenza")]
        public bool Q47_5 { get; set; }

        [Display(Name = "6. 0thers  Nyinginezo")]
        public bool Q47_6 { get; set; }

        [Display(Name = "0thers  Nyinginezo")]
        public string Q47_7 { get; set; }

        //Q48.Can  you discuss  issues regarding  HIV/ AIDS with Je unaweza  kuongelea kuhusu  UKlMW/  na?

        [Display(Name = "1. Family  member(s)  Ndugu/watu wafamilia")]
        public EB20 Q48_1 { get; set; }

        [Display(Name = "2. Spouse   Mume/  mwenzi  wako")]
        public EB20 Q48_2 { get; set; }

        [Display(Name = "3. Friends  Marafiki")]
        public EB20 Q48_3 { get; set; }


        [Display(Name = "Q49. Should	persons  who know they are infected  with HIV be entitled  to keep this fact a secret  from the community	where  they live or should  this information  be revealed?    Je unadhanikuwa   watu wanaojijua   wameathirika   na Ukimwi wana  haki ya kutomwambia/kutowaambia     watu wengine juu ya  hali hiyo na iwe ni siriyao   au !111 adh ant' hali hiyo iwe wazi kwa watu wote wa jumuiya/jamii wanapoishi?")]
        public EB49 Q49 { get; set; }

        [Display(Name = "Q49b). Why  to either  response   1 or 2? Kwa nini kwajibu   namba  1 au 2")]
        public string Q49b { get; set; }

        [Display(Name = "Q50. Should  a person  infected  with HIV tell their partners? Je unadhani  mtu aliyeathirika   na UKIMWI amwambie  hali hiyo mwenzi / mume   wake ?")]
        public EB22 Q50 { get; set; }

        [Display(Name = "Q50b). Why to the answer above? Kwa nini?")]
        public string Q50b { get; set; }

        //MEDICAL  HISTORY  MASWALI  KUHUSU   MAMBO  YANAYOHUSIANA NA AFYA   YAKO

        [Display(Name = "Q51. Are  you circumcised?Je umetahiriwa   au umekeketwa ?")]
        public EB20 Q51 { get; set; }

        [Display(Name = "Umri  alipotahiriwa")]
        [Range(0, 70, ErrorMessage = "Umri  alipotahiriwa")]
        public uint? Q51_1 { get; set; }

        [Display(Name = "(Q51b). Who did the circumcision? Nani  aliyekutahiri?")]
        public string Q51b { get; set; }


        [Display(Name = "Q52. If you have a daughter,  do you plan to have her circumcised? Kama  una mtoto  wa kike,  je  una mpango  wa kumpeleka   kutahiriwa/kukeketwa?")]
        public EB20 Q52 { get; set; }

        [Display(Name = "(Q52b). Why or why not?  Kwanini?")]
        public string Q52b { get; set; }

        //Vaginal   hygiene   practice

        [Display(Name = "Q53. Do you usually  clean  inside the vagina  (please  elaborate  the difference  between  vulva  and the vagina)	Je kwa kawaida  unasajisha  ndani ya  uke?")]
        public EB20 Q53 { get; set; }

        [Display(Name = "Q54. Number  of times  per day Mara ngapi  kwa siku ?")]
        public EB54? Q54 { get; set; }

        [Display(Name = "Q55. If yes, what do you use   Kama  ndiyo,je   unatumia  nini?")]
        public EB55? Q55 { get; set; }

        [Display(Name = "Others Nyinginezo")]
        public string Q55_1 { get; set; }

        [Display(Name = "Q56. If yes, what do you use to wash withJe unatumia  nini kusafishia ?")]
        public EB56? Q56 { get; set; }

        [Display(Name = "Others")]
        public string Q56_1 { get; set; }

        [Display(Name = "Q57. Why  do you wash  inside the vagina  and not only the vulva area?    Kwa nini unasaflsha  ndani ya  uke na sio tu eneo la nje?")]
        public string Q57 { get; set; }

        [Display(Name = "Q58. Do you think this practice  harmful  to your health?    Je unadhani  unaweza  utadhurika   afya yako kutokana  na kufanya  hivyo?")]
        public EB20 Q58 { get; set; }

        [Display(Name = "Q59. Do you always  or often  use something  to tighten  or to dry the vagina  before  having  sexual intercourse?	Je unatumia  vitu vya kukausha  au kufanya  uke ubane  kabla ya  kufanya  mapenzi?")]
        public EB20 Q59 { get; set; }

        [Display(Name = "Q60. What  substances  do you use?  Je ni vitu gani  unavyotumia?")]
        public string Q60 { get; set; }

        [Display(Name = "Q61. Do you think  using  intravaginal  herbs/reagents is harmful  to your health? Je unadhani  tabia yo kuweka  madawa  ndani ya  uke ili kubana/kuufanya    mkavu  inaweza  ikadhuru  afya ya  mwanamke?")]
        public EB22? Q61 { get; set; }

        //Q62 During   the  past  5 years  have  you  had    Je katika  kipindi  cha miaka  5 iliyopita

        [Display(Name = "Q62. Blood  transfusion(s) Uliwahi  kuongezewa damu")]
        public EB20 Q62 { get; set; }

        [Display(Name = "How many times")]
        [Range(1, 20, ErrorMessage = "How many times")]
        public uint? Q62_1 { get; set; }

        [Display(Name = "Q63. lnjection(s)   Uliwahi  kupigwa  sindano")]
        public EB20 Q63 { get; set; }

        [Display(Name = "How many times")]
        [Range(1, 20, ErrorMessage = "How many times")]
        public uint? Q63_1 { get; set; }

        //During   the  past  12 months,   have  you  been  treated   for
        //umeshawahi kutibiwa   kwa ajili ya hali  zifuatazo?
        //Katika kipindi cha miezi 12 lliyopita, je

        [Display(Name = "Q64. Abnom1al  vaginal  discharge   Kutoka  ute usio wa kawaida")]
        public EB20 Q64 { get; set; }
        
        [Display(Name = "Q65. Genital   ulcers   Vidonda  sehemu ya siri")]
        public EB20 Q65 { get; set; }

        [Display(Name = "66.Genital  itching    Kuwashwa  sehemu  za siri")]
        public EB20 Q66 { get; set; }

        [Display(Name = "67.Genital  warts   Kuota  vinyama  katika sehemu  za siri ")]
        public EB20 Q67 { get; set; }

        [Display(Name = "68. Painful  micturation    Kupata  maumivu  wakati  wa kukojoa")]
        public EB20 Q68 { get; set; }

        //-If yes to any of the above  (Q 64-68),  did you inform your sexual partner
        //Kama  ndiyo  kwa swali namab  64-68, je  ulimjulisha  mwenzi  wako juu ya  dalili hizo?

        [Display(Name = "-If yes to any of the above  (Q 64-68),  did you inform your sexual partner   Kama  ndiyo  kwa swali namab  64-68, je  ulimjulisha  mwenzi  wako juu ya  dalili hizo?")]
        public EB20 Q64_68 { get; set; }

        [Display(Name = "-If not why?  Kama  hapana  ni kwa nini? ")]
        public string Q64_68_1 { get; set; }

        [Display(Name = "Q69. History	of small recurring  ulcers  (herpes)?    Je umeshawahi  kupatwa  na vidonda  vidogovidogo ukeni  ambavyo  hupona  na kurudia  mara  kwa mara?             ")]
        public EB20 Q69 { get; set; }

        //Have  you  had  any  of these  before     Je umeshawahi    kutibiwa  magonjwa  yafuatayo?
        [Display(Name = "Q70. Tuberculosis Kifua  kikuu")]
        public EB20 Q70 { get; set; }

        [Display(Name = "Q71. Schistosoiniasis Kichocho")]
        public EB20 Q71 { get; set; }

        //Do you  presently   have  the  following  symptoms    Je kwa sasa hivi una  dalili zifuatazo?

        [Display(Name = "Q72. Prolonged	fever, > 1  month Homa za muda  mrefu zaidi ya mwezi mmoja")]
        public EB20 Q72 { get; set; }
        [Display(Name = "Q73. Prolonged cough, > I month Kikohozi  cha muda mrefu zaidi ya mwezi")]
        public EB20 Q73 { get; set; }
        [Display(Name = "Q74. Prolonged diarrhoea, > I month Kuharisha  kwa zaidi ya mwezi")]
        public EB20 Q74 { get; set; }
        [Display(Name = "Q75. Pruritic  dermatitis Ugonjwa  wa ngozi wa muda mrefu")]
        public EB20 Q75 { get; set; }
        [Display(Name = "Q76. Abnormal vaginal  discharge? Kutoka ute usio wa kawaida ukeni")]
        public EB20 Q76 { get; set; }
        [Display(Name = "Q77. Genital  itching/irritation Kuwashwa sehemu za siri")]
        public EB20 Q77 { get; set; }
        [Display(Name = "Q78. Genital  ulcer Vidonda katika sehemu  za siri")]
        public EB20 Q78 { get; set; }
        [Display(Name = "Q79. Genital  warts Kuota  vinyama  katika sehemu  za siri")]
        public EB20 Q79 { get; set; }
        [Display(Name = "Q80.Pain  during  intercourse Kupata  maumivu  wakati  wa kufanya  mapenzi")]
        public EB20 Q80 { get; set; }
        [Display(Name = "Q81. Painful  micturation Kupata  maumivu  wakati  unapoenda  haja ndogo")]
        public EB20 Q81 { get; set; }

        [Display(Name = "Q82. If yes, to any of the above  (Q 76-81) Kama ni ndiyo  kati ya swali  namba  76-81a. For how long have you had the symptoms ? Je uligundua  una dalili hizo tangu  lini ? days / weeks / months   ago")]
        [Range(1, 20, ErrorMessage = "How many times")]
        public uint? Q82 { get; set; }

        [Display(Name = "Q82b.Have  you sought  care?   Je umesha tafuta msaada  kwa ajili ya  dalili hizo?")]
        public EB20 Q82b { get; set; }

        [Display(Name = "Where  wapi?")]
        public string Q82b_1 { get; set; }

        [Display(Name = "Matibabu  aliyopewa?")]
        public string Q82b_2 { get; set; }

        [Display(Name = "Q82c. If you   sought  care, how long did you take after noticing  the symptoms? Kama  ulichukua  hatua, je  ulichukua  muda gani toka uone da/i/i hadi kutafuta  msaada? days/weeks/months")]
        [Range(1, 52, ErrorMessage = "how long?")]
        public uint? Q82c { get; set; }

        [Display(Name = "Q82d. If you   took  more than a week, why?  Unaweza  kunieleza  kwa nini ulichukua  zaidi ya siku saba kabla ya  kutafuta  ushauri?")]
        [Range(1, 52, ErrorMessage = "how long?")]
        public string Q82d { get; set; }

        [Display(Name = "Q82e. Why  haven't  you sought  care?    Kwa nini hujatafuta  huduma  au ushauri  hadi sasa?")]
        [Range(1, 52, ErrorMessage = "how long?")]
        public string Q82e { get; set; }

        [Display(Name = "Q82f. Have you informed  your partner  about the symptoms   Je umeshamueleza   mwenzi  wako ju ya  dalili hizi?")]
        public EB20 Q82f { get; set; }

        [Display(Name = "Q82h. Did you use condoms  during  sex while symptomatic?    Je mlitumia  kondomu  wakati  wa kufanya mapenzi?")]
        public EB20 Q82h { get; set; }


        //Does your  husband/regular partner, presently   have the  following symptoms Je mwenzi/mume 
        //wako  ana  dalili zifuatazo?

        [Display(Name = "Q83. Discharge from his penis Kutoka  ute au usaha kwenye  uume?")]
        public EB22 Q83 { get; set; }

        [Display(Name = "Q84. Genital  ulcer/sore(s)     Vidonda sehemu  za siri?")]
        public EB22 Q84 { get; set; }

        //NOW   I  AM  GOING   TO  ASK  YOU  A  FEW  QUESTIONS    RELATING   TO  YOUR   SEXUAL HISTORY
        //NITAKUULIZA   MASWALl   MACHACHE   KUHUSU  KUKUTANA   KlMWILl


        [Display(Name = "Q85. How  old were you when you had sexual  intercourse  for the first time?   Ulikuwa    na  umri  gani ulipokutana kimwili   mara  ya  kwanza ? (Miaka/years)")]
        [Range(1, 75, ErrorMessage = "How  old?")]
        public uint? Q85 { get; set; }

        [Display(Name = "Q86. Was  it voluntary/  did you want to do it? Je  ulitaka   kufanya    kitendo    hicho   au  ulilazimishwa?")]
        public EB20 Q86 { get; set; }

        [Display(Name = "Q87. How  old was your sexual  partner  at that time?  Je  unakumbuka      mwenzi    wako   kwa  wak ati  huo alikuwa    na  umri  gani? (Miaka/years)")]
        [Range(1, 75, ErrorMessage = "How  old?")]
        public uint? Q87 { get; set; }

        [Display(Name = "Q88. Did   you use a condom  during  your first sexual  encounter?    Je  ulitumia    kondomu     ulipokutana kimwili    kwa  mara  ya  kwanza?")]
        public EB20 Q88 { get; set; }

        [Display(Name = "Q89. 0uring   the last  12 months  have you had any other sexual  partner/s  besides  your regular  partner? Je ni watu wangapi tofauti   ambao   umekutana     nao  kimwili   kwa  kipindi  cha  miezi 12 iliyopita ukiacha  mwenzi / mume wako ?")]
        public EB20 Q89 { get; set; }

        [Display(Name = "Idadi")]
        [Range(1, 100, ErrorMessage = "Idadi?")]
        public uint? Q89_1 { get; set; }

        [Display(Name = "Q90. How  many sexual  partners  have you had in your life time  including  your current  partner?    Je  k11'(1 ujumla    ukimweka     na  mume/mwenzi      wako   wa  kila  siku,   umeshakuwa      na  wenzi   /wapenzi     wangapi tangu   ulipokutana      kimwili    kwa  mara  ya  kwanza    hadi  sasa?")]
        public EB90 Q90 { get; set; }

        [Display(Name = "Idadi")]
        [Range(1, 100, ErrorMessage = "Idadi?")]
        public uint? Q90_1 { get; set; }

        //CONDOM   USE MASWALJ  MACHACHE   KUHUSU  KONDOMU
        [Display(Name = "Q91. You know where to get condoms') Je  unafahamu     mahali    au  kwa  mtu  yeyote    ambapo    unawe:a kupatakondomu/mpira wa  kuuvisha uume unapouhitaji?")]
        public EB20 Q91 { get; set; }

        //Q92. Where  can one get them-multiple   responses       Je  utazipata    wapi   utakapozihitaji?

        [Display(Name = "1. Pharmacy     duka la dawa")]
        public bool Q92_1 { get; set; }

        [Display(Name = "2. Clinics/hospitals zahanatilhospitali")]
        public bool Q92_2 { get; set; }

        [Display(Name = "3. Bars/Guest   houses/Hotels bar/nyumba za wageni/mahotelini")]
        public bool Q92_3 { get; set; }

        [Display(Name = "4. YCT  centres sehemu wanapotoa  ushauri nasaha kuhusu ukimwi")]
        public bool Q92_4 { get; set; }

        [Display(Name = "5. At work places sehemu za kazi")]
        public bool Q92_5 { get; set; }

        [Display(Name = "6. From  friends Marafiki")]
        public bool Q92_6 { get; set; }

        [Display(Name = "7.0thers Kwingine")]
        public bool Q92_7 { get; set; }

        [Display(Name = "8.0thers")]
        public string Q92_8 { get; set; }

        [Display(Name = "Q93. Have  you ever used a condom?  Je  umewahi kutumia kondomulmpira wa kuuvisha uume wakati wa kukutana  kimwili ?")]
        public EB20 Q93 { get; set; }

        //Q94. Why  not (multiple  responses)      Kwa   nini  hujawahi    kuutumia?  
        [Display(Name = "1. Not  available Hazipatikani kiurahisi")]
        public bool Q94_1 { get; set; }

        [Display(Name = "2.Partner  objected  Mwenzi wangu hazipendi/alikataa")]
        public bool Q94_2 { get; set; }

        [Display(Name = "3. Personal   dislike Sipendi kuzitumia")]
        public bool Q94_3 { get; set; }

        [Display(Name = "4. Reduces   sexual  pleasure Zinapunguza starehe wakati wa kufanya mapenzi")]
        public bool Q94_4 { get; set; }

        [Display(Name = "5. We  have never  discussed  about  them with my partner Hatujawahi kujadili kuhusu swala la kuzitumia	na  mwenzangu")]
        public bool Q94_5 { get; set; }

        [Display(Name = "6. 0thers")]
        public bool Q94_6 { get; set; }

        [Display(Name = "0thers")]
        public string Q94_7 { get; set; }

        [Display(Name = "Q95.How  often  do you use a condom   Je  unatumia    kondomu?")]
        public EB95? Q95 { get; set; }

        [Display(Name = "Q96. Who normally  initiates  condom  use? mnapokutana kimwili ?")]
        public EB96 Q96 { get; set; }

        //Q97.Reasons   for using condoms     Je  mara   nyingi   unapotumia  
        //kondomu    ni  kwa  ajili  ya  ttiki   majibu    vote)  
        
        [Display(Name = "1. Prevention of pregnancy Kujikinga kutopata mimba")]
        public bool Q97_1 { get; set; }

        [Display(Name = "2. Prevention   of STOs Kujikinga nisipate magonjwa ya zinaa")]
        public bool Q97_2 { get; set; }

        [Display(Name = "3. Prevention  of HIV Kujikinga nisipate ukimwi")]
        public bool Q97_3 { get; set; }

        [Display(Name = "4. When  I have casual  partners  Ninapokutana  na wanaume wengine")]
        public bool Q97_4 { get; set; }               

        [Display(Name = "5. 0thers/Nyinginezo")]
        public bool Q97_5 { get; set; }

        [Display(Name = "0thers/Nyinginezo")]
        public string Q97_6 { get; set; }

        [Display(Name = "Q98. Did  you use the condom  during your last sexual encounter? Je ulitumia kondomu mlipoktana kimwili mara  ya  mwisho na  mwenzi/mume  wako? ")]
        public EB20 Q98 { get; set; }

        [Display(Name = "Q99. Have  you ever heard  about the female condom?Je  umeshawahi kusikia kuhusu kondomu    za  kike? ")]
        public EB20 Q99 { get; set; }

        [Display(Name = "je  umeshawahi kuitumia")]
        public EB20? Q99_1 { get; set; }


        //I00.Have you ever practiced  the following?       Je umeshawahi     kukutana kimwili
        [Display(Name = "1. Having  sex during  menstruation Wakati ukiwa mwezini")]
        public EB20? Q100_1 { get; set; }

        [Display(Name = "2. Anal  sex   Kwa  kutumia    njia  ya  haja   kubwa")]
        public EB20? Q100_2 { get; set; }

        //I   AM    GOING     TO    ASK    YOU    SOME     QUESTIONS   
        //ABOUT    YOUR    REPRODUCTIVE HEALTH NITAKUULIZA MASWALI MACHACHE KUHUSU  MAMBO  YA UZAZI


        [Display(Name = "Q101. How  old  were  you  when  you  got  pregnant  the the  1st time?Je ulikuwa na umri gani   ulipoputa ujauzito kwa  mara  ya  kwanza ?( Miaka/years)")]
        [Range(10, 45, ErrorMessage = "Umri?")]
        public uint? Q101 { get; set; }

        [Display(Name = "Q102. Number  of living children Unajumla ya watoto wangapi walio hai?")]
        [Range(1, 30, ErrorMessage = "Idadi?")]
        public uint? Q102 { get; set; }

        //Have  you  ever  had  pregnancy    that;    Umeshawahi   kupata  ujauzito  ambao 
        [Display(Name = "Q103. Ended  in confirmed  spontaneous  abortion    Mimba ilitoka yenyewe")]
        public EB20 Q103 { get; set; }

        [Display(Name = "No of times")]
        [Range(1, 30, ErrorMessage = "No of times?")]
        public uint? Q103_1 { get; set; }

        [Display(Name = "Q104. Ended  in stillbirth  Mtoto   alizaliwa    amekufa")]
        public EB20 Q104 { get; set; }

        [Display(Name = "No of times")]
        [Range(1, 30, ErrorMessage = "No of times?")]
        public uint? Q104_1 { get; set; }

        [Display(Name = "Q105. Was an ectopic  pregnancy  (ies) Mimba  ilitunga    nje ya  kizazi   ")]
        public EB20 Q105 { get; set; }

        [Display(Name = "No of times")]
        [Range(1, 30, ErrorMessage = "No of times?")]
        public uint? Q105_1 { get; set; }

        [Display(Name = "Q106. Have  you ever given birth to a child who was born alive but later died before  the age of one year? Umewahi  kujaliwa  kupata  mtoto   hai, lakini  akafariki    kabla  ya  kufikia  umri wa  mwaka    mmoja ?i  ")]
        public EB20 Q106 { get; set; }

        [Display(Name = "Q107. Where  did you deliver  your last baby?    Je  ulimzalia    wapi   mtoto   wako   wa  mwisho?")]
        public EB107 Q107 { get; set; }

        [Display(Name = "(Q107b). lf at home, why?  Kwa  nini  ulijifungulia nyumbani")]
        public string Q107b { get; set; }

        [Display(Name = "Q108. Do all your children  have the same father Je  watoto   wako   wote   wana   baba   mmoja ?")]
        public EB20 Q108 { get; set; }

        //Q109. Have  you ever practised  any family planning  method  in your lifetime?  
        //Je  umeshawahi     kutumia njia  yoyote   ya  uzazi   wa  majira/mpango?
        [Display(Name = "O. No  Hapana")]
        public bool Q109_0 { get; set; }

        [Display(Name = "1. Pills Vidonge")]
        public bool Q109_1 { get; set; }

        [Display(Name = "2. lnjection    Sindano")]
        public bool Q109_2 { get; set; }

        [Display(Name = "3. IUD Kitanzi")]
        public bool Q109_3 { get; set; }

        [Display(Name = "4. Condoms     Kondomu")]
        public bool Q109_4 { get; set; }

        [Display(Name = "5. 0thers")]
        public bool Q109_5 { get; set; }

        [Display(Name = "0thers")]
        public string Q109_6 { get; set; }
        //Concerning    the  current    pregnancy       Katika  ujauzito  huu


        [Display(Name = "Q110. Have  you received  haematenics   umeshawahi     kupewa    vidonge    vya  chuma   vya  kuongeza     damu")]
        public EB20 Q110 { get; set; }

        [Display(Name = "Q111. Have  you received  prophylactic   antimalarials    umeshawahi     kupewa    dawa  za  kukinga    malaria?_")]
        public EB20 Q111 { get; set; }

        [Display(Name = "Q112. Have  you been treated  for malaria?   Umeshatibiwa      kwa  ajili  ya  malaria?")]
        public EB20 Q112 { get; set; }

        [Display(Name = "113 .Are you abstaining  from sex now that you are pregnant?   Je  umeacha    kukutana    kimwili    na  mwenzi wako   kwa  sasa   kwa  ajili  ya  ujauzito ? ")]
        public EB20 Q113 { get; set; }

        [Display(Name = "(113b). If yes,   why?   Kama   ndiyo   kwa  nini?")]
        public string Q113b { get; set; }

        //COUPLE COMMUNICATION MAJADILIANO KATI YA WATU WANAOISHI PAMOJA

        //114.Have you ever discussed  with your partner about matters relating[0 
        //Je  umeshawahi     kujadiliano na  mume / mwenzi      wako   kuhusu    mambo   yafuatayo?

        [Display(Name = "1. Condom use Kuhusu kutumia kondomu")]
        public EB20 Q114_1 { get; set; }

        [Display(Name = "2. Contraceptives/family    planning    Uzazi  wa  mpango")]
        public EB20 Q114_2 { get; set; }

        [Display(Name = "3. Sexual  satisfaction/sexuality Kukuridhisha  kimapenzi")]
        public EB20 Q114_3 { get; set; }

        [Display(Name = "4. About  HIV   Kuhusu    ukimwi")]
        public EB20 Q114_4 { get; set; }

        [Display(Name = "5. About  STDs Kuhusu  magonjwa ya  zinaa")]
        public EB20 Q114_5 { get; set; }

        //Q1I5. Currently,   can you discuss  the following  issues with your partner 
        //Je kwa sasa  unaweza kujadiliana   na mwenzako  kuhusu  mada zifuatazo?


        [Display(Name = "1. Condom   use   Kuhusu  kutumia  kondomu")]
        public EB20 Q115_1{ get; set; }

        [Display(Name = "2. Contraceptives/family    planning   Uzazi wa mpango")]
        public EB20 Q115_2 { get; set; }

        [Display(Name = "3. Desired  number  of children   N amba ya  watoto  unaowataka")]
        public EB20 Q115_3 { get; set; }

        [Display(Name = "4. Sexual  satisfaction!  sexuality   Kukuridhisha   kimapenzi")]
        public EB20 Q115_4 { get; set; }

        [Display(Name = "5. When  you feel/do  not feel like having  sex  wakati  unjisikia  au hujisikii  kufanya  mapenzi")]
        public EB20 Q115_5 { get; set; }

        [Display(Name = "6. About  STDs    Kuhusu  magonjwa  ya zinaa")]
        public EB20 Q115_6 { get; set; }

        [Display(Name = "7. About  HIV   Kuhusu  ukimwi")]
        public EB20 Q115_7 { get; set; }

        [Display(Name = "Q116. 1f STI(s)  is/are diagnosed  would you inform your partner     Tukikupima  na kukuta  una ugonjwa  wa zinaa  ambao  mwenza  lazima  atibiwe, je  unaweza  kumwambia   mwenzi  wako?")]
        public EB20 Q116 { get; set; }

        [Display(Name = "Q117. If not,  can you give reasons  why you would not inform him?   Kama  hapana,  unaweza  ukanieleza ni kwasababu gani")]
        public EB20 Q117 { get; set; }

        [Display(Name = "Q118. In  your opinion  what  is the best way of informing  your partner  to seek treatment  if you are diagnosed  as having  STD?    Kwa  ushauri  wako  unadhani  tutumie  njia gani kumjulisha   mwenzi wako  kuja  kupata  huduma  kama  tukikuta  na ugonjwa  wa zinaa?")]
        public EB118 Q118{ get; set; }

        [Display(Name = "Other/Nyinginezo")]
        public string Q118_1 { get; set; }

        [Display(Name = "Q119. If we   found you are HIV-1   positive,  who will you want to inform/discuss   the results  with?   Je tukikupima   na kukuta  na UKlMWI,  ungependa  kushirikiana   majibu yako  na nani? ")]
        public EB119 Q119 { get; set; }

        [Display(Name = "Q120. lf the   partner  is not among  them, will she be able to inform her partner?    Kama  mume/mwenzi hakutajwa,  je  tukikupima  na kukuta  na ukimwi  utaweza  kumwambia/   kumjulisha?")]
        public EB20 Q120 { get; set; }

        //Q120b).Ifno,   why would you not inform him?   (multiple  responses)    Kama  hapana,  kwanini?
         

        [Display(Name = "1. Fear  of being blamed  for bringing  the infection  home   Naogopa   atanilaumu   ni mimi nimeleta  ugonjwa  katika  ndoa")]
        public bool Q120b_1 { get; set; }

        [Display(Name = "2. Fear  of violence  (verbal/phyisical   abuse)   Naogopa  anaweza  akanipiga  au kunitukana")]
        public bool Q120b_2 { get; set; }

        [Display(Name = "3. Fear  of being  divorced    Naogopa   ataniaeha")]
        public bool Q120b_3 { get; set; }

        [Display(Name = "4. Fear  that he will tell his relatives   Naogopa  atawaambia   ndugu  zake")]
        public bool Q120b_4 { get; set; }
                
        [Display(Name = "5. 0thers")]
        public bool Q120b_5 { get; set; }

        [Display(Name = "0thers")]
        public string Q120b_6 { get; set; }

        [Display(Name = "(Q120c. )Ifno,   how will you approach  the question  of sex with him?   Kama  hutamjulisha   itakuwaje  kuhusu suala  la kukutana  kimwili? ")]
        public string Q120c { get; set; }

        //END OF QUESTIONNAIRE MWISHO WA MASWALI

        //THANK YOU FOR ANSWERING THESE QUESTIONS ASANTE KWA  KUJIBU MASWALI

        //PHYSICAL EXAMINATION
        [Display(Name = "1. Weight(kg)")]
        [Range(10, 120, ErrorMessage = "Weight!")]
        public uint? PE1 { get; set; }

        [Display(Name = "2. Height(cm)")]
        [Range(10, 60, ErrorMessage = "Height!")]
        public uint? PE2 { get; set; }

        [Display(Name = "3. BMI")]
        [Range(10, 60, ErrorMessage = "BMI!")]
        public uint? PE3 { get; set; }

        [Display(Name = "4. Blood  pressure")]
        public string PE4 { get; set; }

        [Display(Name = "5.Temperature ")]
        public uint? PE5 { get; set; }

        //6.General  appearance  
        
        [Display(Name = "1. Looks  well ")]
        public bool PE6_1 { get; set; }

        [Display(Name = "2. Looks sick")]
        public bool PE6_2 { get; set; }

        [Display(Name = "3. Pale eonjuctivalmucosa")]
        public bool PE6_3 { get; set; }

        //[Display(Name = "6. Nutrition  status")]
        //public EPE6 PE6 { get; set; }

        //[Display(Name = "7 . Lymphadenopathy (neck, axilla)")]

        //public EB20 PE7 { get; set; }

        //7.Lymphadenopathy (neck, axilla)  

        [Display(Name = "0. No")]
        public bool PE7_1 { get; set; }

        [Display(Name = "1. Yes")]
        public bool PE7_2 { get; set; }

       

        //[Display(Name = "8. Oedema")]
        //public EB20 PE8 { get; set; }

        //8. Oedema  

        [Display(Name = "0. No")]
        public bool PE8_1 { get; set; }

        [Display(Name = "1. Yes")]
        public bool PE8_2 { get; set; }

        //9. Skin
        [Display(Name = "1. Normal")]
        public bool PE9_1 { get; set; }

        [Display(Name = "2. Rashes")]
        public bool PE9_2 { get; set; }

        [Display(Name = "3. Ulcers")]
        public bool PE9_3 { get; set; }

        //10. Eyes/ ENT
        [Display(Name = "1. Normal")]
        public bool PE10_1 { get; set; }

        [Display(Name = "2. Eye discharge")]
        public bool PE10_2 { get; set; }

        [Display(Name = "3. Ear discharge")]
        public bool PE10_3 { get; set; }

        //11. Throat    
        [Display(Name = "1. Normal")]
        public bool PE11_1 { get; set; }

        [Display(Name = "2. Inflamed")]
        public bool PE11_2 { get; set; }

        [Display(Name = "3. Tonsilar enlargement")]
        public bool PE11_3 { get; set; }

        //12.Breasts
        [Display(Name = "1. Normal")]
        public bool PE12_1 { get; set; }

        [Display(Name = "2. Abscess")]
        public bool PE12_2 { get; set; }

        [Display(Name = "3. Ulcers/cracks")]
        public bool PE12_3 { get; set; }

        [Display(Name = "4. Lumps")]
        public bool PE12_4 { get; set; }

        //13. Gastrointestinal
        [Display(Name = "1. Normal")]
        public bool PE13_1 { get; set; }

        [Display(Name = "2. Oral thrush")]
        public bool PE13_2 { get; set; }

        [Display(Name = "3. Jaundice")]
        public bool PE13_3 { get; set; }

        [Display(Name = "4. Enlarged spleen")]
        public bool PE13_4 { get; set; }

        [Display(Name = "5. Enlarged liver")]
        public bool PE13_5 { get; set; }

        //14. Respiratory

        [Display(Name = "1. Normal")]
        public bool PE14_1 { get; set; }

        [Display(Name = "2. Cyanosed")]
        public bool PE14_2 { get; set; }

        [Display(Name = "3. Respiratory wheeze")]
        public bool PE14_3 { get; set; }

        [Display(Name = "4. Air entry good")]
        public bool PE14_4 { get; set; }

        [Display(Name = "5. Air entry poor")]
        public bool PE14_5 { get; set; }


        //15. Genitalia

        [Display(Name = "0. Not  circumcised")]
        public bool PE15_0 { get; set; }

        [Display(Name = "1. Partial clitoridectomy")]
        public bool PE15_1 { get; set; }

        [Display(Name = "2. Total clitoridectomy")]
        public bool PE15_2 { get; set; }

        [Display(Name = "3. Clitoridectomy+excised + labia minora")]
        public bool PE15_3 { get; set; }

        [Display(Name = "4. lnfibulation")]
        public bool PE15_4 { get; set; }


        //16. Vulva  
        [Display(Name = "1. normal")]
        public bool PE16_1 { get; set; }

        [Display(Name = "2. Ulcers(single/multiple)")]
        public bool PE16_2 { get; set; }

        [Display(Name = "3. Warts")]
        public bool PE16_3 { get; set; }

        //17. Vagina             

        [Display(Name = "0. normal")]
        public bool PE17_0 { get; set; }

        [Display(Name = "1. Yellow discharge")]
        public bool PE17_1 { get; set; }

        [Display(Name = "2. Thick white discharge")]
        public bool PE17_2 { get; set; }

        [Display(Name = "3. Greyish discharge")]
        public bool PE17_3 { get; set; }

        [Display(Name = "4. Warts")]
        public bool PE17_4 { get; set; }



        //18. Cervix             

        [Display(Name = "1. Normal cervix")]
        public bool PE18_1 { get; set; }

        [Display(Name = "2. Cervical discharge (swab test)")]
        public bool PE18_2 { get; set; }

        [Display(Name = "3. Cervical ectopy")]
        public bool PE18_3 { get; set; }

        [Display(Name = "4. Ulcer")]
        public bool PE18_4 { get; set; }

        [Display(Name = "5. Easily induced bleeding")]
        public bool PE18_5 { get; set; }

        [Display(Name = "6. Cervical cancer")]
        public bool PE18_6 { get; set; }




        //19. Bi-manual  palpation
        [Display(Name = "1. Normal")]
        public bool PE19_1 { get; set; }

        [Display(Name = "2. Adnexa.tenderness")]
        public bool PE19_2 { get; set; }

        [Display(Name = "3. Adnexa mass")]
        public bool PE19_3 { get; set; }

        [Display(Name = "4. Cervical excitation positive")]
        public bool PE19_4 { get; set; }



        //20. PH 
        [Display(Name = "1. <= 4.5")]
        public bool PE20_1 { get; set; }

        [Display(Name = "2. >= 4.5")]
        public bool PE20_2 { get; set; }



        //21. Whiff test  
        [Display(Name = "1. Negative")]
        public bool PE21_1 { get; set; }

        [Display(Name = "2. Positive")]
        public bool PE21_2 { get; set; }


    }

    public enum EB6
        {
            [Display(Name = "1. Farming   Mkulima")]
            E1 = 1,
            [Display(Name = "2. Small  business  -vending   Biashara  ndogo  ndogo")]
            E2 = 2,
            [Display(Name = "3. Dress  making  Kushona")]
            E3 = 3,
            [Display(Name = "4. 0ther   Nyinginezo")]
            E4 = 4

        }
        public enum EB8
        {
            [Display(Name = "1. < 30,000  Tanzanian  shs")]
            E1 = 1,
            [Display(Name = "2. 30,000-59,000   Tanzanian  shs")]
            E2 = 2,
            [Display(Name = "3. 60,000-100,000    Tanzanian  shs")]
            E3 = 3,
            [Display(Name = "4. > 100,000  Tanzanian  shs")]
            E4 = 4

        }

        public enum EB9
        {
            [Display(Name = "O. No formal  education  Sikuwahi  kusoma")]
            E0 = 0,
            [Display(Name = "1. 1-7 (Primary  level) Darasa  fa 1-  7")]
            E1 = 1,
            [Display(Name = "2. 9 -12 (0  level) Kidato  1-4")]
            E2 = 2,
            [Display(Name = "3. 13-14  CA'  level) Kidato  cha 5-6")]
            E3 = 3,
            [Display(Name = "4. Higher  institutions  (Degree,  advanced  diploma)  Elimuyajuu")]
            E4 = 4

        }
        public enum EB12
        {
            [Display(Name = "O.No toilet Hapana")]
            E0 = 0,
            [Display(Name = "I. ln the house Kiko ndani ya nyumba")]
            E1 = 1,
            [Display(Name = "2.0utside   Kiko nje")]
            E2 = 2
        }
        public enum EB13
        {
            [Display(Name = "O. No Hapana  tunatumia  wenyewe")]
            E0 = 0,
            [Display(Name = "1. Yes Ndio tunashirkiana")]
            E1 = 1
        }
        public enum EB14
        {
            [Display(Name = "1.Tap inside the house Toka kwenye  bomba  ndani ya nyumba")]
            E1 = 1,
            [Display(Name = "2. Tap  outside Toka kwenye  bomba  nje ya  nyumba")]
            E2 = 2,
            [Display(Name = "3. Common  supply Bomba  lajumuiyalkijiji")]
            E3 = 3,
            [Display(Name = "4.Well Toka kisimani")]
            E4 = 4

        }
        public enum EB15
        {
            [Display(Name = "1. Electric   stove Jiko  la umeme")]
            E1 = 1,
            [Display(Name = "2. Kerosine  (Paraffin) Jiko  la mafuta ya  taa")]
            E2 = 2,
            [Display(Name = "3. Fire  Wood Kuni")]
            E3 = 3,
            [Display(Name = "4. Charcoal Mkaa")]
            E4 = 4

        }
        public enum EB17
        {
            [Display(Name = "O. No Hapana")]
            E0 = 0,
            [Display(Name = "1. Occasionally Mara  chache")]
            E1 = 1,
            [Display(Name = "2. Several  times  a month Mara  nyingi  kila mwezi  (times / month")]
            E2 = 2

        }
        public enum EB18
        {
            [Display(Name = "1. Married  Nimeolewa")]
            E1 = 1,
            [Display(Name = "2. Cohabiting Tunaishi pamoja  bila ndoa")]
            E2 = 2,
            [Display(Name = "3. Single Sijaolewa")]
            E3 = 3,
            [Display(Name = "4. Divorced  Mtalaka  (kwa miaka")]
            E4 = 4,
            [Display(Name = "5. Separated   Tumetengana (kwa miaka ")]
            E5 = 5,
            [Display(Name = "6.Widowed  Mjane (kwa miaka")]
            E6 = 6
        }
        public enum EB20
        {
            [Display(Name = "O. No Hapana")]
            E0 = 0,
            [Display(Name = "1. Yes Ndio")]
            E1 = 1
        }
        public enum EB22
        {
            [Display(Name = "O. No Hapana")]
            E0 = 0,
            [Display(Name = "1. Yes Ndio")]
            E1 = 1,
            [Display(Name = "2. Don't know Sijui")]
            E2 = 2
        }
        public enum EB23
        {
            [Display(Name = "1. Together   all the time Pamoja  wakati  wote")]
            E1 = 1,
            [Display(Name = "2. Visits times/week) Ananitembelea (mara kwa wiki)")]
            E2 = 2,
            [Display(Name = "3. Separate  6 months  per year Tunaishi  mbali mbali  kwa zaidi ya  miezi sita")]
            E3 = 3,
            [Display(Name = "4. 0ther   Nyinginezo")]
            E4 = 4

        }

        public enum EB28b
        {
            [Display(Name = "1. Every  day   Kila siku")]
            E1 = 1,
            [Display(Name = "2. 0nce a week  Mara moja kwa wiki")]
            E2 = 2,
            [Display(Name = "3. 0ccasionally  Mara moja moja/ mara  chache")]
            E3 = 3
        }
        public enum EB28c
        {
            [Display(Name = "O. Norie Hapana")]
            E0 = 0,
            [Display(Name = "1. Cigarattes Sigara")]
            E1 = 2,
            [Display(Name = "2. Marihuana Bhangi")]
            E2 = 2,
            [Display(Name = "3. Khat Mirungi")]
            E3 = 3
        }

        public enum EB30
        {
            [Display(Name = "O. No formal  education Hakuwahi  kusoma")]
            E0 = 0,
            [Display(Name = "1. 1-7 (Primary  level) Darasa  la 1 - 7")]
            E1 = 2,
            [Display(Name = "2. 9-I2 (Olevel)  Kidato")]
            E2 = 2,
            [Display(Name = "3. 13-14 ('A'level)  Kidato  cha 5-6")]
            E3 = 3,
            [Display(Name = "4. Higher institutions  (Degree,  advanced  diploma) Elimu ya juu")]
            E4 = 4
        }

        public enum EB31
        {
            [Display(Name = "1. Uniformed  job (Mwanajeshi,   Polisi)")]
            E1 = 1,
            [Display(Name = "2. White  collar job (Nesi, Mwalimu,  Daktari,  Mhasibu)")]
            E2 = 2,
            [Display(Name = "3. Blue  collar job (Messanger,  Msafishaji.,  Security  guard,  Mgambo)")]
            E3 = 3,
            [Display(Name = "4.Technical  job (Fundi  wa umeme,  magari,  kujenga,  kushona  etc)")]
            E4 = 4,
            [Display(Name = "5. Driver Dereva  wa malori yaendayo   mikoa  mingine    I dereva  wa magari ya  hapa mjini")]
            E5 = 5,
            [Display(Name = "6. Businessman Mfanyabiashara")]
            E6 = 6,
            [Display(Name = "7. Mkillima Mkulima")]
            E7 = 7,
            [Display(Name = "8. 0ther   Nyingine")]
            E8 = 8
        }

        public enum EB34
        {
            [Display(Name = "O. No   Hapana")]
            E0 = 0,
            [Display(Name = "1. Every  day Kila siku")]
            E1 = 2,
            [Display(Name = "2. 0nce   a week Mara moja kwa wiki")]
            E2 = 2,
            [Display(Name = "3. 0ccasionally Mara moja moja")]
            E3 = 3
        }
        public enum EB39
        {
            [Display(Name = "O. No Hapana")]
            E0 = 0,
            [Display(Name = "1. Yes,  all the times Ndiyo,wakati wote")]
            E1 = 1,
            [Display(Name = "2. Yes, sometimes Ndiyo, mara nyinginehatakuwa  na dalili")]
            E2 = 2,
            [Display(Name = "3. Don't know Sijui")]
            E3 = 3
        }

        public enum EB42
        {
            [Display(Name = "1. Always  shows signs Hapana, lazima  aonyeshe  dalili")]
            E1 = 1,
            [Display(Name = "2. Can  look healthy Ndiyo,  anaweza  asiwe na dalili")]
            E2 = 2,            
            [Display(Name = "3. Don't know Sijui")]
            E3 = 3
        }

        public enum EB44b
        {
            [Display(Name = "1. Pregnancy  Wakati wa ujauzito")]
            E1 = 1,
            [Display(Name = "2. Delivery  Wakati wa kujifungua")]
            E2 = 2,
            [Display(Name = "3. Breast-feeding  period Wakati anapomyonyesha mtoto")]
            E3 = 3
        }

        public enum EB45
        {
            [Display(Name = "1. No risk Hapana, sina hatari")]
            E1 = 1,
            [Display(Name = "2. Small  risk Ndiyo,  hatari kidogo")]
            E2 = 2,
            [Display(Name = "3. Moderate risk Ndiyo,hatari kiasi")]
            E3 = 3,
            [Display(Name = "4. High  risk Ndiyo  niko kwenye hatari sana")]
            E4 = 4,
            [Display(Name = "5. Don't know Sijui")]
            E5 = 5
        }
        public enum EB49
        {
            [Display(Name = "1. Entitled to keep a secret  Iwe ni siri yao")]
            E1 = 1,
            [Display(Name = "2. Should be revealed Hali hiyo  iwe wazi kwa wanajumuiya wote")]
            E2 = 2,
            [Display(Name = "3. Don't know Sijui")]
            E3 = 3
        }

        public enum EB54
        {
            [Display(Name = "1. Once Mara moja")]
            E1 = 1,
            [Display(Name = "2. Twice Mara  mbili")]
            E2 = 2,
            [Display(Name = "3. Three  or more times Mara tatu na zaidi")]
            E3 = 3
        }

        public enum EB55
        {
            [Display(Name = "1. Plain  water  Maji matupu")]
            E1 = 1,
            [Display(Name = "2. Soap Maji yenye  sabuni")]
            E2 = 2,
            [Display(Name = "3. Detergent  (e.g.  Dettol) Dawa  kama  dettol")]
            E3 = 3,
            [Display(Name = "4. Others Nyinginezo")]
            E4 = 4
        }

        public enum EB56
        {
            [Display(Name = "1. Fingers Vidole")]
            E1 = 1,
            [Display(Name = "2. Cloth Kitambaa")]
            E2 = 2,
            [Display(Name = "3. Paper Karatasi  kama (toilet paper)")]
            E3 = 3,
            [Display(Name = "4. 0thers")]
            E4 = 4
        }

        public enum EB90
        {
            [Display(Name = "1. One  Mmoja tu")]
            E1 = 1,
            [Display(Name = "2. Two   Wawili")]
            E2 = 2,
            [Display(Name = "3. Three Watatu")]
            E3 = 3,
            [Display(Name = "4. More Zaidi")]
            E4 = 4
        }

        public enum EB95
        {
            [Display(Name = "1. Always Kila unapokutana kimwili")]
            E1 = 1,
            [Display(Name = "2. My  partner Mwenzi/mume wangu")]
            E2 = 2,
            [Display(Name = "3. Any  of us  Yeyote  katiyetu")]
            E3 = 3
        }

        public enum EB96
        {
            [Display(Name = "1. Myself Mimi")]
            E1 = 1,
            [Display(Name = "2. Most  of the times  Mara   kwa  mara")]
            E2 = 2,
            [Display(Name = "3. 0ccasionally  Mara   chache chache")]
            E3 = 3
        }

        public enum EB107
        {
            [Display(Name = "O. Not applicable")]
            E0 = 0,
            [Display(Name = "1.Hospital    hospitali")]
            E1 = 1,
            [Display(Name = "2. Home   nyumbani")]
            E2 = 2
        }

        public enum EB118
        {
            [Display(Name = "1. Infonning   him yourself    Kumjulisha  wewe  mwenyewe")]
            E1 = 1,
            [Display(Name = "2. Infonned   by a healthcare  worker   Ajulishwe  na mtaalamu  wa afya")]
            E2 = 2,
            [Display(Name = "3. Card  system     Upewe kadi yenye  namba  na aje nayo kituoni")]
            E3 = 3,
            [Display(Name = "4. Other  Nyinginezo")]
            E4 = 4
        }

        public enum EB119
        {
            [Display(Name = "1. Mume")]
            E1 = 1,
            [Display(Name = "2. Mwenzi")]
            E2 = 2,
            [Display(Name = "3.Baba")]
            E3 = 3,
            [Display(Name = "4. Mama")]
            E4 = 4,
            [Display(Name = "5. Other")]
            E5 = 5
        }
        
             public enum EPE5
        {
            [Display(Name = "1. Looks  well")]
            E1 = 1,
            [Display(Name = "2. Looks sick")]
            E2 = 2,
            [Display(Name = "3. Pale conjuctiva/mucosa")]
            E3 = 3
        }

        public enum EPE6
        {
            [Display(Name = "1. Good")]
            E1 = 1,
            [Display(Name = "2. Poor")]
            E2 = 2
        }

        public enum EPE9
        {
            [Display(Name = "1.Normal")]
            E1 = 1,
            [Display(Name = "2. Rashes")]
            E2 = 2,
            [Display(Name = "3. Ulcers")]
            E3 = 3
        }
    
}
