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


        internal static void DoCombatMageFury()
        {
            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatMageFury1();
                        break;
                    case 2:
                        DoCombatMageFury2();
                        break;
                    case 3:
                        DoCombatMageFury3();
                        break;
                }
            }
        }

        internal static void DoCombatMageArms()
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

        internal static void DoCombatMageProtection()
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

        internal static void DoCombatMageFury1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatMageFury1Single();
                    break;
                case true:
                    DoCombatMageFury1AOE();
                    break;
            }

        }

        internal static void DoCombatMageFury2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatMageFury2Single();
                    break;
                case true:
                    DoCombatMageFury2AOE();
                    break;
            }

        }

        internal static void DoCombatMageFury3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatMageFury3Single();
                    break;
                case true:
                    DoCombatMageFury3AOE();
                    break;
            }

        }

        internal static void DoCombatMageFury1Single()
        {
            

        }


        internal static void DoCombatMageFury1AOE()
        {

        }


        internal static void DoCombatMageFury2Single()
        {
            


        }
    

        internal static void DoCombatMageFury2AOE()
        {

        }

        internal static void DoCombatMageFury3Single()
        {

        }

        internal static void DoCombatMageFury3AOE()
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
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.MageFury:
                    DoMageFury();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.MageArms:
                    DoMageArms();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.MageProtection:
                    DoMageProtection();
                    break;
            }


        }

        internal static void DoMageProtection()
        {

            /*Init.CheckTierMage();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Mage.DoCombatMageArms();
                return;
            }
            Mage.DoPreCombatMageProtection();
            */
        }

        internal static void DoMageFury()
        {
            Init.CheckTierMage();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Mage.DoCombatMageFury();
                return;
            }
            Mage.DoPreCombatMage();
        }

        internal static void DoMageArms()
        {
            Init.CheckTierMage();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Mage.DoCombatMageArms();
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

        internal static void DoPreCombatMageProtection()
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

