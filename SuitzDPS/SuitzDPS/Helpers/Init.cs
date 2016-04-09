using System;
using Anthrax;
using Anthrax.WoW.Classes.ObjectManager;
using Anthrax.WoW.Internals;
using SuitzDPS.Classes;
using System.Threading;

namespace SuitzDPS.Helpers
{
    internal class Init
    {

        internal static int tier15;
        internal static int tier30;
        internal static int tier45;
        internal static int tier60;
        internal static int tier75;
        internal static int tier90;
        internal static int tier100;

        public Init()
        {
        }

        internal static void CheckTierDeathKnight()
        {

            //Check T15
            if (Rotation.CheckSpellBook(115989))
            {
                tier15 = 3;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(123693))
            {
                tier15 = 2;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(161497))
            {
                tier15 = 1;
                goto tier30;
            }

            //Check T30
            tier30:
            if (Rotation.CheckSpellBook(114556))
            {
                tier30 = 3;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(51052))
            {
                tier30 = 2;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(49039))
            {
                tier30 = 1;
                goto tier45;
            }

            //Check T45
            tier45:
            if (Rotation.CheckSpellBook(108194))
            {
                tier45 = 3;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(50041))
            {
                tier45 = 2;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(96268))
            {
                tier45 = 1;
                goto tier60;
            }

            //Check T60
            tier60:
            if (Rotation.CheckSpellBook(51462))
            {
                tier60 = 3;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(81229))
            {
                tier60 = 2;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(45529))
            {
                tier60 = 1;
                goto tier75;
            }

            //Check T75
            tier75:
            if (Rotation.CheckSpellBook(152261))
            {
                tier75 = 3;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(152262))
            {
                tier75 = 2;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(152263))
            {
                tier75 = 1;
                goto tier90;
            }

            //Check T90
            tier90:
            if (Rotation.CheckSpellBook(108201))
            {
                tier90 = 3;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(108200))
            {
                tier90 = 2;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(108199))
            {
                tier90 = 1;
                goto tier100;
            }

            //Check T100
            tier100:
            if (Rotation.CheckSpellBook(152279))
            {
                tier100 = 3;
                goto end;
            }
            if (Rotation.CheckSpellBook(152280))
            {
                tier100 = 2;
                goto end;
            }
            if (Rotation.CheckSpellBook(152281))
            {
                tier100 = 1;
            }
            end:
            return;
        }

        internal static void CheckTierDruid()
        {

            //Check T15
            if (Rotation.CheckSpellBook(115989))
            {
                tier15 = 3;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(123693))
            {
                tier15 = 2;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(161497))
            {
                tier15 = 1;
                goto tier30;
            }

            //Check T30
            tier30:
            if (Rotation.CheckSpellBook(114556))
            {
                tier30 = 3;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(51052))
            {
                tier30 = 2;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(49039))
            {
                tier30 = 1;
                goto tier45;
            }

            //Check T45
            tier45:
            if (Rotation.CheckSpellBook(108194))
            {
                tier45 = 3;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(50041))
            {
                tier45 = 2;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(96268))
            {
                tier45 = 1;
                goto tier60;
            }

            //Check T60
            tier60:
            if (Rotation.CheckSpellBook(51462))
            {
                tier60 = 3;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(81229))
            {
                tier60 = 2;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(45529))
            {
                tier60 = 1;
                goto tier75;
            }

            //Check T75
            tier75:
            if (Rotation.CheckSpellBook(152261))
            {
                tier75 = 3;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(152262))
            {
                tier75 = 2;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(152263))
            {
                tier75 = 1;
                goto tier90;
            }

            //Check T90
            tier90:
            if (Rotation.CheckSpellBook(108201))
            {
                tier90 = 3;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(108200))
            {
                tier90 = 2;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(108199))
            {
                tier90 = 1;
                goto tier100;
            }

            //Check T100
            tier100:
            if (Rotation.CheckSpellBook(152279))
            {
                tier100 = 3;
                goto end;
            }
            if (Rotation.CheckSpellBook(152280))
            {
                tier100 = 2;
                goto end;
            }
            if (Rotation.CheckSpellBook(152281))
            {
                tier100 = 1;
            }
            end:
            return;
        }

