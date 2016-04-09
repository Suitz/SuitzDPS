using Anthrax;
using Anthrax.WoW;
using Anthrax.WoW.Classes;
using Anthrax.WoW.Classes.ObjectManager;
using Anthrax.WoW.Internals;
using SuitzDPS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace SuitzDPS.Helpers
{
    internal class Rotation
    {
        public static bool isAOE;


        public Rotation()
        {
        }
        
        internal static void CastSpell(int spellId, int gcd, int facingAngle = 90, int checkfacing = 0)
        {
            if (gcd == 1)
            {
                if (facingAngle > 0 && checkfacing == 1)
                {
                    if (CheckFacingTarget(facingAngle))
                    {
                        while (Cooldown.IsGlobalCooldownActive) { System.Threading.Thread.Sleep(10); }
                        ActionBar.ExecuteSpell(spellId);
                        return;
                    }

                }
                else
                {
                    while (Cooldown.IsGlobalCooldownActive) { System.Threading.Thread.Sleep(10); }
                    ActionBar.ExecuteSpell(spellId);
                    return;
                }
            }


            if (gcd == 0)
            {
                if (facingAngle > 0 && checkfacing == 1)
                {
                    if (CheckFacingTarget(facingAngle))
                    {
                        ActionBar.ExecuteSpell(spellId);
                        return;
                    }
                }
                else
                {
                    ActionBar.ExecuteSpell(spellId);
                    return;
                }
            }

            //Rotation.CheckSpell(spellId));

        }

        internal static void ChangeRotation()
        {
            if (isAOE)
            {
                Console.Beep(5000, 100);
                isAOE = false;
                Anthrax.WoW.Logger.WriteLine("Rotation Single!!");
            }
            else
            {
                Console.Beep(5000, 100);
                Console.Beep(5000, 100);
                Console.Beep(5000, 100);
                isAOE = true;
                Anthrax.WoW.Logger.WriteLine("Rotation AOE!!");
            }
        }

        internal static bool CheckBloodLust()
        {
            if (!Rotation.CheckPlayerAura(32182) && !Rotation.CheckPlayerAura(2825) && !Rotation.CheckPlayerAura(80353) && !Rotation.CheckPlayerAura(160452) && !Rotation.CheckPlayerAura(90355))
            {
                return false;
            }
            return true;
        }

        internal static bool CheckFacingTarget(double angle)
        {
            double num = Math.Atan2((double)(ObjectManager.Target.Position.Y - ObjectManager.LocalPlayer.Position.Y), (double)(ObjectManager.Target.Position.X - ObjectManager.LocalPlayer.Position.X)) - Math.Atan2(Math.Sin((double)ObjectManager.LocalPlayer.Heading + 3.14159265358979), Math.Cos((double)ObjectManager.LocalPlayer.Heading + 3.14159265358979));
            num = Math.Abs((num - Math.Floor((num + 3.14159265358979) / 6.28318530717959) * 6.28318530717959 - 3.14159265358979) * 57.2957795130823);
            num = (num > 180 ? 360 - num : num);
            if (num < angle)
            {
                return true;
            }
            return false;
        }

        internal static bool CheckPlayerAura(int spellId)
        {
            if (ObjectManager.LocalPlayer.HasAuraById(spellId))
            {
                return true;
            }
            return false;
        }

        internal static int CheckPlayerAuraDuration(int spellId)
        {
            int timeLeft = 0;
            if (ObjectManager.LocalPlayer.HasAuraById(spellId))
            {
                timeLeft = ObjectManager.LocalPlayer.Auras.First<WowUnitAura>((WowUnitAura aura) =>
                {
                    if (aura.SpellId != spellId)
                    {
                        return false;
                    }
                    return aura.Duration > 0;
                }).TimeLeft;
            }
            return timeLeft;
        }

        internal static int CheckPlayerAuraStacks(int spellId)
        {
            if (!ObjectManager.LocalPlayer.HasAuraById(spellId))
            {
                return 0;
            }
            return ObjectManager.LocalPlayer.Auras.First<WowUnitAura>((WowUnitAura aura) =>
            {
                if (aura.SpellId != spellId)
                {
                    return false;
                }
                return aura.Duration > 0;
            }).StackCount;
        }

        internal static bool CheckSpellBook(int spellId)
        {
            if (SpellBook.KnownSpells.Where<WowSpell>((WowSpell a) =>
            {
                if (!a.IsValid)
                {
                    return false;
                }
                return a.SpellId == spellId;
            }).ToList<WowSpell>().Count > 0)
            {
                return true;
            }
            return false;
        }

        internal static bool CheckTargetAura(int spellId)
        {
            if (ObjectManager.Target.HasAuraById(spellId) && ObjectManager.Target.Auras.Any<WowUnitAura>((WowUnitAura aura) =>
            {
                if (aura.SpellId != spellId || !(aura.CasterGUID == ObjectManager.LocalPlayer.GUID))
                {
                    return false;
                }
                return aura.Duration > 0;
            }))
            {
                return true;
            }
            return false;
        }

        internal static int CheckRuneCount()
        {
            int runes;
            runes = 0;

            runes += ObjectManager.LocalPlayer.GetReadyRuneCountByType(WowLocalPlayer.WowRuneType.Blood);
            runes += ObjectManager.LocalPlayer.GetReadyRuneCountByType(WowLocalPlayer.WowRuneType.Frost);
            runes += ObjectManager.LocalPlayer.GetReadyRuneCountByType(WowLocalPlayer.WowRuneType.Unholy);
            runes += ObjectManager.LocalPlayer.GetReadyRuneCountByType(WowLocalPlayer.WowRuneType.Death);
            return runes;
        }

        internal static int CheckTargetAuraDuration(int spellId)
        {
            int timeLeft = 0;
            if (ObjectManager.Target.HasAuraById(spellId) && ObjectManager.Target.Auras.Any<WowUnitAura>((WowUnitAura aura) =>
            {
                if (aura.SpellId != spellId || !(aura.CasterGUID == ObjectManager.LocalPlayer.GUID))
                {
                    return false;
                }
                return aura.Duration > 0;
            }))
            {
                timeLeft = ObjectManager.Target.Auras.First<WowUnitAura>((WowUnitAura aura) =>
                {
                    if (aura.SpellId != spellId || !(aura.CasterGUID == ObjectManager.LocalPlayer.GUID))
                    {
                        return false;
                    }
                    return aura.Duration > 0;
                }).TimeLeft;
            }
            return timeLeft;
        }

        internal static int CheckTargetAuraStacks(int spellId)
        {
            if (!ObjectManager.Target.HasAuraById(spellId) || !ObjectManager.Target.Auras.Any<WowUnitAura>((WowUnitAura aura) =>
            {
                if (aura.SpellId != spellId || !(aura.CasterGUID == ObjectManager.LocalPlayer.GUID))
                {
                    return false;
                }
                return aura.Duration > 0;
            }))
            {
                return 0;
            }
            return ObjectManager.Target.Auras.First<WowUnitAura>((WowUnitAura aura) =>
            {
                if (aura.SpellId != spellId || !(aura.CasterGUID == ObjectManager.LocalPlayer.GUID))
                {
                    return false;
                }
                return aura.Duration > 0;
            }).StackCount;
        }

        internal static bool UnitIsAlliance(WowUnit unit)
        {
            int factionTemplate = unit.FactionTemplate;
            if (factionTemplate > 115)
            {
                if (factionTemplate == 1629)
                {
                    return true;
                }
                if (factionTemplate == 2203)
                {
                    return true;
                }
                if (factionTemplate == 2401)
                {
                    return true;
                }
            }
            else
            {
                switch (factionTemplate)
                {
                    case 1:
                        {
                            return true;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            return true;
                        }
                    case 4:
                        {
                            return true;
                        }
                    default:
                        {
                            if (factionTemplate == 115)
                            {
                                return true;
                            }
                            break;
                        }
                }
            }
            return false;
        }

        internal static bool UnitIsHorde(WowUnit unit)
        {
            int factionTemplate = unit.FactionTemplate;
            if (factionTemplate > 116)
            {
                if (factionTemplate == 1610)
                {
                    return true;
                }
                if (factionTemplate == 2204)
                {
                    return true;
                }
                if (factionTemplate == 2402)
                {
                    return true;
                }
            }
            else
            {
                switch (factionTemplate)
                {
                    case 2:
                        {
                            return true;
                        }
                    case 3:
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            return true;
                        }
                    case 6:
                        {
                            return true;
                        }
                    default:
                        {
                            if (factionTemplate == 116)
                            {
                                return true;
                            }
                            break;
                        }
                }
            }
            return false;
        }

        internal static bool UnitIsNotPlayer(WowUnit unit)
        {
            if (!Rotation.UnitIsAlliance(unit) && !Rotation.UnitIsHorde(unit))
            {
                return true;
            }
            return false;
        }

    }
}