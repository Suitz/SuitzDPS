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
    class Rogue
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

        static Rogue()
        {
        }

        public Rogue()
        {
        }


        internal static void DoCombatRogueFury()
        {
            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatRogueFury1();
                        break;
                    case 2:
                        DoCombatRogueFury2();
                        break;
                    case 3:
                        DoCombatRogueFury3();
                        break;
                }
            }
        }

        internal static void DoCombatRogueArms()
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

        internal static void DoCombatRogueProtection()
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

        internal static void DoCombatRogueFury1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatRogueFury1Single();
                    break;
                case true:
                    DoCombatRogueFury1AOE();
                    break;
            }

        }

        internal static void DoCombatRogueFury2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatRogueFury2Single();
                    break;
                case true:
                    DoCombatRogueFury2AOE();
                    break;
            }

        }

        internal static void DoCombatRogueFury3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatRogueFury3Single();
                    break;
                case true:
                    DoCombatRogueFury3AOE();
                    break;
            }

        }

        internal static void DoCombatRogueFury1Single()
        {
            

        }


        internal static void DoCombatRogueFury1AOE()
        {

        }


        internal static void DoCombatRogueFury2Single()
        {
            


        }
    

        internal static void DoCombatRogueFury2AOE()
        {

        }

        internal static void DoCombatRogueFury3Single()
        {

        }

        internal static void DoCombatRogueFury3AOE()
        {

        }


        internal static void DoRogue()
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
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.RogueFury:
                    DoRogueFury();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.RogueArms:
                    DoRogueArms();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.RogueProtection:
                    DoRogueProtection();
                    break;
            }


        }

        internal static void DoRogueProtection()
        {

            /*Init.CheckTierRogue();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Rogue.DoCombatRogueArms();
                return;
            }
            Rogue.DoPreCombatRogueProtection();
            */
        }

        internal static void DoRogueFury()
        {
            Init.CheckTierRogue();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Rogue.DoCombatRogueFury();
                return;
            }
            Rogue.DoPreCombatRogue();
        }

        internal static void DoRogueArms()
        {
            Init.CheckTierRogue();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Rogue.DoCombatRogueArms();
                return;
            }
            Rogue.DoPreCombatRogue();
        }

        internal static void DoPreCombatRogue()
        {
            // Shield
            if (Rotation.CheckPlayerAuraDuration(324) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(324))
            {
                return;
            }
            Rotation.CastSpell(324, 1, 0, 0);
        }

        internal static void DoPreCombatRogueProtection()
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