        internal static void CheckTierShaman()
        {

            //Check T15
            if (Rotation.CheckSpellBook(108271))
            {
                tier15 = 3;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(108270))
            {
                tier15 = 2;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(30884))
            {
                tier15 = 1;
                goto tier30;
            }

        //Check T30
        tier30:
            if (Rotation.CheckSpellBook(108273))
            {
                tier30 = 3;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(51485))
            {
                tier30 = 2;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(63374))
            {
                tier30 = 1;
                goto tier45;
            }

        //Check T45
        tier45:
            if (Rotation.CheckSpellBook(108287))
            {
                tier45 = 3;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(108284))
            {
                tier45 = 2;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(108285))
            {
                tier45 = 1;
                goto tier60;
            }

        //Check T60
        tier60:
            if (Rotation.CheckSpellBook(108283))
            {
                tier60 = 3;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(16188))
            {
                tier60 = 2;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(16166))
            {
                tier60 = 1;
                goto tier75;
            }

        //Check T75
        tier75:
            if (Rotation.CheckSpellBook(108282))
            {
                tier75 = 3;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(108281))
            {
                tier75 = 2;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(147074))
            {
                tier75 = 1;
                goto tier90;
            }

        //Check T90
        tier90:
            if (Rotation.CheckSpellBook(117014))
            {
                tier90 = 3;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(117013))
            {
                tier90 = 2;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(117012))
            {
                tier90 = 1;
                goto tier100;
            }

        //Check T100
        tier100:
            if (Rotation.CheckSpellBook(152255))
            {
                tier100 = 3;
                goto end;
            }
            if (Rotation.CheckSpellBook(152256))
            {
                tier100 = 2;
                goto end;
            }
            if (Rotation.CheckSpellBook(152257))
            {
                tier100 = 1;
            }
        end:
            return;
        }

        internal static void CheckTierWarrior()
        {

            //Check T15
            if (Rotation.CheckSpellBook(103828))
            {
                tier15 = 3;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(103827))
            {
                tier15 = 2;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(103826))
            {
                tier15 = 1;
                goto tier30;
            }

        //Check T30
        tier30:
            if (Rotation.CheckSpellBook(103840))
            {
                tier30 = 3;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(29838))
            {
                tier30 = 2;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(55694))
            {
                tier30 = 1;
                goto tier45;
            }

        //Check T45
        tier45:
            if (Rotation.CheckSpellBook(1464))
            {
                tier45 = 3;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(29725))
            {
                tier45 = 2;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(56636))
            {
                tier45 = 1;
                goto tier60;
            }

        //Check T60
        tier60:
            if (Rotation.CheckSpellBook(118000))
            {
                tier60 = 3;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(46968))
            {
                tier60 = 2;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(107570))
            {
                tier60 = 1;
                goto tier75;
            }

        //Check T75
        tier75:
            if (Rotation.CheckSpellBook(114030))
            {
                tier75 = 3;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(114029))
            {
                tier75 = 2;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(114028))
            {
                tier75 = 1;
                goto tier90;
            }

        //Check T90
        tier90:
            if (Rotation.CheckSpellBook(46924))
            {
                tier90 = 3;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(12292))
            {
                tier90 = 2;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(107574))
            {
                tier90 = 1;
                goto tier100;
            }

        //Check T100
        tier100:
            if (Rotation.CheckSpellBook(176289))
            {
                tier100 = 3;
                goto end;
            }
            if (Rotation.CheckSpellBook(152277))
            {
                tier100 = 2;
                goto end;
            }
            if (Rotation.CheckSpellBook(152278))
            {
                tier100 = 1;
            }
        end:
            return;
        }

        internal static void CheckTierRogue()
        {

            //Check T15
            if (Rotation.CheckSpellBook(108209))
            {
                tier15 = 3;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(108208))
            {
                tier15 = 2;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(14062))
            {
                tier15 = 1;
                goto tier30;
            }

        //Check T30
        tier30:
            if (Rotation.CheckSpellBook(74001))
            {
                tier30 = 3;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(108210))
            {
                tier30 = 2;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(26679))
            {
                tier30 = 1;
                goto tier45;
            }

        //Check T45
        tier45:
            if (Rotation.CheckSpellBook(79008))
            {
                tier45 = 3;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(108211))
            {
                tier45 = 2;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(31230))
            {
                tier45 = 1;
                goto tier60;
            }

        //Check T60
        tier60:
            if (Rotation.CheckSpellBook(108212))
            {
                tier60 = 3;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(36554))
            {
                tier60 = 2;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(138106))
            {
                tier60 = 1;
                goto tier75;
            }

        //Check T75
        tier75:
            if (Rotation.CheckSpellBook(108216))
            {
                tier75 = 3;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(154904))
            {
                tier75 = 2;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(131511))
            {
                tier75 = 1;
                goto tier90;
            }

        //Check T90
        tier90:
            if (Rotation.CheckSpellBook(114015))
            {
                tier90 = 3;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(137619))
            {
                tier90 = 2;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(114014))
            {
                tier90 = 1;
                goto tier100;
            }

        //Check T100
        tier100:
            if (Rotation.CheckSpellBook(152150))
            {
                tier100 = 3;
                goto end;
            }
            if (Rotation.CheckSpellBook(152151))
            {
                tier100 = 2;
                goto end;
            }
            if (Rotation.CheckSpellBook(152152))
            {
                tier100 = 1;
            }
        end:
            return;
        }

