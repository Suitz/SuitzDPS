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
    class Warlock
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

        static Warlock()
        {
        }

        public Warlock()
        {
        }


        internal static void DoCombatWarlockFury()
        {
            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatWarlockFury1();
                        break;
                    case 2:
                        DoCombatWarlockFury2();
                        break;
                    case 3:
                        DoCombatWarlockFury3();
                        break;
                }
            }
        }

        internal static void DoCombatWarlockArms()
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

        internal static void DoCombatWarlockProtection()
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

        internal static void DoCombatWarlockFury1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatWarlockFury1Single();
                    break;
                case true:
                    DoCombatWarlockFury1AOE();
                    break;
            }

        }

        internal static void DoCombatWarlockFury2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatWarlockFury2Single();
                    break;
                case true:
                    DoCombatWarlockFury2AOE();
                    break;
            }

        }

        internal static void DoCombatWarlockFury3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatWarlockFury3Single();
                    break;
                case true:
                    DoCombatWarlockFury3AOE();
                    break;
            }

        }

        internal static void DoCombatWarlockFury1Single()
        {
            

        }


        internal static void DoCombatWarlockFury1AOE()
        {

        }


        internal static void DoCombatWarlockFury2Single()
        {
            


        }
    

        internal static void DoCombatWarlockFury2AOE()
        {

        }

        internal static void DoCombatWarlockFury3Single()
        {

        }

        internal static void DoCombatWarlockFury3AOE()
        {

        }


        internal static void DoWarlock()
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
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.WarlockAffliction:
                    DoWarlockFury();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.WarlockDemonology:
                    DoWarlockArms();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.WarlockDestruction:
                    DoWarlockProtection();
                    break;
            }


        }

        internal static void DoWarlockProtection()
        {

            /*Init.CheckTierWarlock();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Warlock.DoCombatWarlockArms();
                return;
            }
            Warlock.DoPreCombatWarlockProtection();
            */
        }

        internal static void DoWarlockFury()
        {
            Init.CheckTierWarlock();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Warlock.DoCombatWarlockFury();
                return;
            }
            Warlock.DoPreCombatWarlock();
        }

        internal static void DoWarlockArms()
        {
            Init.CheckTierWarlock();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Warlock.DoCombatWarlockArms();
                return;
            }
            Warlock.DoPreCombatWarlock();
        }

        internal static void DoPreCombatWarlock()
        {
            // Shield
            if (Rotation.CheckPlayerAuraDuration(324) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(324))
            {
                return;
            }
            Rotation.CastSpell(324, 1, 0, 0);
        }

        internal static void DoPreCombatWarlockProtection()
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

