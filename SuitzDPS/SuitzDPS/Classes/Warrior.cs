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
    class Warrior
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

        static Warrior()
        {
        }

        public Warrior()
        {
        }


        internal static void DoCombatWarriorFury()
        {
            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatWarriorFury1();
                        break;
                    case 2:
                        DoCombatWarriorFury2();
                        break;
                    case 3:
                        DoCombatWarriorFury3();
                        break;
                }
            }
        }

        internal static void DoCombatWarriorArms()
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

        internal static void DoCombatWarriorProtection()
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

        internal static void DoCombatWarriorFury1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatWarriorFury1Single();
                    break;
                case true:
                    DoCombatWarriorFury1AOE();
                    break;
            }

        }

        internal static void DoCombatWarriorFury2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatWarriorFury2Single();
                    break;
                case true:
                    DoCombatWarriorFury2AOE();
                    break;
            }

        }

        internal static void DoCombatWarriorFury3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatWarriorFury3Single();
                    break;
                case true:
                    DoCombatWarriorFury3AOE();
                    break;
            }

        }

        internal static void DoCombatWarriorFury1Single()
        {
            

        }


        internal static void DoCombatWarriorFury1AOE()
        {

        }


        internal static void DoCombatWarriorFury2Single()
        {
            


        }
    

        internal static void DoCombatWarriorFury2AOE()
        {

        }

        internal static void DoCombatWarriorFury3Single()
        {

        }

        internal static void DoCombatWarriorFury3AOE()
        {

        }


        internal static void DoWarrior()
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
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.WarriorFury:
                    DoWarriorFury();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.WarriorArms:
                    DoWarriorArms();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.WarriorProtection:
                    DoWarriorProtection();
                    break;
            }


        }

        internal static void DoWarriorProtection()
        {

            /*Init.CheckTierWarrior();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Warrior.DoCombatWarriorArms();
                return;
            }
            Warrior.DoPreCombatWarriorProtection();
            */
        }

        internal static void DoWarriorFury()
        {
            Init.CheckTierWarrior();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Warrior.DoCombatWarriorFury();
                return;
            }
            Warrior.DoPreCombatWarrior();
        }

        internal static void DoWarriorArms()
        {
            Init.CheckTierWarrior();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Warrior.DoCombatWarriorArms();
                return;
            }
            Warrior.DoPreCombatWarrior();
        }

        internal static void DoPreCombatWarrior()
        {
            // Shield
            if (Rotation.CheckPlayerAuraDuration(324) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(324))
            {
                return;
            }
            Rotation.CastSpell(324, 1, 0, 0);
        }

        internal static void DoPreCombatWarriorProtection()
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