        internal static void CheckTierPriest()
        {

            //Check T15
            if (Rotation.CheckSpellBook(108945))
            {
                tier15 = 3;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(112833))
            {
                tier15 = 2;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(19236))
            {
                tier15 = 1;
                goto tier30;
            }

        //Check T30
        tier30:
            if (Rotation.CheckSpellBook(108942))
            {
                tier30 = 3;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(121536))
            {
                tier30 = 2;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(64129))
            {
                tier30 = 1;
                goto tier45;
            }

        //Check T45
        tier45:
            if (Rotation.CheckSpellBook(129250))
            {
                tier45 = 3;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(123040))
            {
                tier45 = 2;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(109186))
            {
                tier45 = 1;
                goto tier60;
            }

        //Check T60
        tier60:
            if (Rotation.CheckSpellBook(605))
            {
                tier60 = 3;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(8122))
            {
                tier60 = 2;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(108920))
            {
                tier60 = 1;
                goto tier75;
            }

        //Check T75
        tier75:
            if (Rotation.CheckSpellBook(109964))
            {
                tier75 = 3;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(10060))
            {
                tier75 = 2;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(109142))
            {
                tier75 = 1;
                goto tier90;
            }

        //Check T90
        tier90:
            if (Rotation.CheckSpellBook(120517))
            {
                tier90 = 3;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(110744))
            {
                tier90 = 2;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(121135))
            {
                tier90 = 1;
                goto tier100;
            }

        //Check T100
        tier100:
            if (Rotation.CheckSpellBook(152116))
            {
                tier100 = 3;
                goto end;
            }
            if (Rotation.CheckSpellBook(152117))
            {
                tier100 = 2;
                goto end;
            }
            if (Rotation.CheckSpellBook(152118))
            {
                tier100 = 1;
            }
        end:
            return;
        }

        internal static void CheckTierMage()
        {

            //Check T15
            if (Rotation.CheckSpellBook(108839))
            {
                tier15 = 3;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(108843))
            {
                tier15 = 2;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(157913))
            {
                tier15 = 1;
                goto tier30;
            }

        //Check T30
        tier30:
            if (Rotation.CheckSpellBook(11426))
            {
                tier30 = 3;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(140468))
            {
                tier30 = 2;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(108978))
            {
                tier30 = 1;
                goto tier45;
            }

        //Check T45
        tier45:
            if (Rotation.CheckSpellBook(102051))
            {
                tier45 = 3;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(111264))
            {
                tier45 = 2;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(113724))
            {
                tier45 = 1;
                goto tier60;
            }

        //Check T60
        tier60:
            if (Rotation.CheckSpellBook(11958))
            {
                tier60 = 3;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(86949))
            {
                tier60 = 2;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(110959))
            {
                tier60 = 1;
                goto tier75;
            }

        //Check T75
        tier75:
            if (Rotation.CheckSpellBook(157980))
            {
                tier75 = 3;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(157976))
            {
                tier75 = 2;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(114923))
            {
                tier75 = 1;
                goto tier90;
            }

        //Check T90
        tier90:
            if (Rotation.CheckSpellBook(1463))
            {
                tier90 = 3;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(116011))
            {
                tier90 = 2;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(55342))
            {
                tier90 = 1;
                goto tier100;
            }

        //Check T100
        tier100:
            if (Rotation.CheckSpellBook(153626))
            {
                tier100 = 3;
                goto end;
            }
            if (Rotation.CheckSpellBook(152087))
            {
                tier100 = 2;
                goto end;
            }
            if (Rotation.CheckSpellBook(155147))
            {
                tier100 = 1;
            }
        end:
            return;
        }

        internal static void CheckTierHunter()
        {

            //Check T15
            if (Rotation.CheckSpellBook(118675))
            {
                tier15 = 3;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(109298))
            {
                tier15 = 2;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(109215))
            {
                tier15 = 1;
                goto tier30;
            }

        //Check T30
        tier30:
            if (Rotation.CheckSpellBook(19577))
            {
                tier30 = 3;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(19386))
            {
                tier30 = 2;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(109248))
            {
                tier30 = 1;
                goto tier45;
            }

        //Check T45
        tier45:
            if (Rotation.CheckSpellBook(109212))
            {
                tier45 = 3;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(109260))
            {
                tier45 = 2;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(109304))
            {
                tier45 = 1;
                goto tier60;
            }

        //Check T60
        tier60:
            if (Rotation.CheckSpellBook(109306))
            {
                tier60 = 3;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(120679))
            {
                tier60 = 2;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(177667))
            {
                tier60 = 1;
                goto tier75;
            }

        //Check T75
        tier75:
            if (Rotation.CheckSpellBook(121818))
            {
                tier75 = 3;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(130392))
            {
                tier75 = 2;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(131894))
            {
                tier75 = 1;
                goto tier90;
            }

        //Check T90
        tier90:
            if (Rotation.CheckSpellBook(120360))
            {
                tier90 = 3;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(109259))
            {
                tier90 = 2;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(117050))
            {
                tier90 = 1;
                goto tier100;
            }

        //Check T100
        tier100:
            if (Rotation.CheckSpellBook(152244))
            {
                tier100 = 3;
                goto end;
            }
            if (Rotation.CheckSpellBook(152245))
            {
                tier100 = 2;
                goto end;
            }
            if (Rotation.CheckSpellBook(162534))
            {
                tier100 = 1;
            }
        end:
            return;
        }

