using Anthrax;
using Anthrax.WoW.Classes;
using Anthrax.WoW;
using Anthrax.WoW.Classes.ObjectManager;
using Anthrax.WoW.Internals;
using Anthrax.AI.Controllers;
using SuitzDPS;
using SuitzDPS.Helpers;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SuitzDPS.Classes
{
    class Shaman
    {
        internal static int tier15;
        internal static int tier30;
        internal static int tier45;
        internal static int tier60;
        internal static int tier75;
        internal static int tier90;
        internal static int tier100;

        internal enum Spells : int
        {
            ShamanisticRage = 30823,
            ElementalMastery = 16166,
            FlameShock = 8050,
            StormStrike = 17364,
            LavaLash = 60103,
            LightingBolt = 403,
            LightningShield = 324,
            WaterShield = 52127,
            HealingSurge = 8004,
            PrimalStrike = 73899,
            HearthShock = 8042,
            FTW = 8024,
            WFW = 8232,
            SearingTotem = 3599,
            MagmaTotem = 8190,
            ElementalBlast = 117014,
            UnleashE = 73680,
            Windstrike = 115356,
            ChainL = 421,
            FireNova = 1535,
            ManaTideTotem = 16190,
            HealingTideTotem = 108280,
            HealingStreamTotem = 5394,
            EQ = 61882,
            LavaBurst = 51505,
            LavaBeam = 114074,
            FrostShock = 8056,
            FireElementalTotem = 2894,


            //Resto
            WaterS = 52127,
            ELW = 51730,
            ChainHeal = 1064,
            Riptide = 61295,
            Hrain = 73920,
            ES = 974,
            HW = 331,
            GHW = 77472,
        }

        internal enum Auras : int
        {
            FlameShock = 8050,
            WeakenedBlows = 115798,
            LightningShield = 324,
            EnhanceCheck = 30809,
            FTW = 10400,
            WFW = 33757,
            MWeapon = 53817,
            UnleashF = 73683,
            SearingFlame = 77661,
            RestoCheck = 16196,
            ELW = 52007,
            WaterS = 52127,
            ES = 974,
            Riptide = 61295,
            EleCheck = 88764,
            Full = 95774,
            LavaS = 77762,
            Ass = 114050,
            GhostWolf = 2645,
        }

        internal enum FireTotems : int
        {
            SearingTotem = 3599,
            MagmaTotem = 8190,
            FireElementalTotem = 2894,
        }

        static Shaman()
        {
        }

        public Shaman()
        {
        }


        internal static void DoCombatShamanEnhancement()
        {
            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatShamanEnhancement1();
                        break;
                    case 2:
                        DoCombatShamanEnhancement2();
                        break;
                    case 3:
                        DoCombatShamanEnhancement3();
                        break;
                }
            }
        }

        internal static void DoCombatShamanElemental()
        {

            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {
                if (tier100 == 1)
                {
                    if (!Rotation.isAOE)
                    {

                    }
                    else
                    {

                    }
                }
                if (tier100 == 2)
                {
                    Anthrax.WoW.Logger.WriteLine("To be build!");
                }
                if (tier100 == 3)
                {
                    if (!Rotation.isAOE)
                    {

                    }
                    else
                    {

                    }
                }

            }
        }

        internal static void DoCombatShamanRestoration()
        {

            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {
                if (tier100 == 1)
                {
                    Anthrax.WoW.Logger.WriteLine("To be build!");
                }
                if (tier100 == 2)
                {
                    Anthrax.WoW.Logger.WriteLine("To be build!");
                }
                if (tier100 == 3)
                {
                    Anthrax.WoW.Logger.WriteLine("To be build!");
                }

            }
        }

        internal static void DoCombatShamanEnhancement1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatShamanEnhancement1Single();
                    break;
                case true:
                    DoCombatShamanEnhancement1AOE();
                    break;
            }

        }

        internal static void DoCombatShamanEnhancement2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatShamanEnhancement2Single();
                    break;
                case true:
                    DoCombatShamanEnhancement2AOE();
                    break;
            }

        }

        internal static void DoCombatShamanEnhancement3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatShamanEnhancement3Single();
                    break;
                case true:
                    DoCombatShamanEnhancement3AOE();
                    break;
            }

        }

        internal static void DoCombatShamanEnhancement1Single()
        {
            

        }


        internal static void DoCombatShamanEnhancement1AOE()
        {

        }


        internal static void DoCombatShamanEnhancement2Single()
        {
            //UnleashE
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.UnleashE))
            {
                Rotation.CastSpell((int)Spells.UnleashE, 1, 0, 0);
                //return;
            }

            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Windstrike))
            {
                Rotation.CastSpell((int)Spells.Windstrike, 1, 0, 0);
                //return;
            }

            //LightingBolt
            if (Rotation.CheckPlayerAuraStacks((int)Auras.MWeapon) >= 9 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.LightingBolt))
            {
                Rotation.CastSpell((int)Spells.LightingBolt, 1, 0, 0);
                //return;
            }

            //StormStrike
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.StormStrike))
            {
                Rotation.CastSpell((int)Spells.StormStrike, 1, 0, 0);
                //return;
            }

            //LavaLash
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.LavaLash))
            {
                Rotation.CastSpell((int)Spells.LavaLash, 1, 0, 0);
                //return;
            }

            //FlameShock
            if (!Rotation.CheckTargetAura((int)Auras.FlameShock) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FlameShock)
               || Rotation.CheckTargetAuraDuration((int)Auras.FlameShock) < 3000)
            {
                Rotation.CastSpell((int)Spells.FlameShock, 1, 0, 0);
                //return;
            }

            //LightingBolt
            if (Rotation.CheckPlayerAuraStacks((int)Auras.MWeapon) >= 5 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.LightingBolt))
            {
                Rotation.CastSpell((int)Spells.LightingBolt, 1, 0, 0);
                //return;
            }

            //FrostShock
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FrostShock))
            {
                Rotation.CastSpell((int)Spells.FrostShock, 1, 0, 0);
                //return;
            }


        }
    

        internal static void DoCombatShamanEnhancement2AOE()
        {

        }

        internal static void DoCombatShamanEnhancement3Single()
        {

        }

        internal static void DoCombatShamanEnhancement3AOE()
        {

        }


        internal static void DoShaman()
        {

            /*if (DetectKeyPress.GetKeyState(DetectKeyPress.VK_XBUTTON1) < 0)
            {
                if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DnD) || Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Defile))
                {
                    MouseController.RightClick();
                    if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Defile))
                        ActionBar.ExecuteSpell((int)Spells.Defile);
                    else
                        ActionBar.ExecuteSpell((int)Spells.DnD);
                    MouseController.LockCursor();
                    MouseController.MoveMouse(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
                    MouseController.LeftClick();
                    MouseController.UnlockCursor();
                }
                return;
            }

            if (DetectKeyPress.GetKeyState(DetectKeyPress.VK_XBUTTON2) < 0)
            {
                if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Amz))
                {
                    MouseController.RightClick();
                    ActionBar.ExecuteSpell((int)Spells.Amz);
                    MouseController.LockCursor();
                    MouseController.MoveMouse(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
                    MouseController.LeftClick();
                    MouseController.UnlockCursor();
                }
                return;
            }*/


            switch (ObjectManager.LocalPlayer.Specialization)
            {
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.ShamanEnhancement:
                    DoShamanEnhancement();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.ShamanElemental:
                    DoShamanElemental();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.ShamanRestoration:
                    DoShamanRestoration();
                    break;
            }


        }

        internal static void DoShamanRestoration()
        {

            /*Init.CheckTierShaman();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Shaman.DoCombatShamanElemental();
                return;
            }
            Shaman.DoPreCombatShamanRestoration();
            */
        }

        internal static void DoShamanEnhancement()
        {
            Init.CheckTierShaman();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Shaman.DoCombatShamanEnhancement();
                return;
            }
            Shaman.DoPreCombatShaman();
        }

        internal static void DoShamanElemental()
        {
            Init.CheckTierShaman();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Shaman.DoCombatShamanElemental();
                return;
            }
            Shaman.DoPreCombatShaman();
        }

        internal static void DoPreCombatShaman()
        {
            // Shield
            if (Rotation.CheckPlayerAuraDuration(324) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(324))
            {
                return;
            }
            Rotation.CastSpell(324, 1, 0, 0);
        }

        internal static void DoPreCombatShamanRestoration()
        {
            // Check Horn of Winter
            if (Rotation.CheckPlayerAuraDuration(20925) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(57330))
            {
                return;
            }
            Rotation.CastSpell(57330, 1, 0, 0);

        }


    }
}

