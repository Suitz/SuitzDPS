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
    class Priest
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

        static Priest()
        {
        }

        public Priest()
        {
        }


        internal static void DoCombatPriestFury()
        {
            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatPriestFury1();
                        break;
                    case 2:
                        DoCombatPriestFury2();
                        break;
                    case 3:
                        DoCombatPriestFury3();
                        break;
                }
            }
        }

        internal static void DoCombatPriestArms()
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

        internal static void DoCombatPriestProtection()
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

        internal static void DoCombatPriestFury1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatPriestFury1Single();
                    break;
                case true:
                    DoCombatPriestFury1AOE();
                    break;
            }

        }

        internal static void DoCombatPriestFury2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatPriestFury2Single();
                    break;
                case true:
                    DoCombatPriestFury2AOE();
                    break;
            }

        }

        internal static void DoCombatPriestFury3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatPriestFury3Single();
                    break;
                case true:
                    DoCombatPriestFury3AOE();
                    break;
            }

        }

        internal static void DoCombatPriestFury1Single()
        {
            

        }


        internal static void DoCombatPriestFury1AOE()
        {

        }


        internal static void DoCombatPriestFury2Single()
        {
            


        }
    

        internal static void DoCombatPriestFury2AOE()
        {

        }

        internal static void DoCombatPriestFury3Single()
        {

        }

        internal static void DoCombatPriestFury3AOE()
        {

        }


        internal static void DoPriest()
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
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.PriestDiscipline:
                    DoPriestFury();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.PriestHoly:
                    DoPriestArms();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.PriestShadow:
                    DoPriestProtection();
                    break;
            }


        }

        internal static void DoPriestProtection()
        {

            /*Init.CheckTierPriest();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Priest.DoCombatPriestArms();
                return;
            }
            Priest.DoPreCombatPriestProtection();
            */
        }

        internal static void DoPriestFury()
        {
            Init.CheckTierPriest();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Priest.DoCombatPriestFury();
                return;
            }
            Priest.DoPreCombatPriest();
        }

        internal static void DoPriestArms()
        {
            Init.CheckTierPriest();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Priest.DoCombatPriestArms();
                return;
            }
            Priest.DoPreCombatPriest();
        }

        internal static void DoPreCombatPriest()
        {
            // Shield
            if (Rotation.CheckPlayerAuraDuration(324) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(324))
            {
                return;
            }
            Rotation.CastSpell(324, 1, 0, 0);
        }

        internal static void DoPreCombatPriestProtection()
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

