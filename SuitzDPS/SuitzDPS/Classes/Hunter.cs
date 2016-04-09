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
    class Hunter
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

        static Hunter()
        {
        }

        public Hunter()
        {
        }


        internal static void DoCombatHunterFury()
        {
            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatHunterFury1();
                        break;
                    case 2:
                        DoCombatHunterFury2();
                        break;
                    case 3:
                        DoCombatHunterFury3();
                        break;
                }
            }
        }

        internal static void DoCombatHunterArms()
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

        internal static void DoCombatHunterProtection()
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

        internal static void DoCombatHunterFury1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatHunterFury1Single();
                    break;
                case true:
                    DoCombatHunterFury1AOE();
                    break;
            }

        }

        internal static void DoCombatHunterFury2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatHunterFury2Single();
                    break;
                case true:
                    DoCombatHunterFury2AOE();
                    break;
            }

        }

        internal static void DoCombatHunterFury3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatHunterFury3Single();
                    break;
                case true:
                    DoCombatHunterFury3AOE();
                    break;
            }

        }

        internal static void DoCombatHunterFury1Single()
        {
            

        }


        internal static void DoCombatHunterFury1AOE()
        {

        }


        internal static void DoCombatHunterFury2Single()
        {
            


        }
    

        internal static void DoCombatHunterFury2AOE()
        {

        }

        internal static void DoCombatHunterFury3Single()
        {

        }

        internal static void DoCombatHunterFury3AOE()
        {

        }


        internal static void DoHunter()
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
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.HunterFury:
                    DoHunterFury();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.HunterArms:
                    DoHunterArms();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.HunterProtection:
                    DoHunterProtection();
                    break;
            }


        }

        internal static void DoHunterProtection()
        {

            /*Init.CheckTierHunter();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Hunter.DoCombatHunterArms();
                return;
            }
            Hunter.DoPreCombatHunterProtection();
            */
        }

        internal static void DoHunterFury()
        {
            Init.CheckTierHunter();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Hunter.DoCombatHunterFury();
                return;
            }
            Hunter.DoPreCombatHunter();
        }

        internal static void DoHunterArms()
        {
            Init.CheckTierHunter();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Hunter.DoCombatHunterArms();
                return;
            }
            Hunter.DoPreCombatHunter();
        }

        internal static void DoPreCombatHunter()
        {
            // Shield
            if (Rotation.CheckPlayerAuraDuration(324) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(324))
            {
                return;
            }
            Rotation.CastSpell(324, 1, 0, 0);
        }

        internal static void DoPreCombatHunterProtection()
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

