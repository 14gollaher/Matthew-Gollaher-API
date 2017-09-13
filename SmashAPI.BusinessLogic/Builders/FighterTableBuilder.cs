using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace WiiUSmash4.BusinessLogic
{
    public static class FighterTableBuilder
    {
        public static DataTable BuildAerialTable(int fighterId, Aerial aerial)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn(DatabaseDefines.Aerial_Name));
            table.Columns.Add(new DataColumn(DatabaseDefines.Aerial_HitboxActiveRange));
            table.Columns.Add(new DataColumn(DatabaseDefines.Aerial_BaseDamage));
            table.Columns.Add(new DataColumn(DatabaseDefines.Aerial_ShieldDamage));
            table.Columns.Add(new DataColumn(DatabaseDefines.Aerial_Angle));
            table.Columns.Add(new DataColumn(DatabaseDefines.Aerial_BaseKnockBack));
            table.Columns.Add(new DataColumn(DatabaseDefines.Aerial_WeightBaseKnockBack));
            table.Columns.Add(new DataColumn(DatabaseDefines.Aerial_KnockBackGrowth));
            table.Columns.Add(new DataColumn(DatabaseDefines.Aerial_LandingLag));
            table.Columns.Add(new DataColumn(DatabaseDefines.Aerial_AutoCancelFrames));
            table.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow row = table.NewRow();
            row[DatabaseDefines.Aerial_Name] = aerial.Name;
            row[DatabaseDefines.Aerial_HitboxActiveRange] = aerial.HitboxActiveRange;
            row[DatabaseDefines.Aerial_BaseDamage] = aerial.BaseDamage;
            row[DatabaseDefines.Aerial_ShieldDamage] = aerial.ShieldDamage;
            row[DatabaseDefines.Aerial_Angle] = aerial.Angle;
            row[DatabaseDefines.Aerial_BaseKnockBack] = aerial.BaseKnockBack;
            row[DatabaseDefines.Aerial_WeightBaseKnockBack] = aerial.WeightBaseKnockBack;
            row[DatabaseDefines.Aerial_KnockBackGrowth] = aerial.KnockBackGrowth;
            row[DatabaseDefines.Aerial_LandingLag] = aerial.LandingLag;
            row[DatabaseDefines.Aerial_AutoCancelFrames] = aerial.AutoCancelFrames;
            row[DatabaseDefines.Fighter_Id] = fighterId;
            table.Rows.Add(row);

            return table;
        }
        public static DataTable BuildAttackTable(int fighterId, Attack attack)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn(DatabaseDefines.Attack_Name));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attack_HitboxActiveRange));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attack_FirstActionableFrame));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attack_BaseDamage));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attack_ShieldDamage));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attack_Angle));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attack_BaseKnockBack));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attack_WeightBaseKnockBack));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attack_KnockBackGrowth));
            table.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow row = table.NewRow();
            row[DatabaseDefines.Attack_Name] = attack.Name;
            row[DatabaseDefines.Attack_HitboxActiveRange] = attack.HitboxActiveRange;
            row[DatabaseDefines.Attack_FirstActionableFrame] = attack.FirstActionableFrame;
            row[DatabaseDefines.Attack_BaseDamage] = attack.BaseDamage;
            row[DatabaseDefines.Attack_ShieldDamage] = attack.ShieldDamage;
            row[DatabaseDefines.Attack_Angle] = attack.Angle;
            row[DatabaseDefines.Attack_BaseKnockBack] = attack.BaseKnockBack;
            row[DatabaseDefines.Attack_WeightBaseKnockBack] = attack.WeightBaseKnockBack;
            row[DatabaseDefines.Attack_KnockBackGrowth] = attack.KnockBackGrowth;
            row[DatabaseDefines.Fighter_Id] = fighterId;
            table.Rows.Add(row);

            return table;
        }
        public static DataTable BuildAttributesTable(int fighterId, Attributes attributes)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_Weight));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WeightRank));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_RunSpeed));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_RunSpeedRank));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WalkSpeed));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WalkSpeedRank));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_AirSpeed));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_AirSpeedRank));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_FallSpeed));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_FallSpeedRank));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_AirAcceleration));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_Gravity));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_ShortHopAirTimeFrames));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_FastFallSpeed));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_FastFallSpeedRank));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_MaximumJumps));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WallJump));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WallCling));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_Crawl));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_Tether));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_JumpSquatFrames));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_SoftLandingLagFrames));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_HardLandingLagFrames));
            table.Columns.Add(new DataColumn(DatabaseDefines.Attributes_FullHopAirTimeFrames));
            table.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow row = table.NewRow();
            row[DatabaseDefines.Attributes_Weight] = attributes.Weight;
            row[DatabaseDefines.Attributes_WeightRank] = attributes.WeightRank;
            row[DatabaseDefines.Attributes_RunSpeed] = attributes.RunSpeed;
            row[DatabaseDefines.Attributes_RunSpeedRank] = attributes.RunSpeedRank;
            row[DatabaseDefines.Attributes_WalkSpeed] = attributes.WalkSpeed;
            row[DatabaseDefines.Attributes_WalkSpeedRank] = attributes.WalkSpeedRank;
            row[DatabaseDefines.Attributes_AirSpeed] = attributes.AirSpeed;
            row[DatabaseDefines.Attributes_AirSpeedRank] = attributes.AirSpeedRank;
            row[DatabaseDefines.Attributes_FallSpeed] = attributes.FallSpeed;
            row[DatabaseDefines.Attributes_FallSpeedRank] = attributes.FallSpeedRank;
            row[DatabaseDefines.Attributes_AirAcceleration] = attributes.AirAcceleration;
            row[DatabaseDefines.Attributes_Gravity] = attributes.Gravity;
            row[DatabaseDefines.Attributes_ShortHopAirTimeFrames] = attributes.ShortHopAirTimeFrames;
            row[DatabaseDefines.Attributes_FastFallSpeed] = attributes.FastFallSpeed;
            row[DatabaseDefines.Attributes_FastFallSpeedRank] = attributes.FastFallSpeedRank;
            row[DatabaseDefines.Attributes_MaximumJumps] = attributes.MaximumJumps;
            row[DatabaseDefines.Attributes_WallJump] = attributes.WallJump;
            row[DatabaseDefines.Attributes_WallCling] = attributes.WallCling;
            row[DatabaseDefines.Attributes_Crawl] = attributes.Crawl;
            row[DatabaseDefines.Attributes_Tether] = attributes.Tether;
            row[DatabaseDefines.Attributes_JumpSquatFrames] = attributes.JumpSquatFrames;
            row[DatabaseDefines.Attributes_SoftLandingLagFrames] = attributes.SoftLandingLagFrames;
            row[DatabaseDefines.Attributes_HardLandingLagFrames] = attributes.HardLandingLagFrames;
            row[DatabaseDefines.Attributes_FullHopAirTimeFrames] = attributes.FullHopAirTimeFrames;
            row[DatabaseDefines.Fighter_Id] = fighterId;
            table.Rows.Add(row);

            return table;
        }

        public static DataTable BuildFighterPartialTable(Fighter fighter)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Name));
            table.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Title));
            table.Columns.Add(new DataColumn(DatabaseDefines.Fighter_PortraitPictureUrl));

            DataRow row = table.NewRow();
            row[DatabaseDefines.Fighter_Name] = fighter.Name;
            row[DatabaseDefines.Fighter_Title] = fighter.Title;
            row[DatabaseDefines.Fighter_PortraitPictureUrl] = fighter.PortraitPictureUrl;
            table.Rows.Add(row);

            return table;
        }

        public static DataTable BuildGrabTable(int fighterId, Grab grab)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn(DatabaseDefines.Grab_Name));
            table.Columns.Add(new DataColumn(DatabaseDefines.Grab_HitBoxActiveRange));
            table.Columns.Add(new DataColumn(DatabaseDefines.Grab_FirstActionableFrame));
            table.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow row = table.NewRow();
            row[DatabaseDefines.Grab_Name] = grab.Name;
            row[DatabaseDefines.Grab_HitBoxActiveRange] = grab.HitboxActiveRange;
            row[DatabaseDefines.Grab_FirstActionableFrame] = grab.FirstActionableFrame;
            row[DatabaseDefines.Fighter_Id] = fighterId;
            table.Rows.Add(row);

            return table;
        }
        public static DataTable BuildRollTable(int fighterId, Roll roll)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn(DatabaseDefines.Roll_Name));
            table.Columns.Add(new DataColumn(DatabaseDefines.Roll_Intangibility));
            table.Columns.Add(new DataColumn(DatabaseDefines.Roll_FirstActionableFrame));
            table.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow row = table.NewRow();
            row[DatabaseDefines.Roll_Name] = roll.Name;
            row[DatabaseDefines.Roll_Intangibility] = roll.Intangibility;
            row[DatabaseDefines.Roll_FirstActionableFrame] = roll.FirstActionableFrame;
            row[DatabaseDefines.Fighter_Id] = fighterId;
            table.Rows.Add(row);

            return table;
        }
        public static DataTable BuildSpecialTable(int fighterId, Special special)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn(DatabaseDefines.Special_Name));
            table.Columns.Add(new DataColumn(DatabaseDefines.Special_HitboxActiveRange));
            table.Columns.Add(new DataColumn(DatabaseDefines.Special_FirstActionableFrame));
            table.Columns.Add(new DataColumn(DatabaseDefines.Special_BaseDamage));
            table.Columns.Add(new DataColumn(DatabaseDefines.Special_ShieldDamage));
            table.Columns.Add(new DataColumn(DatabaseDefines.Special_Angle));
            table.Columns.Add(new DataColumn(DatabaseDefines.Special_BaseKnockBack));
            table.Columns.Add(new DataColumn(DatabaseDefines.Special_WeightBaseKnockBack));
            table.Columns.Add(new DataColumn(DatabaseDefines.Special_KnockBackGrowth));
            table.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow row = table.NewRow();
            row[DatabaseDefines.Special_Name] = special.Name;
            row[DatabaseDefines.Special_HitboxActiveRange] = special.HitboxActiveRange;
            row[DatabaseDefines.Special_FirstActionableFrame] = special.FirstActionableFrame;
            row[DatabaseDefines.Special_BaseDamage] = special.BaseDamage;
            row[DatabaseDefines.Special_ShieldDamage] = special.ShieldDamage;
            row[DatabaseDefines.Special_Angle] = special.Angle;
            row[DatabaseDefines.Special_BaseKnockBack] = special.BaseKnockBack;
            row[DatabaseDefines.Special_WeightBaseKnockBack] = special.WeightBaseKnockBack;
            row[DatabaseDefines.Special_KnockBackGrowth] = special.KnockBackGrowth;
            row[DatabaseDefines.Fighter_Id] = fighterId;
            table.Rows.Add(row);

            return table;
        }
        public static DataTable BuildThrowTable(int fighterId, Throw throwAbility)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn(DatabaseDefines.Throw_Name));
            table.Columns.Add(new DataColumn(DatabaseDefines.Throw_BaseDamage));
            table.Columns.Add(new DataColumn(DatabaseDefines.Throw_ShieldDamage)); 
            table.Columns.Add(new DataColumn(DatabaseDefines.Throw_Angle));
            table.Columns.Add(new DataColumn(DatabaseDefines.Throw_BaseKnockBack));
            table.Columns.Add(new DataColumn(DatabaseDefines.Throw_KnockBackGrowth));
            table.Columns.Add(new DataColumn(DatabaseDefines.Fighter_Id));

            DataRow row = table.NewRow();
            row[DatabaseDefines.Throw_Name] = throwAbility.Name;
            row[DatabaseDefines.Throw_BaseDamage] = throwAbility.BaseDamage;
            row[DatabaseDefines.Throw_ShieldDamage] = throwAbility.ShieldDamage; 
            row[DatabaseDefines.Throw_Angle] = throwAbility.Angle;
            row[DatabaseDefines.Throw_BaseKnockBack] = throwAbility.BaseKnockBack;
            row[DatabaseDefines.Throw_KnockBackGrowth] = throwAbility.KnockBackGrowth;
            row[DatabaseDefines.Fighter_Id] = fighterId;
            table.Rows.Add(row);

            return table;
        }
        public static DataTable BuildAbilityFrameTable(List<string> abilityFramePictureUrls)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn(DatabaseDefines.AbilityFramePicture_PictureUrl));

            Parallel.ForEach(abilityFramePictureUrls, item =>
            {
                DataRow row = table.NewRow();
                row[DatabaseDefines.AbilityFramePicture_PictureUrl] = item;
                table.Rows.Add(row);
            });

            return table;
        }
    }
}
