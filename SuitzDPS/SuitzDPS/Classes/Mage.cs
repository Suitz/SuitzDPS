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
    class Mage
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
            
        }

        internal enum Auras : int
        {
           
        }

        internal enum Stances : int
        {
           
        }

        static Mage()
        {
        }

        public Mage()
        {
        }


        internal static void DoCombatMageArcane()
        {
            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatMageArcane1();
                        break;
                    case 2:
                        DoCombatMageArcane2();
                        break;
                    case 3:
                        DoCombatMageArcane3();
                        break;
                }
            }
        }

        internal static void DoCombatMageFire()
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

        internal static void DoCombatMageFrost()
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

        internal static void DoCombatMageArcane1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatMageArcane1Single();
                    break;
                case true:
                    DoCombatMageArcane1AOE();
                    break;
            }

        }

        internal static void DoCombatMageArcane2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatMageArcane2Single();
                    break;
                case true:
                    DoCombatMageArcane2AOE();
                    break;
            }

        }

        internal static void DoCombatMageArcane3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatMageArcane3Single();
                    break;
                case true:
                    DoCombatMageArcane3AOE();
                    break;
            }

        }

        internal static void DoCombatMageArcane1Single()
        {
            

        }


        internal static void DoCombatMageArcane1AOE()
        {

        }


        internal static void DoCombatMageArcane2Single()
        {
            


        }
    

        internal static void DoCombatMageArcane2AOE()
        {

        }

        internal static void DoCombatMageArcane3Single()
        {

        }

        internal static void DoCombatMageArcane3AOE()
        {

        }


        internal static void DoMage()
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
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.MageArcane:
                    DoMageArcane();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.MageFire:
                    DoMageFire();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.MageFrost:
                    DoMageFrost();
                    break;
            }


        }

        internal static void DoMageFrost()
        {

            /*Init.CheckTierMage();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Mage.DoCombatMageFire();
                return;
            }
            Mage.DoPreCombatMageFrost();
            */
        }

        internal static void DoMageArcane()
        {
            Init.CheckTierMage();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Mage.DoCombatMageArcane();
                return;
            }
            Mage.DoPreCombatMage();
        }

        internal static void DoMageFire()
        {
            Init.CheckTierMage();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Mage.DoCombatMageFire();
                return;
            }
            Mage.DoPreCombatMage();
        }

        internal static void DoPreCombatMage()
        {
            // Shield
            if (Rotation.CheckPlayerAuraDuration(324) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(324))
            {
                return;
            }
            Rotation.CastSpell(324, 1, 0, 0);
        }

        internal static void DoPreCombatMageFrost()
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

