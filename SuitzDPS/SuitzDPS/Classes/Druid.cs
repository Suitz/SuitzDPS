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
    internal class Druid
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
            wrath = 5176,
            starfire = 2912,
            surge = 78674,
            moon = 8921,
            sun = 93402,
            starfall = 48505,
        }
        
        internal enum Auras : int
        {
            lunaremp = 164724,
            solaremp = 164725,
            sunpeak = 171744,
            lunapeak = 171743,
            moonfire = 164812,
            sunfire = 164815,
            solarmight = 164545,
            lunarmight = 164547,
            incarnation = 102560,
            sky = 112071,
        }


        static Druid()
        {
        }

        public Druid()
        {
        }


        internal static void DoCombatDruidBalance()
        {
            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatDruidBalance1();
                        break;
                    case 2:
                        DoCombatDruidBalance2();
                        break;
                    case 3:
                        DoCombatDruidBalance3();
                        break;
                }
            }
        }

        internal static void DoCombatDruidCat()
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

        internal static void DoCombatDruidBear()
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

        internal static void DoCombatDruidRestoration()
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

        internal static void DoCombatDruidBalance1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDruidBalance1Single();
                    break;
                case true:
                    DoCombatDruidBalance1AOE();
                    break;
            }

        }

        internal static void DoCombatDruidBalance2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDruidBalance2Single();
                    break;
                case true:
                    DoCombatDruidBalance2AOE();
                    break;
            }

        }

        internal static void DoCombatDruidBalance3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDruidBalance3Single();
                    break;
                case true:
                    DoCombatDruidBalance3AOE();
                    break;
            }

        }

        internal static void DoCombatDruidBalance1Single()
        {
            if (ObjectManager.LocalPlayer.IsCasting)
            {
                return;
            }

            if (Rotation.CheckPlayerAura((int)Auras.sky))
            {
                if (!Rotation.CheckTargetAura((int)Auras.sunfire) ||
                    !Rotation.CheckTargetAura((int)Auras.moonfire))
                {
                    Rotation.CastSpell((int)Spells.moon, 1, 0, 0);
                    //return;
                }

                //Starsurge
                if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.surge) && !Rotation.CheckPlayerAura((int)Auras.lunarmight))
                {
                    Rotation.CastSpell((int)Spells.surge, 1, 0, 0);
                    //return;
                }

                //Starfire with lunar empower

                if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.starfire))
                {
                    Rotation.CastSpell((int)Spells.starfire, 1, 0, 0);
                    //return;
                }
            }

            //Solar
            if (Rotation.CheckPlayerAura((int)Auras.solaremp))
            {
                //Starsurge
                if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.surge) && !Rotation.CheckPlayerAura((int)Auras.solarmight))
                {
                    Rotation.CastSpell((int)Spells.surge, 1, 0, 0);
                    //return;
                }

                //Sunfire with sunpeak
                if (Rotation.CheckPlayerAura((int)Auras.sunpeak) && !Rotation.CheckTargetAura((int)Auras.sunfire) ||
                    Rotation.CheckPlayerAura((int)Auras.sunpeak) && Rotation.CheckTargetAuraDuration((int)Auras.sunfire) < 11000)
                {
                    if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.sun))
                    {
                        Rotation.CastSpell((int)Spells.sun, 1, 0, 0);
                       //return;
                    }
                }

                //Wrath with solar empower
                if (Rotation.CheckPlayerAura((int)Auras.solaremp))
                {
                    if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.wrath))
                    {
                        Rotation.CastSpell((int)Spells.wrath, 1, 0, 0);
                        //return;
                    }
                }
            }

            //Lunar
            if (Rotation.CheckPlayerAura((int)Auras.lunaremp))
            {
                //Starsurge
                if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.surge) && !Rotation.CheckPlayerAura((int)Auras.lunarmight))
                {
                    Rotation.CastSpell((int)Spells.surge, 1, 0, 0);
                    //return;
                }

                //Moonfire with lunapeak
                if (Rotation.CheckPlayerAura((int)Auras.lunapeak) && !Rotation.CheckTargetAura((int)Auras.moonfire) ||
                    Rotation.CheckPlayerAura((int)Auras.lunapeak) && Rotation.CheckTargetAuraDuration((int)Auras.moonfire) < 11000)
                {
                    if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.moon))
                    {
                        Rotation.CastSpell((int)Spells.moon, 1, 0, 0);
                        //return;
                    }
                }

                //Starfire with lunar empower
                if (Rotation.CheckPlayerAura((int)Auras.lunaremp))
                {
                    if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.starfire))
                    {
                        Rotation.CastSpell((int)Spells.starfire, 1, 0, 0);
                        //return;
                    }
                }

            }

            //Sunfire
            if (!Rotation.CheckTargetAura((int)Auras.sunfire))
            {
                if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.sun) && Rotation.CheckPlayerAura((int)Auras.solaremp))
                {
                    Rotation.CastSpell((int)Spells.sun, 1, 0, 0);
                    //return;
                }
            }

            //Moonfire
            if (!Rotation.CheckTargetAura((int)Auras.moonfire))
            {
                if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.moon))
                {
                    Rotation.CastSpell((int)Spells.moon, 1, 0, 0);
                    //return;
                }
            }

            //filler
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.wrath))
            {
                Rotation.CastSpell((int)Spells.wrath, 1, 0, 0);
                //return;
            }

        }
    

        internal static void DoCombatDruidBalance1AOE()
        {

        }


        internal static void DoCombatDruidBalance2Single()
        {

        }

        internal static void DoCombatDruidBalance2AOE()
        {

        }

        internal static void DoCombatDruidBalance3Single()
        {

        }

        internal static void DoCombatDruidBalance3AOE()
        {

        }


        //Choose Spec Rotation
        internal static void DoDruid()
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
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.DruidBalance:
                    DoDruidBalance();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.DruidCat:
                    DoDruidCat();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.DruidRestoration:
                    DoDruidRestoration();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.DruidBear:
                    DoDruidBear();
                    break;
            }


        }

        internal static void DoDruidRestoration()
        {

            /*Init.CheckTierDruid();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Druid.DoCombatDruidCat();
                return;
            }
            Druid.DoPreCombatDruidRestoration();
            */
        }

        internal static void DoDruidBalance()
        {
            Init.CheckTierDruid();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Druid.DoCombatDruidBalance();
                return;
            }
            Druid.DoPreCombatDruid();
        }

        internal static void DoDruidCat()
        {
            Init.CheckTierDruid();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Druid.DoCombatDruidCat();
                return;
            }
            Druid.DoPreCombatDruid();
        }

        internal static void DoDruidBear()
        {
            Init.CheckTierDruid();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                Druid.DoCombatDruidBear();
                return;
            }
            Druid.DoPreCombatDruid();
        }

        internal static void DoPreCombatDruid()
        {
            // Check MdW
            if (Rotation.CheckPlayerAuraDuration(1126) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(1126))
            {
                return;
            }
            Rotation.CastSpell(57330, 0, 0, 1);
        }



    }
}