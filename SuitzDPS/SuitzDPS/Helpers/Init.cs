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

        internal static void CheckTierRogue()
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

        internal static void CheckTierPriest()
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

        internal static void CheckTierMage()
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

        internal static void CheckTierHunter()
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

        internal static void CheckTierMonk()
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
    }
}