        internal static void CheckTierMonk()
        {

            //Check T15
            if (Rotation.CheckSpellBook(115174))
            {
                tier15 = 3;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(116841))
            {
                tier15 = 2;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(115173))
            {
                tier15 = 1;
                goto tier30;
            }

        //Check T30
        tier30:
            if (Rotation.CheckSpellBook(123986))
            {
                tier30 = 3;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(124081))
            {
                tier30 = 2;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(115098))
            {
                tier30 = 1;
                goto tier45;
            }

        //Check T45
        tier45:
            if (Rotation.CheckSpellBook(115399))
            {
                tier45 = 3;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(115396))
            {
                tier45 = 2;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(121817))
            {
                tier45 = 1;
                goto tier60;
            }

        //Check T60
        tier60:
            if (Rotation.CheckSpellBook(119381))
            {
                tier60 = 3;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(119392))
            {
                tier60 = 2;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(116844))
            {
                tier60 = 1;
                goto tier75;
            }

        //Check T75
        tier75:
            if (Rotation.CheckSpellBook(122783))
            {
                tier75 = 3;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(122278))
            {
                tier75 = 2;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(122280))
            {
                tier75 = 1;
                goto tier90;
            }

        //Check T90
        tier90:
            if (Rotation.CheckSpellBook(115008))
            {
                tier90 = 3;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(123904))
            {
                tier90 = 2;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(116847))
            {
                tier90 = 1;
                goto tier100;
            }

        //Check T100
        tier100:
            if (Rotation.CheckSpellBook(152173))
            {
                tier100 = 3;
                goto end;
            }
            if (Rotation.CheckSpellBook(157676))
            {
                tier100 = 2;
                goto end;
            }
            if (Rotation.CheckSpellBook(157533))
            {
                tier100 = 1;
            }
        end:
            return;
        }

        internal static void CheckTierWarlock()
        {

            //Check T15
            if (Rotation.CheckSpellBook(108371))
            {
                tier15 = 3;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(108370))
            {
                tier15 = 2;
                goto tier30;
            }
            if (Rotation.CheckSpellBook(108359))
            {
                tier15 = 1;
                goto tier30;
            }

        //Check T30
        tier30:
            if (Rotation.CheckSpellBook(30283))
            {
                tier30 = 3;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(6789))
            {
                tier30 = 2;
                goto tier45;
            }
            if (Rotation.CheckSpellBook(5484))
            {
                tier30 = 1;
                goto tier45;
            }

        //Check T45
        tier45:
            if (Rotation.CheckSpellBook(110913))
            {
                tier45 = 3;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(108416))
            {
                tier45 = 2;
                goto tier60;
            }
            if (Rotation.CheckSpellBook(108415))
            {
                tier45 = 1;
                goto tier60;
            }

        //Check T60
        tier60:
            if (Rotation.CheckSpellBook(108283))
            {
                tier60 = 3;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(16188))
            {
                tier60 = 2;
                goto tier75;
            }
            if (Rotation.CheckSpellBook(16166))
            {
                tier60 = 1;
                goto tier75;
            }

        //Check T75
        tier75:
            if (Rotation.CheckSpellBook(108482))
            {
                tier75 = 3;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(111400))
            {
                tier75 = 2;
                goto tier90;
            }
            if (Rotation.CheckSpellBook(111397))
            {
                tier75 = 1;
                goto tier90;
            }

        //Check T90
        tier90:
            if (Rotation.CheckSpellBook(108508))
            {
                tier90 = 3;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(137587))
            {
                tier90 = 2;
                goto tier100;
            }
            if (Rotation.CheckSpellBook(108505))
            {
                tier90 = 1;
                goto tier100;
            }

        //Check T100
        tier100:
            if (Rotation.CheckSpellBook(152107))
            {
                tier100 = 3;
                goto end;
            }
            if (Rotation.CheckSpellBook(152108))
            {
                tier100 = 2;
                goto end;
            }
            if (Rotation.CheckSpellBook(152109))
            {
                tier100 = 1;
            }
        end:
            return;
        }
    }
}