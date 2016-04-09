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
    class Monk
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

        static Monk()
        {
        }

        public Monk()
        {
        }


        internal static void DoCombatMonkFury()
        {
            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatMonkFury1();
                        break;
                    case 2:
                        DoCombatMonkFury2();
                        break;
                    case 3:
                        DoCombatMonkFury3();
                        break;
                }
            }
        }

        internal static void DoCombatMonkArms()
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

        internal static void DoCombatMonkProtection()
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

        internal static void DoCombatMonkFury1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatMonkFury1Single();
                    break;
                case true:
                    DoCombatMonkFury1AOE();
                    break;
            }

        }

        internal static void DoCombatMonkFury2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatMonkFury2Single();
                    break;
                case true:
                    DoCombatMonkFury2AOE();
                    break;
            }

        }

        internal static void DoCombatMonkFury3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatMonkFury3Single();
                    break;
                case true:
                    DoCombatMonkFury3AOE();
                    break;
            }

        }

        internal static void DoCombatMonkFury1Single()
        {
            

        }


        internal static void DoCombatMonkFury1AOE()
        {

        }


        internal static void DoCombatMonkFury2Single()
        {
            


        }
    

        internal static void DoCombatMonkFury2AOE()
        {

        }

        internal static void DoCombatMonkFury3Single()
        {

        }

        internal static void DoCombatMonkFury3AOE()
        {

        }


        internal static void DoMonk()
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
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.MonkFury:
                    DoMonkFury();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.MonkArms:
                    DoMonkArms();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.MonkProtection:
                    DoMonkProtection();
                    break;
            }


        }

        internal static void DoMonkProtection()
        {

            /*Init.CheckTierMonk();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Monk.DoCombatMonkArms();
                return;
            }
            Monk.DoPreCombatMonkProtection();
            */
        }

        internal static void DoMonkFury()
        {
            Init.CheckTierMonk();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Monk.DoCombatMonkFury();
                return;
            }
            Monk.DoPreCombatMonk();
        }

        internal static void DoMonkArms()
        {
            Init.CheckTierMonk();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Monk.DoCombatMonkArms();
                return;
            }
            Monk.DoPreCombatMonk();
        }

        internal static void DoPreCombatMonk()
        {
            // Shield
            if (Rotation.CheckPlayerAuraDuration(324) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(324))
            {
                return;
            }
            Rotation.CastSpell(324, 1, 0, 0);
        }

        internal static void DoPreCombatMonkProtection()
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

