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
    internal class DeathKnight
    {


        internal enum Spells : int
        {
            BloodStrike = 45902,
            ScourgeStrike = 55090,
            FesteringStrike = 85948,
            FrostStrike = 49143,
            PlagueStrike = 45462,
            IcyTouch = 45477,
            DeathStrike = 49998,
            RuneStrike = 56815,
            DeathCoil = 47541,
            Obliterate = 49020,
            SoulReaper = 130736,
            Outbreak = 77575,
            BoneShield = 49222,
            BloodTap = 45529,
            BloodBoil = 50842,
            RuneTap = 48982,
            HeartStrike = 45902,
            HoW = 57330,
            SoulReaperBlood = 114866,
            HS = 55050,
            SummonPet = 46584,
            FS = 85948,
            SoulReaperUnholy = 130736,
            SoulReaperFrost = 130735,
            Pest = 50842,
            DarkT = 63560,
            Conversion = 119975,
            HowlingBlast = 49184,
            PoF = 51271,
            UnholyBlight = 115989,
            BloodPresence = 48263,
            DnD = 43265,
            UnholyFrenzy = 49016,
            Garg = 49206,
            Defile = 152280,
            PlagueLeech = 123693,
            Amz = 51052,
            BoS = 152279,
            RW = 47568,
        }

        internal enum Auras : int
        {
            FrostFever = 55095,
            BloodPlague = 55078,
            HoW = 57330,
            BloodTap = 114851,
            Conversion = 119975,
            CS = 81141,
            BoneShield = 49222,
            BloodPresence = 48263,
            BloodShield = 77535,
            UHP = 56835,
            SF = 81132,
            BloodCheck = 50371,
            SRB = 114866,
            Shadow = 91342,
            SDoom = 81340,
            PetDarkT = 63560,
            SoulReaperU = 130736,
            FP = 48266,
            KillingM = 51124,
            Rime = 59052,
            SRF = 130735,
            PoF = 51271,
            UHS = 53365,
            UHB = 115989,
            FrostCheck = 51128,
            DWCheck = 51714,
            UnholyCheck = 56835,
            DeathS = 144901,
            SGarg = 49206,
            UnholyF = 49016,
            Str1 = 138702,
            Str2 = 148899,
            BoS = 152279,
            NP = 155159,
        }


        static DeathKnight()
        {
        }

        public DeathKnight()
        {
        }

        internal static void DoCombatDeathKnightFrost()
        {
            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatDeathKnightFrost1();
                        break;
                    case 2:
                        DoCombatDeathKnightFrost2();
                        break;
                    case 3:
                        DoCombatDeathKnightFrost3();
                        break;
                }
            }
        }

        internal static void DoCombatDeathKnightUnholy()
        {

            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatDeathKnightUnholy1();
                        break;
                    case 2:
                        DoCombatDeathKnightUnholy2();
                        break;
                    case 3:
                        DoCombatDeathKnightUnholy3();
                        break;
                }
            }
        }

        internal static void DoCombatDeathKnightBlood()
        {

            if (ObjectManager.Target.IsValid && !ObjectManager.LocalPlayer.IsCasting)
            {

                switch (Init.tier100)
                {
                    case 1:
                        DoCombatDeathKnightBlood1();
                        break;
                    case 2:
                        DoCombatDeathKnightBlood2();
                        break;
                    case 3:
                        DoCombatDeathKnightBlood3();
                        break;
                }
            }
        }

        internal static void DoCombatDeathKnightFrost1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDeathKnightFrost1Single();
                    break;
                case true:
                    DoCombatDeathKnightFrost1AOE();
                    break;
            }

        }

        internal static void DoCombatDeathKnightFrost2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDeathKnightFrost2Single();
                    break;
                case true:
                    DoCombatDeathKnightFrost2AOE();
                    break;
            }

        }

        internal static void DoCombatDeathKnightFrost3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDeathKnightFrost3Single();
                    break;
                case true:
                    DoCombatDeathKnightFrost3AOE();
                    break;
            }

        }

        internal static void DoCombatDeathKnightFrost1Single()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightFrost1AOE()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightFrost2Single()
        {
            if (Rotation.CheckPlayerAura((int)Auras.BloodTap) &&
            Rotation.CheckPlayerAuraStacks((int)Auras.BloodTap) >= 10 &&
            Anthrax.AI.Controllers.Spell.CanCast((int)Spells.BloodTap) &&
            Rotation.CheckRuneCount() < 4)
            {
                Rotation.CastSpell((int)Spells.BloodTap, 0, 0, 0);
                return;
            }

            //Soul Reaper if Target Health below 35%
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.SoulReaperFrost) && ObjectManager.Target.HealthPercent < 35)
            {
                Rotation.CastSpell((int)Spells.SoulReaperFrost, 1, 0, 0);
                return;
            }

            //Frost Strike
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FrostStrike) && Rotation.CheckPlayerAura((int)Auras.KillingM))
            {
                Rotation.CastSpell((int)Spells.FrostStrike, 1, 0, 0);
                return;
            }

            // Obliterate
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Obliterate) && Rotation.CheckPlayerAura((int)Auras.KillingM))
            {
                Rotation.CastSpell((int)Spells.Obliterate, 1, 0, 0);
                return;
            }

            //Frost Strike
            if (ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) >= 89 &&
                 Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FrostStrike))
            {
                Rotation.CastSpell((int)Spells.FrostStrike, 1, 0, 0);
                return;
            }

            // HowlingBlast with Rime
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.HowlingBlast) && Rotation.CheckPlayerAura((int)Auras.Rime))
            {
                Rotation.CastSpell((int)Spells.HowlingBlast, 1, 0, 0);
                return;
            }

            // Frost Strike
            if (ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) >= 77 &&
            Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FrostStrike))
            {
                Rotation.CastSpell((int)Spells.FrostStrike, 1, 0, 0);
                return;
            }

            if (!Rotation.CheckTargetAura((int)Auras.FrostFever) &&
                Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak) ||
                !Rotation.CheckTargetAura((int)Auras.BloodPlague) &&
                Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak))
            {
                Rotation.CastSpell((int)Spells.Outbreak, 1, 0, 0);
                return;
            }

            if (!Rotation.CheckTargetAura((int)Auras.BloodPlague) &&
                Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueStrike))

            {
                Rotation.CastSpell((int)Spells.PlagueStrike, 1, 0, 0);
                return;
            }

            // HowlingBlast
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.HowlingBlast))
            {
                Rotation.CastSpell((int)Spells.HowlingBlast, 1, 0, 0);
                return;
            }

            if (Rotation.CheckPlayerAura((int)Auras.BloodTap) &&
                Rotation.CheckPlayerAuraStacks((int)Auras.BloodTap) >= 5 &&
                Anthrax.AI.Controllers.Spell.CanCast((int)Spells.BloodTap) &&
                Rotation.CheckRuneCount() < 4)
            {
                Rotation.CastSpell((int)Spells.BloodTap, 0, 0, 0);
                return;
            }

            // Plague Leech if Outbreak is up and 2 runes empty
            if (Rotation.CheckTargetAura((int)Auras.FrostFever) &&
                Rotation.CheckTargetAura((int)Auras.BloodPlague) &&
               !Rotation.CheckPlayerAura((int)Auras.KillingM) &&
                Rotation.CheckRuneCount() < 4 &&
                Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueLeech))
            {
                Rotation.CastSpell((int)Spells.PlagueLeech, 1, 0, 0);
                return;
            }
            Anthrax.AI.Controllers.Spell.AttackTarget();
        }

        internal static void DoCombatDeathKnightFrost2AOE()
        {
            if (Rotation.CheckPlayerAura((int)Auras.BloodTap) &&
                           Rotation.CheckPlayerAuraStacks((int)Auras.BloodTap) >= 10 &&
                           Anthrax.AI.Controllers.Spell.CanCast((int)Spells.BloodTap) &&
                           Rotation.CheckRuneCount() < 4)
            {
                Rotation.CastSpell((int)Spells.BloodTap, 0, 0, 0);
                return;
            }

            //Soul Reaper if Target Health below 35%
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.SoulReaperFrost) && ObjectManager.Target.HealthPercent < 35)
            {
                Rotation.CastSpell((int)Spells.SoulReaperFrost, 1, 0, 0);
                return;
            }

            if (!Rotation.CheckTargetAura((int)Auras.FrostFever) &&
                    Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak) ||
                    !Rotation.CheckTargetAura((int)Auras.BloodPlague) &&
                    Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak))
            {
                Rotation.CastSpell((int)Spells.Outbreak, 1, 0, 0);
                return;
            }

            if (!Rotation.CheckTargetAura((int)Auras.BloodPlague) &&
                Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueStrike))

            {
                Rotation.CastSpell((int)Spells.PlagueStrike, 1, 0, 0);
                return;
            }

            //Frost Strike
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FrostStrike) && (ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) >= 89) ||
                Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FrostStrike) && Rotation.CheckPlayerAura((int)Auras.KillingM))
            {
                Rotation.CastSpell((int)Spells.FrostStrike, 1, 0, 0);
                return;
            }

            // Obliterate
            //if (Spell.CanCast((int)Spells.Obliterate) && Rotation.CheckPlayerAura((int)Auras.KillingM))
            //{
            //    Rotation.CastSpell((int)Spells.Obliterate, 1, 0, 0);
            //    return;
            //}

            // HowlingBlast
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.HowlingBlast))
            {
                Rotation.CastSpell((int)Spells.HowlingBlast, 1, 0, 0);
                return;
            }

            // Frost Strike
            if (ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) >= 77 &&
                Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FrostStrike))
            {
                Rotation.CastSpell((int)Spells.FrostStrike, 1, 0, 0);
                return;
            }

            if (Rotation.CheckPlayerAura((int)Auras.BloodTap) &&
                Rotation.CheckPlayerAuraStacks((int)Auras.BloodTap) >= 5 &&
                Anthrax.AI.Controllers.Spell.CanCast((int)Spells.BloodTap) &&
                Rotation.CheckRuneCount() < 4)
            {
                Rotation.CastSpell((int)Spells.BloodTap, 0, 0, 0);
                return;
            }

            // Plague Leech if Outbreak is up and 2 runes empty
            if (Rotation.CheckTargetAura((int)Auras.FrostFever) &&
                Rotation.CheckTargetAura((int)Auras.BloodPlague) &&
                !Rotation.CheckPlayerAura((int)Auras.KillingM) &&
                Rotation.CheckRuneCount() < 4 &&
                Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueLeech))
            {
                Rotation.CastSpell((int)Spells.PlagueLeech, 1, 0, 0);
                return;
            }

            Anthrax.AI.Controllers.Spell.AttackTarget();
        }

        internal static void DoCombatDeathKnightFrost3Single()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightFrost3AOE()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightUnholy1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDeathKnightUnholy1Single();
                    break;
                case true:
                    DoCombatDeathKnightUnholy1AOE();
                    break;
            }

        }

        internal static void DoCombatDeathKnightUnholy2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDeathKnightUnholy2Single();
                    break;
                case true:
                    DoCombatDeathKnightUnholy2AOE();
                    break;
            }

        }

        internal static void DoCombatDeathKnightUnholy3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDeathKnightUnholy3Single();
                    break;
                case true:
                    DoCombatDeathKnightUnholy3AOE();
                    break;
            }

        }

        internal static void DoCombatDeathKnightUnholy1Single()
        {
            int runes = 0;

            if(Rotation.CheckTargetAuraStacks((int)Auras.NP) < 3 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.UnholyBlight) || 
               !Rotation.CheckTargetAura((int)Auras.NP) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.UnholyBlight))

            {
                Rotation.CastSpell((int)Spells.UnholyBlight, 1, 0, 0);
                return;
            }



            //Soul Reaper if Target Health below 45%
            if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.SoulReaper) && ObjectManager.Target.HealthPercent < 46) &&
                ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 90)
            {
                Rotation.CastSpell((int)Spells.SoulReaper, 1, 0, 0);
                return;
            }



            if (!Rotation.CheckTargetAura((int)Auras.NP))
            {

                if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak))
                {
                    Rotation.CastSpell((int)Spells.Outbreak, 1, 0, 0);
                    return;
                }
                else
                {
                    if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueStrike))
                    {
                        Rotation.CastSpell((int)Spells.PlagueStrike, 1, 0, 0);
                        return;
                    }
                }
            }

            // Death Coil
            if(Rotation.CheckPlayerAura((int)Auras.SDoom) && Rotation.CheckPlayerAuraStacks((int)Auras.BloodTap) < 11 ||
               Rotation.CheckPlayerAura((int)Auras.Shadow) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DeathCoil) ||
               ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) >= 81 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DeathCoil))
            {
                Rotation.CastSpell((int)Spells.DeathCoil, 1, 0, 0);
                return;
            }

            runes = 0;
            runes += ObjectManager.LocalPlayer.GetReadyRuneCountByType(WowLocalPlayer.WowRuneType.Unholy);
            // Scourge Strike
            if (runes == 2 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.ScourgeStrike))
            {
                Rotation.CastSpell((int)Spells.ScourgeStrike, 1, 0, 0);
                return;
            }

            // Festering Strike
            if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FesteringStrike)) && !Anthrax.AI.Controllers.Spell.CanCast((int)Spells.UnholyBlight))
            {
                Rotation.CastSpell((int)Spells.FesteringStrike, 1, 0, 0);
                return;
            }

            // DarkT
            if (Rotation.CheckPlayerAuraStacks((int)Auras.Shadow) > 4 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DarkT))
            {
                Rotation.CastSpell((int)Spells.DarkT, 1, 0, 0);
                return;
            }

            if (Rotation.CheckPlayerAuraStacks((int)Auras.BloodTap) > 10 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.BloodTap) && Rotation.CheckRuneCount() <= 4)
            {
                Rotation.CastSpell((int)Spells.BloodTap, 0, 0, 0);
                return;
            }

            // Death Coil
            if (ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) > 80 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DeathCoil) ||
                Rotation.CheckPlayerAuraStacks((int)Auras.BloodTap) <= 10 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DeathCoil))
            {
                Rotation.CastSpell((int)Spells.DeathCoil, 1, 0, 0);
                return;
            }

            // Festering Strike
            if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FesteringStrike) && ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) < 75)
            {
                Rotation.CastSpell((int)Spells.FesteringStrike, 1, 0, 0);
                return;
            }

            // Scourge Strike
            if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.ScourgeStrike)) && ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) < 75)
            {
                Rotation.CastSpell((int)Spells.ScourgeStrike, 1, 0, 0);
                return;
            }

            Anthrax.AI.Controllers.Spell.AttackTarget();
        }

        internal static void DoCombatDeathKnightUnholy1AOE()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightUnholy2Single()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightUnholy2AOE()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightUnholy3Single()
        {
            int time = 0;

            if (!Anthrax.AI.Controllers.Spell.CanCast((int)Spells.BoS))
            {
                time = Cooldown.GetCooldowns().First(x => x.SpellId == 152279 && x.TimeLeft > 0).TimeLeft;
            }

            //BoS go!
            if (Rotation.CheckPlayerAura((int)Auras.BoS))
            {
                if (!Rotation.CheckTargetAura((int)Auras.FrostFever) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak) && ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 30 ||
                     !Rotation.CheckTargetAura((int)Auras.BloodPlague) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak) && ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 30)
                {
                    Rotation.CastSpell((int)Spells.Outbreak, 1, 0, 0);
                    return;
                }

                if (!Rotation.CheckTargetAura((int)Auras.BloodPlague) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueStrike) && ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 30)
                {
                    Rotation.CastSpell((int)Spells.PlagueStrike, 1, 0, 0);
                    return;
                }

                //Soul Reaper if Target Health below 45%
                if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.SoulReaper) && ObjectManager.Target.HealthPercent < 46) &&
                    ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 90)
                {
                    Rotation.CastSpell((int)Spells.SoulReaper, 1, 0, 0);
                    return;
                }

                // Scourge Strike
                if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.ScourgeStrike)) && ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 88)
                {
                    Rotation.CastSpell((int)Spells.ScourgeStrike, 1, 0, 0);
                    return;
                }

                // Festering Strike
                if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FesteringStrike)) && ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 80)
                {
                    Rotation.CastSpell((int)Spells.FesteringStrike, 1, 0, 0);
                    return;
                }

                if (Rotation.CheckPlayerAuraStacks((int)Auras.BloodTap) >= 5 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.BloodTap) && Rotation.CheckRuneCount() <= 4)
                {
                    Rotation.CastSpell((int)Spells.BloodTap, 0, 0, 0);
                    return;
                }

                // Plague Leech if Outbreak is up and 2 runes empty
                if (Rotation.CheckTargetAura((int)Auras.FrostFever) &&
                    Rotation.CheckTargetAura((int)Auras.BloodPlague) &&
                    Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueLeech) && Rotation.CheckRuneCount() < 4)
                {
                    Rotation.CastSpell((int)Spells.PlagueLeech, 0, 0, 0);
                    return;
                }

                if (Rotation.CheckPlayerAura((int)Auras.SDoom))
                {
                    Rotation.CastSpell((int)Spells.DeathCoil, 0, 0, 0);
                    return;
                }

                // DarkT
                if (Rotation.CheckPlayerAuraStacks((int)Auras.Shadow) > 4 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DarkT))
                {
                    Rotation.CastSpell((int)Spells.DarkT, 1, 0, 0);
                    return;
                }
                Anthrax.AI.Controllers.Spell.AttackTarget();
            }

            if (time < 4000 && !Anthrax.AI.Controllers.Spell.CanCast((int)Spells.BoS))
            {           
                if (!Rotation.CheckTargetAura((int)Auras.FrostFever) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak) ||
                    !Rotation.CheckTargetAura((int)Auras.BloodPlague) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak))
                {
                    Rotation.CastSpell((int)Spells.Outbreak, 1, 0, 0);
                    return;
                }

                if (!Rotation.CheckTargetAura((int)Auras.BloodPlague) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueStrike) || 
                    Rotation.CheckTargetAuraDuration((int)Auras.BloodPlague) < 3000 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueStrike))
                {
                    Rotation.CastSpell((int)Spells.PlagueStrike, 1, 0, 0);
                    return;
                }

                if (Rotation.CheckPlayerAura((int)Auras.SDoom))
                {
                    Rotation.CastSpell((int)Spells.DeathCoil, 0, 0, 0);
                    return;
                }

                // DarkT
                if (Rotation.CheckPlayerAuraStacks((int)Auras.Shadow) > 4 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DarkT))
                {
                    Rotation.CastSpell((int)Spells.DarkT, 1, 0, 0);
                    return;
                }
                Anthrax.AI.Controllers.Spell.AttackTarget();
            }

            

            if (time < 25000 && time > 4000 || Anthrax.AI.Controllers.Spell.CanCast((int)Spells.BoS))
            {
                if (Rotation.CheckTargetAura((int)Auras.BloodPlague) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueStrike) && Rotation.CheckTargetAuraDuration((int)Auras.BloodPlague) < 3000)
                {
                    Rotation.CastSpell((int)Spells.PlagueStrike, 1, 0, 0);
                    return;
                }

                if (Rotation.CheckTargetAura((int)Auras.FrostFever) &&
                    Rotation.CheckTargetAura((int)Auras.BloodPlague))
                {
                    if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueLeech))
                    {             
                        if (Rotation.CheckRuneCount() < 4)
                        {
                            Rotation.CastSpell((int)Spells.PlagueLeech, 1, 0, 0);
                            return;
                        }
                    }
                }
                else
                {
                    if (!Rotation.CheckTargetAura((int)Auras.FrostFever) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak) ||
                        !Rotation.CheckTargetAura((int)Auras.BloodPlague) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak))
                    {
                        Rotation.CastSpell((int)Spells.Outbreak, 1, 0, 0);
                        return;
                    }

                    if (!Rotation.CheckTargetAura((int)Auras.BloodPlague) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueStrike))
                    {
                        Rotation.CastSpell((int)Spells.PlagueStrike, 1, 0, 0);
                        return;
                    }
                }

                //Soul Reaper if Target Health below 45%
                if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.SoulReaper) && ObjectManager.Target.HealthPercent < 46) &&
                    ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 90)
                {
                    Rotation.CastSpell((int)Spells.SoulReaper, 1, 0, 0);
                    return;
                }

                // DarkT
                if (Rotation.CheckPlayerAuraStacks((int)Auras.Shadow) > 4 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DarkT))
                {
                    Rotation.CastSpell((int)Spells.DarkT, 1, 0, 0);
                    return;
                }

                if (Rotation.CheckPlayerAura((int)Auras.SDoom))
                {
                    Rotation.CastSpell((int)Spells.DeathCoil, 0, 0, 0);
                    return;
                }

                // Death Coil
                if (ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) >= 88 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DeathCoil))
                {
                    Rotation.CastSpell((int)Spells.DeathCoil, 0, 0, 0);
                    return;
                }

                // Scourge Strike
                if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.ScourgeStrike)) && ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 88)
                {
                    Rotation.CastSpell((int)Spells.ScourgeStrike, 1, 0, 0);
                    return;
                }

                // Festering Strike
                if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FesteringStrike)) && ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 80)
                {
                    Rotation.CastSpell((int)Spells.FesteringStrike, 1, 0, 0);
                    return;
                }
                Anthrax.AI.Controllers.Spell.AttackTarget();
            }

            if (time > 25000)

            {

                if (Rotation.CheckTargetAura((int)Auras.BloodPlague) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueStrike) && Rotation.CheckTargetAuraDuration((int)Auras.BloodPlague) < 3000)
                {
                    Rotation.CastSpell((int)Spells.PlagueStrike, 1, 0, 0);
                    return;
                }

                if (Rotation.CheckTargetAura((int)Auras.FrostFever) &&
                    Rotation.CheckTargetAura((int)Auras.BloodPlague))
                {
                    if (Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueLeech))
                    {
                        if (Rotation.CheckRuneCount() < 4)
                        {
                            Rotation.CastSpell((int)Spells.PlagueLeech, 1, 0, 0);
                            return;
                        }
                    }
                }
                else
                {
                    if (!Rotation.CheckTargetAura((int)Auras.FrostFever) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak) ||
                        !Rotation.CheckTargetAura((int)Auras.BloodPlague) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.Outbreak))
                    {
                        Rotation.CastSpell((int)Spells.Outbreak, 1, 0, 0);
                        return;
                    }

                    if (!Rotation.CheckTargetAura((int)Auras.BloodPlague) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.PlagueStrike))
                    {
                        Rotation.CastSpell((int)Spells.PlagueStrike, 1, 0, 0);
                        return;
                    }
                }

                //Soul Reaper if Target Health below 45%
                if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.SoulReaper) && ObjectManager.Target.HealthPercent < 46) &&
                    ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 90)
                {
                    Rotation.CastSpell((int)Spells.SoulReaper, 1, 0, 0);
                    return;
                }

                // DarkT
                if (Rotation.CheckPlayerAuraStacks((int)Auras.Shadow) > 4 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DarkT))
                {
                    Rotation.CastSpell((int)Spells.DarkT, 1, 0, 0);
                    return;
                }

                if (Rotation.CheckPlayerAura((int)Auras.SDoom))
                {
                    Rotation.CastSpell((int)Spells.DeathCoil, 0, 0, 0);
                    return;
                }

                // Death Coil
                if ((ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) >= 61 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DeathCoil)) ||
                    (Rotation.CheckPlayerAura((int)Auras.Shadow) && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.DeathCoil)))
                {
                    Rotation.CastSpell((int)Spells.DeathCoil, 0, 0, 0);
                    return;
                }

                // Scourge Strike
                if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.ScourgeStrike)) && ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 88)
                {
                    Rotation.CastSpell((int)Spells.ScourgeStrike, 1, 0, 0);
                    return;
                }

                // Festering Strike
                if ((Anthrax.AI.Controllers.Spell.CanCast((int)Spells.FesteringStrike)) && ObjectManager.LocalPlayer.GetPowerPercent(WowUnit.WowPowerType.RunicPower) <= 80)
                {
                    Rotation.CastSpell((int)Spells.FesteringStrike, 1, 0, 0);
                    return;
                }

                if (Rotation.CheckPlayerAuraStacks((int)Auras.BloodTap) >= 5 && Anthrax.AI.Controllers.Spell.CanCast((int)Spells.BloodTap) && Rotation.CheckRuneCount() <= 4)
                {
                    Rotation.CastSpell((int)Spells.BloodTap, 0, 0, 0);
                    return;
                }

                Anthrax.AI.Controllers.Spell.AttackTarget();
            }
        }

        internal static void DoCombatDeathKnightUnholy3AOE()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightBlood1()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDeathKnightBlood1Single();
                    break;
                case true:
                    DoCombatDeathKnightBlood1AOE();
                    break;
            }

        }

        internal static void DoCombatDeathKnightBlood2()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDeathKnightBlood2Single();
                    break;
                case true:
                    DoCombatDeathKnightBlood2AOE();
                    break;
            }

        }

        internal static void DoCombatDeathKnightBlood3()
        {
            switch (Rotation.isAOE)
            {
                case false:
                    DoCombatDeathKnightBlood3Single();
                    break;
                case true:
                    DoCombatDeathKnightBlood3AOE();
                    break;
            }

        }

        internal static void DoCombatDeathKnightBlood1Single()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightBlood1AOE()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightBlood2Single()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightBlood2AOE()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightBlood3Single()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        internal static void DoCombatDeathKnightBlood3AOE()
        {
            Anthrax.WoW.Logger.WriteLine("To be build!");
        }

        //Choose Spec Rotation
        internal static void DoDeathKnight()
        {

            if (DetectKeyPress.GetKeyState(DetectKeyPress.VK_XBUTTON1) < 0)
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
            }


            switch (ObjectManager.LocalPlayer.Specialization)
            {
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.DeathknightFrost:
                    DoDeathKnightFrost();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.DeathknightUnholy:
                    DoDeathKnightUnholy();
                    break;
                case Anthrax.WoW.Classes.ObjectManager.WowPlayer.WowSpecialization.DeathknightBlood:
                    DoDeathKnightBlood();
                    break;
            }

        }

        internal static void DoDeathKnightBlood()
        {

            /*Init.CheckTierDeathKnight();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                DeathKnight.DoCombatDeathKnightUnholy();
                return;
            }
            DeathKnight.DoPreCombatDeathKnightBlood();
            */
        }

        internal static void DoDeathKnightFrost()
        {
            Init.CheckTierDeathKnight();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                DeathKnight.DoCombatDeathKnightFrost();
                return;
            }
            DeathKnight.DoPreCombatDeathKnight();
        }

        internal static void DoDeathKnightUnholy()
        {
            Init.CheckTierDeathKnight();
            if (ObjectManager.LocalPlayer.InCombat)
            {
                DeathKnight.DoCombatDeathKnightUnholy();
                return;
            }
            DeathKnight.DoPreCombatDeathKnight();
        }

        internal static void DoPreCombatDeathKnight()
        {
            // Check Horn of Winter
            if (Rotation.CheckPlayerAuraDuration(57330) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(57330))
            {
                return;
            }
            Rotation.CastSpell(57330, 0, 0, 1);
        }

        internal static void DoPreCombatDeathKnightBlood()
        {
            // Check Horn of Winter
            if (Rotation.CheckPlayerAuraDuration(20925) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(57330))
            {
                return;
            }
            Rotation.CastSpell(57330, 1, 0, 0);

            // Check Shield of Bones
            if (Rotation.CheckPlayerAuraDuration(20925) >= 3000 || !Anthrax.AI.Controllers.Spell.CanCast(57330))
            {
                return;
            }
            Rotation.CastSpell(57330, 1, 0, 0);
        }


    }
}