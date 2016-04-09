using System;
using System.Windows.Forms;
using System.Threading;
using Anthrax;
using Anthrax.Modules;
using Anthrax.WoW;
using Anthrax.WoW.Classes.ObjectManager;
using Anthrax.WoW.Internals;
using SuitzDPS.Classes;
using SuitzDPS.Helpers;


namespace SuitzDPS
{
    public class SuitzDPS : ISPQR
    {

        public bool LoopThread;

        public override string Name
        {
            get
            {
                return "SuitzDPS";
            }
        }

        static SuitzDPS()
        {
        }

        public SuitzDPS()
        {
        }

        internal static void DoRotation()
        {
            if (DetectKeyPress.GetKeyState(DetectKeyPress.Shift) < 0)
            {
                return;
            }
            if (DetectKeyPress.GetKeyState(DetectKeyPress.Z) < 0)
            {
                Rotation.ChangeRotation();
            }
            if (ObjectManager.LocalPlayer.IsMounted)
            {
                return;
            }



            switch (ObjectManager.LocalPlayer.Class)
            {
                case WowUnit.WowUnitClass.Paladin:
                    //Paladin.DoPaladin();
                    break;
                case WowUnit.WowUnitClass.Warrior:
                    Warrior.DoWarrior();
                    break;
                case WowUnit.WowUnitClass.Hunter:
                    Hunter.DoHunter();
                    break;
                case WowUnit.WowUnitClass.Druid:
                    Druid.DoDruid();
                    break;
                case WowUnit.WowUnitClass.Shaman:
                    Shaman.DoShaman();
                    break;
                case WowUnit.WowUnitClass.Rogue:
                    Rogue.DoRogue();
                    break;
                case WowUnit.WowUnitClass.Priest:
                    Priest.DoPriest();
                    break;
                case WowUnit.WowUnitClass.DeathKnight:
                    DeathKnight.DoDeathKnight();
                    break;
                case WowUnit.WowUnitClass.Mage:
                    Mage.DoMage();
                    break;
                case WowUnit.WowUnitClass.Warlock:
                    Warlock.DoWarlock();
                    break;
                case WowUnit.WowUnitClass.Monk:
                    Monk.DoMonk();
                    break;

            }

        }

        public override void OnBotStart()
        {
            Anthrax.WoW.Logger.WriteLine("Hello.");
        }

        public override void OnBotStop()
        {
            this.LoopThread = false;
        }

        public override void OnCombat(WowUnit unit)
        {
            SuitzDPS.DoRotation();
        }

        public override void OnLoad()
        {
            //IO.Load();
            //NPCDataTools.DatabaseLoad();
        }

        public override void OnUnload()
        {
            //IO.Save();
            //NPCDataTools.DatabaseUnload();
        }

        public override void Settings()
        {
            //(new FormSettings()).ShowDialog();
        }

        public void ThreadRotation()
        {
            this.LoopThread = true;
            while (this.LoopThread)
            {
                SuitzDPS.DoRotation();
                Thread.Sleep(100);
            }
        }

        internal enum Spells
        {
            Rend = 772,
            Exorcism = 879,
            Slam = 1464,
            Whirlwind = 1680,
            Recklessness = 1719,
            Execute = 5308,
            ThunderClap = 6343,
            Bloodbath = 12292,
            MortalStrike = 12294,
            SweepingStrikes = 12328,
            Enrage = 12880,
            BerserkerRage = 18499,
            FlashOfLight = 19750,
            SealOfRighteousness = 20154,
            SealOfInsight = 20165,
            Judgement = 20271,
            HolyShock = 20473,
            SacredShield = 20925,
            Bloodthirst = 23881,
            HammerOfWrath = 24275,
            Consecration = 26573,
            SuddenDeath = 29725,
            SealOfTruth = 31801,
            AvengingWrath = 31884,
            AvengersShield = 31935,
            CrusaderStrike = 35395,
            Bloodsurge = 46916,
            Bladestorm = 46924,
            Shockwave = 46968,
            SuddenDeathAura = 52437,
            DivineStorm = 53385,
            HammerOfTheRighteous = 53595,
            ShieldOfTheRighteous = 53600,
            GrandCrusader = 85043,
            TemplarsVerdict = 85256,
            RagingBlow = 85288,
            MeatCleaverAura = 85739,
            SelflessHealerCheck = 85804,
            DivinePurposeCheck = 86172,
            DivinePurpose = 90174,
            Rebuke = 96231,
            WildStrike = 100130,
            ImpendingVictory = 103840,
            HolyAvenger = 105809,
            StormBolt = 107570,
            ExecutionSentence = 114157,
            LightsHammer = 114158,
            HolyPrism = 114165,
            SelflessHealer = 114250,
            DragonRoar = 118000,
            HolyWrath = 119072,
            DoubleJeopardyBuff = 121027,
            MassExorcism = 122032,
            RagingBlowAura = 131116,
            DivineCrusader = 144595,
            HolyShield = 152261,
            Seraphim = 152262,
            EmpoweredSealsCheck = 152263,
            Ravager = 152277,
            LiadrinsRighteousness = 156989,
            MaraadsTruth = 156990,
            FinalVerdict = 157048,
            MeatCleaver = 157473,
            HammerOfWrathEmpowered = 158392,
            ConsecrationFollow = 159556,
            ExecuteArms = 163201,
            CrusadersFury = 165442,
            BlazingContempt = 166831,
            ColossusSmash = 167105,
            UnquenchableThirst = 169683,
            Siegebreaker = 176289
        }
    }
}