using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WiiUSmash4.BusinessLogic
{
    public static class FighterTableBuilder
    {
        public static DataTable BuildAerialTable(int fighterId, Aerial aerial)
        {
            DataTable aerialTable = new DataTable();
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Aerial_Name));
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Aerial_HitboxActiveRange));
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Aerial_BaseDamage));
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Aerial_ShieldDamage));
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Aerial_Angle));
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Aerial_BaseKnockBack));
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Aerial_WeightBaseKnockBack));
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Aerial_KnockBackGrowth));
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Aerial_LandingLag));
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Aerial_AutoCancelFrames));
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow aerialRow = aerialTable.NewRow();
            aerialRow[DatabaseDefines.Aerial_Name] = aerial.Name;
            aerialRow[DatabaseDefines.Aerial_HitboxActiveRange] = aerial.HitboxActiveRange;
            aerialRow[DatabaseDefines.Aerial_BaseDamage] = aerial.BaseDamage;
            aerialRow[DatabaseDefines.Aerial_ShieldDamage] = aerial.ShieldDamage;
            aerialRow[DatabaseDefines.Aerial_Angle] = aerial.Angle;
            aerialRow[DatabaseDefines.Aerial_BaseKnockBack] = aerial.BaseKnockBack;
            aerialRow[DatabaseDefines.Aerial_WeightBaseKnockBack] = aerial.WeightBaseKnockBack;
            aerialRow[DatabaseDefines.Aerial_KnockBackGrowth] = aerial.KnockBackGrowth;
            aerialRow[DatabaseDefines.Aerial_LandingLag] = aerial.LandingLag;
            aerialRow[DatabaseDefines.Aerial_AutoCancelFrames] = aerial.AutoCancelFrames;
            aerialRow[DatabaseDefines.Fighter_Id] = fighterId;
            aerialTable.Rows.Add(aerialRow);

            return aerialTable;
        }
        public static DataTable BuildAttackTable(int fighterId, Attack attack)
        {
            DataTable attackTable = new DataTable();
            attackTable.Columns.Add(new DataColumn(DatabaseDefines.Attack_Name));
            attackTable.Columns.Add(new DataColumn(DatabaseDefines.Attack_HitboxActiveRange));
            attackTable.Columns.Add(new DataColumn(DatabaseDefines.Attack_FirstActionableFrame));
            attackTable.Columns.Add(new DataColumn(DatabaseDefines.Attack_BaseDamage));
            attackTable.Columns.Add(new DataColumn(DatabaseDefines.Attack_ShieldDamage));
            attackTable.Columns.Add(new DataColumn(DatabaseDefines.Attack_Angle));
            attackTable.Columns.Add(new DataColumn(DatabaseDefines.Attack_BaseKnockBack));
            attackTable.Columns.Add(new DataColumn(DatabaseDefines.Attack_WeightBaseKnockBack));
            attackTable.Columns.Add(new DataColumn(DatabaseDefines.Attack_KnockBackGrowth));

            DataRow attackRow = attackTable.NewRow();
            attackRow[DatabaseDefines.Attack_Name] = attack.Name;
            attackRow[DatabaseDefines.Attack_HitboxActiveRange] = attack.HitboxActiveRange;
            attackRow[DatabaseDefines.Attack_FirstActionableFrame] = attack.FirstActionableFrame;
            attackRow[DatabaseDefines.Attack_BaseDamage] = attack.BaseDamage;
            attackRow[DatabaseDefines.Attack_ShieldDamage] = attack.ShieldDamage;
            attackRow[DatabaseDefines.Attack_Angle] = attack.Angle;
            attackRow[DatabaseDefines.Attack_BaseKnockBack] = attack.BaseKnockBack;
            attackRow[DatabaseDefines.Attack_WeightBaseKnockBack] = attack.WeightBaseKnockBack;
            attackRow[DatabaseDefines.Attack_KnockBackGrowth] = attack.KnockBackGrowth;
            attackTable.Rows.Add(attackRow);

            return attackTable;
        }
        public static DataTable BuildAttributesTable(int fighterId, Attributes attributes)
        {
            DataTable attributesTable = new DataTable();
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_Weight));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WeightRank));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_RunSpeed));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_RunSpeedRank));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WalkSpeed));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WalkSpeedRank));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_AirSpeed));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_AirSpeedRank));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_FallSpeed));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_FallSpeedRank));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_AirAcceleration));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_Gravity));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_ShortHopAirTimeFrames));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_FastFallSpeed));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_FastFallSpeedRank));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_MaximumJumps));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WallJump));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WallCling));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_Crawl));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_Tether));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_JumpSquatFrames));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_SoftLandingLagFrames));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_HardLandingLagFrames));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_FullHopAirTimeFrames));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow attributeRow = attributesTable.NewRow();
            attributeRow[DatabaseDefines.Attributes_Weight] = attributes.Weight;
            attributeRow[DatabaseDefines.Attributes_WeightRank] = attributes.WeightRank;
            attributeRow[DatabaseDefines.Attributes_RunSpeed] = attributes.RunSpeed;
            attributeRow[DatabaseDefines.Attributes_RunSpeedRank] = attributes.RunSpeedRank;
            attributeRow[DatabaseDefines.Attributes_WalkSpeed] = attributes.WalkSpeed;
            attributeRow[DatabaseDefines.Attributes_WalkSpeedRank] = attributes.WalkSpeedRank;
            attributeRow[DatabaseDefines.Attributes_AirSpeed] = attributes.AirSpeed;
            attributeRow[DatabaseDefines.Attributes_AirSpeedRank] = attributes.AirSpeedRank;
            attributeRow[DatabaseDefines.Attributes_FallSpeed] = attributes.FallSpeed;
            attributeRow[DatabaseDefines.Attributes_FallSpeedRank] = attributes.FallSpeedRank;
            attributeRow[DatabaseDefines.Attributes_AirAcceleration] = attributes.AirAcceleration;
            attributeRow[DatabaseDefines.Attributes_Gravity] = attributes.Gravity;
            attributeRow[DatabaseDefines.Attributes_ShortHopAirTimeFrames] = attributes.ShortHopAirTimeFrames;
            attributeRow[DatabaseDefines.Attributes_FastFallSpeed] = attributes.FastFallSpeed;
            attributeRow[DatabaseDefines.Attributes_FastFallSpeedRank] = attributes.FastFallSpeedRank;
            attributeRow[DatabaseDefines.Attributes_MaximumJumps] = attributes.MaximumJumps;
            attributeRow[DatabaseDefines.Attributes_WallJump] = attributes.WallJump;
            attributeRow[DatabaseDefines.Attributes_WallCling] = attributes.WallCling;
            attributeRow[DatabaseDefines.Attributes_Crawl] = attributes.Crawl;
            attributeRow[DatabaseDefines.Attributes_Tether] = attributes.Tether;
            attributeRow[DatabaseDefines.Attributes_JumpSquatFrames] = attributes.JumpSquatFrames;
            attributeRow[DatabaseDefines.Attributes_SoftLandingLagFrames] = attributes.SoftLandingLagFrames;
            attributeRow[DatabaseDefines.Attributes_HardLandingLagFrames] = attributes.HardLandingLagFrames;
            attributeRow[DatabaseDefines.Attributes_FullHopAirTimeFrames] = attributes.FullHopAirTimeFrames;
            attributeRow[DatabaseDefines.Fighter_Id] = fighterId;
            attributesTable.Rows.Add(attributeRow);

            return attributesTable;
        }

        public static DataTable BuildFighterTable(Fighter fighter)
        {
            DataTable fighterTable = new DataTable();
            fighterTable.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Name));
            fighterTable.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Title));
            fighterTable.Columns.Add(new DataColumn(DatabaseDefines.Fighter_PortraitPictureUrl));

            DataRow fighterRow = fighterTable.NewRow();
            fighterRow[DatabaseDefines.Fighter_Name] = fighter.Name;
            fighterRow[DatabaseDefines.Fighter_Title] = fighter.Title;
            fighterRow[DatabaseDefines.Fighter_PortraitPictureUrl] = fighter.PortraitPictureUrl;
            fighterTable.Rows.Add(fighterRow);

            return fighterTable;
        }
        public static DataTable BuildGrabTable(int fighterId, Grab grab)
        {
            DataTable grabTable = new DataTable();
            grabTable.Columns.Add(new DataColumn(DatabaseDefines.Grab_Name));
            grabTable.Columns.Add(new DataColumn(DatabaseDefines.Grab_HitBoxActiveRange));
            grabTable.Columns.Add(new DataColumn(DatabaseDefines.Grab_FirstActionableFrame));
            grabTable.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow grabRow = grabTable.NewRow();
            grabRow[DatabaseDefines.Grab_Name] = grab.Name;
            grabRow[DatabaseDefines.Grab_HitBoxActiveRange] = grab.HitboxActiveRange;
            grabRow[DatabaseDefines.Grab_FirstActionableFrame] = grab.FirstActionableFrame;
            grabRow[DatabaseDefines.Fighter_Id] = fighterId;
            grabTable.Rows.Add(grabRow);

            return grabTable;
        }
        public static DataTable BuildRollTable(int fighterId, Roll roll)
        {
            DataTable rollTable = new DataTable();
            rollTable.Columns.Add(new DataColumn(DatabaseDefines.Roll_Name));
            rollTable.Columns.Add(new DataColumn(DatabaseDefines.Roll_Intangibility));
            rollTable.Columns.Add(new DataColumn(DatabaseDefines.Roll_FirstActionableFrame));
            rollTable.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow rollRow = rollTable.NewRow();
            rollRow[DatabaseDefines.Roll_Name] = roll.Name;
            rollRow[DatabaseDefines.Roll_Intangibility] = roll.Intangibility;
            rollRow[DatabaseDefines.Roll_FirstActionableFrame] = roll.FirstActionableFrame;
            rollRow[DatabaseDefines.Fighter_Id] = fighterId;
            rollTable.Rows.Add(rollRow);

            return rollTable;
        }
        public static DataTable BuildSpecialTable(int fighterId, Special special)
        {
            DataTable specialTable = new DataTable();
            specialTable.Columns.Add(new DataColumn(DatabaseDefines.Special_Name));
            specialTable.Columns.Add(new DataColumn(DatabaseDefines.Special_HitboxActiveRange));
            specialTable.Columns.Add(new DataColumn(DatabaseDefines.Special_FirstActionableFrame));
            specialTable.Columns.Add(new DataColumn(DatabaseDefines.Special_BaseDamage));
            specialTable.Columns.Add(new DataColumn(DatabaseDefines.Special_ShieldDamage));
            specialTable.Columns.Add(new DataColumn(DatabaseDefines.Special_Angle));
            specialTable.Columns.Add(new DataColumn(DatabaseDefines.Special_BaseKnockBack));
            specialTable.Columns.Add(new DataColumn(DatabaseDefines.Special_WeightBaseKnockBack));
            specialTable.Columns.Add(new DataColumn(DatabaseDefines.Special_KnockBackGrowth));
            specialTable.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow specialRow = specialTable.NewRow();
            specialRow[DatabaseDefines.Special_Name] = special.Name;
            specialRow[DatabaseDefines.Special_HitboxActiveRange] = special.HitboxActiveRange;
            specialRow[DatabaseDefines.Special_FirstActionableFrame] = special.FirstActionableFrame;
            specialRow[DatabaseDefines.Special_BaseDamage] = special.BaseDamage;
            specialRow[DatabaseDefines.Special_ShieldDamage] = special.ShieldDamage;
            specialRow[DatabaseDefines.Special_Angle] = special.Angle;
            specialRow[DatabaseDefines.Special_BaseKnockBack] = special.BaseKnockBack;
            specialRow[DatabaseDefines.Special_WeightBaseKnockBack] = special.WeightBaseKnockBack;
            specialRow[DatabaseDefines.Special_KnockBackGrowth] = special.KnockBackGrowth;
            specialRow[DatabaseDefines.Fighter_Id] = fighterId;
            specialTable.Rows.Add(specialRow);

            return specialTable;
        }
        public static DataTable BuildThrowTable(int fighterId, Throw throwAbility)
        {
            DataTable throwTable = new DataTable();
            throwTable.Columns.Add(new DataColumn(DatabaseDefines.Throw_Name));
            throwTable.Columns.Add(new DataColumn(DatabaseDefines.Throw_BaseDamage));
            throwTable.Columns.Add(new DataColumn(DatabaseDefines.Throw_Angle));
            throwTable.Columns.Add(new DataColumn(DatabaseDefines.Throw_BaseKnockBack));
            throwTable.Columns.Add(new DataColumn(DatabaseDefines.Throw_KnockBackGrowth));
            throwTable.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow throwRow = throwTable.NewRow();
            throwRow[DatabaseDefines.Throw_Name] = throwAbility.Name;
            throwRow[DatabaseDefines.Throw_BaseDamage] = throwAbility.BaseDamage;
            throwRow[DatabaseDefines.Throw_Angle] = throwAbility.Angle;
            throwRow[DatabaseDefines.Throw_BaseKnockBack] = throwAbility.BaseKnockBack;
            throwRow[DatabaseDefines.Throw_KnockBackGrowth] = throwAbility.KnockBackGrowth;
            throwRow[DatabaseDefines.Fighter_Id] = fighterId;
            throwTable.Rows.Add(throwRow);

            return throwTable;
        }
        public static DataTable BuildAbilityFramePictureTable(List<string> abilityFramePictureUrls)
        {
            DataTable abilityFramePictureTable = new DataTable();
            abilityFramePictureTable.Columns.Add(new DataColumn(DatabaseDefines.AbilityFramePicture_PictureUrl));

            foreach (string item in abilityFramePictureUrls)
            {
                DataRow abilityFramePictureRow = abilityFramePictureTable.NewRow();
                abilityFramePictureRow[DatabaseDefines.AbilityFramePicture_PictureUrl] = item;
                abilityFramePictureTable.Rows.Add(abilityFramePictureRow);
            }

            return abilityFramePictureTable;
        }
    }
}
