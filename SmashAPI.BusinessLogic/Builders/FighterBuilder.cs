using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WiiUSmash4.BusinessLogic
{
    public class FighterBuilder
    {
        public static Fighter Build(DataSet dataSet)
        {
            Fighter fighter = BuildFighterPartial(dataSet.Tables[0]);
            fighter.Attributes = BuildAttributes(dataSet.Tables[1]);
            fighter.Aerials = BuildAerials(dataSet.Tables[2]);
            fighter.Attacks = BuildAttacks(dataSet.Tables[3]);
            fighter.Grabs = BuildGrabs(dataSet.Tables[4]);
            fighter.Rolls = BuildRolls(dataSet.Tables[5]);
            fighter.Specials = BuildSpecials(dataSet.Tables[6]);
            fighter.Throws = BuildThrows(dataSet.Tables[7]);

            return fighter;
        }

        public static List<string> BuildAbilityFrameUrls(DataTable table)
        {
            List<string> urls = new List<string>();

            Parallel.ForEach(table.Rows.Cast<DataRow>(), item =>
            {
                String url = Convert.ToString(item[DatabaseDefines.AbilityFramePicture_PictureUrl]);
                urls.Add(url);
            });
            return urls;
        }

        public static List<int> BuildFighterIds(DataTable table)
        {
            List<int> fighterIds = new List<int>();


            Parallel.ForEach(table.Rows.Cast<DataRow>(), item =>
            {
                int id = Convert.ToInt32(item[DatabaseDefines.Fighter_Id]);
                fighterIds.Add(id);
            });
            return fighterIds;
        }

        private static List<Aerial> BuildAerials(DataTable table)
        {
            List<Aerial> aerials = new List<Aerial>();

            Parallel.ForEach(table.Rows.Cast<DataRow>(), item =>
            {
                Aerial aerial = new Aerial
                {
                    Name = Convert.ToString(item[DatabaseDefines.Aerial_Name]),
                    HitboxActiveRange = Convert.ToString(item[DatabaseDefines.Aerial_HitboxActiveRange]),
                    BaseDamage = Convert.ToString(item[DatabaseDefines.Aerial_BaseDamage]),
                    ShieldDamage = Convert.ToString(item[DatabaseDefines.Aerial_ShieldDamage]),
                    Angle = Convert.ToString(item[DatabaseDefines.Aerial_Angle]),
                    BaseKnockBack = Convert.ToString(item[DatabaseDefines.Aerial_BaseKnockBack]),
                    WeightBaseKnockBack = Convert.ToString(item[DatabaseDefines.Aerial_WeightBaseKnockBack]),
                    KnockBackGrowth = Convert.ToString(item[DatabaseDefines.Aerial_KnockBackGrowth]),
                    LandingLag = Convert.ToString(item[DatabaseDefines.Aerial_LandingLag]),
                    AutoCancelFrames = Convert.ToString(item[DatabaseDefines.Aerial_AutoCancelFrames])
                };
                aerials.Add(aerial);
            });
            return aerials;
        }

        private static List<Attack> BuildAttacks(DataTable table)
        {
            List<Attack> attacks = new List<Attack>();

            Parallel.ForEach(table.Rows.Cast<DataRow>(), item =>
            {
                Attack attack = new Attack
                {
                    Name = Convert.ToString(item[DatabaseDefines.Attack_Name]),
                    HitboxActiveRange = Convert.ToString(item[DatabaseDefines.Attack_HitboxActiveRange]),
                    FirstActionableFrame = Convert.ToInt32(item[DatabaseDefines.Attack_FirstActionableFrame]),
                    BaseDamage = Convert.ToString(item[DatabaseDefines.Attack_BaseDamage]),
                    ShieldDamage = Convert.ToString(item[DatabaseDefines.Attack_ShieldDamage]),
                    Angle = Convert.ToString(item[DatabaseDefines.Attack_Angle]),
                    BaseKnockBack = Convert.ToString(item[DatabaseDefines.Attack_BaseKnockBack]),
                    WeightBaseKnockBack = Convert.ToString(item[DatabaseDefines.Attack_WeightBaseKnockBack]),
                    KnockBackGrowth = Convert.ToString(item[DatabaseDefines.Attack_KnockBackGrowth])
                };
                attacks.Add(attack);
            });
            return attacks;
        }

        private static Attributes BuildAttributes(DataTable table)
        {
            Attributes attributes = new Attributes();

            DataRow row = table.Rows[0];
            attributes.Weight = Convert.ToDouble(row[DatabaseDefines.Attributes_Weight]);
            attributes.WeightRank = Convert.ToInt32(row[DatabaseDefines.Attributes_WeightRank]);
            attributes.RunSpeed = Convert.ToDouble(row[DatabaseDefines.Attributes_RunSpeed]);
            attributes.RunSpeedRank = Convert.ToInt32(row[DatabaseDefines.Attributes_RunSpeedRank]);
            attributes.WalkSpeed = Convert.ToDouble(row[DatabaseDefines.Attributes_WalkSpeed]);
            attributes.WalkSpeedRank = Convert.ToInt32(row[DatabaseDefines.Attributes_WalkSpeedRank]);
            attributes.AirSpeed = Convert.ToDouble(row[DatabaseDefines.Attributes_AirSpeed]);
            attributes.AirSpeedRank = Convert.ToInt32(row[DatabaseDefines.Attributes_AirSpeedRank]);
            attributes.FallSpeed = Convert.ToDouble(row[DatabaseDefines.Attributes_FallSpeed]);
            attributes.FallSpeedRank = Convert.ToInt32(row[DatabaseDefines.Attributes_FallSpeedRank]);
            attributes.AirAcceleration = Convert.ToDouble(row[DatabaseDefines.Attributes_AirAcceleration]);
            attributes.Gravity = Convert.ToDouble(row[DatabaseDefines.Attributes_Gravity]);
            attributes.ShortHopAirTimeFrames = Convert.ToInt32(row[DatabaseDefines.Attributes_ShortHopAirTimeFrames]);
            attributes.FastFallSpeed = Convert.ToDouble(row[DatabaseDefines.Attributes_FastFallSpeed]);
            attributes.FastFallSpeedRank = Convert.ToInt32(row[DatabaseDefines.Attributes_FastFallSpeedRank]);
            attributes.MaximumJumps = Convert.ToInt32(row[DatabaseDefines.Attributes_MaximumJumps]);
            attributes.WallJump = Convert.ToBoolean(row[DatabaseDefines.Attributes_WallJump]);
            attributes.WallCling = Convert.ToBoolean(row[DatabaseDefines.Attributes_WallCling]);
            attributes.Crawl = Convert.ToBoolean(row[DatabaseDefines.Attributes_Crawl]);
            attributes.Tether = Convert.ToBoolean(row[DatabaseDefines.Attributes_Tether]);
            attributes.JumpSquatFrames = Convert.ToInt32(row[DatabaseDefines.Attributes_JumpSquatFrames]);
            attributes.SoftLandingLagFrames = Convert.ToInt32(row[DatabaseDefines.Attributes_SoftLandingLagFrames]);
            attributes.HardLandingLagFrames = Convert.ToInt32(row[DatabaseDefines.Attributes_HardLandingLagFrames]);
            attributes.FullHopAirTimeFrames = Convert.ToInt32(row[DatabaseDefines.Attributes_FullHopAirTimeFrames]);

            return attributes;
        }

        private static Fighter BuildFighterPartial(DataTable table)
        {
            Fighter fighter = new Fighter();

            DataRow row = table.Rows[0];
            fighter.Id = Convert.ToInt32(row[DatabaseDefines.Fighter_Id]);
            fighter.Name = Convert.ToString(row[DatabaseDefines.Fighter_Name]);
            fighter.Title = Convert.ToString(row[DatabaseDefines.Fighter_Title]);
            fighter.PortraitPictureUrl = Convert.ToString(row[DatabaseDefines.Fighter_PortraitPictureUrl]);
            fighter.IconUrl = Convert.ToString(row[DatabaseDefines.Fighter_IconUrl]);
            return fighter;
        }

        private static List<Grab> BuildGrabs(DataTable table)
        {
            List<Grab> grabs = new List<Grab>();

            Parallel.ForEach(table.Rows.Cast<DataRow>(), item =>
            {
                Grab grab = new Grab
                {
                    Name = Convert.ToString(item[DatabaseDefines.Grab_Name]),
                    HitboxActiveRange = Convert.ToString(item[DatabaseDefines.Grab_HitBoxActiveRange]),
                    FirstActionableFrame = Convert.ToInt32(item[DatabaseDefines.Special_FirstActionableFrame]),
                };
                grabs.Add(grab);
            });
            return grabs;
        }

        private static List<Roll> BuildRolls(DataTable table)
        {
            List<Roll> rolls = new List<Roll>();
            Parallel.ForEach(table.Rows.Cast<DataRow>(), item =>
            {
                Roll roll = new Roll()
                {
                    Name = Convert.ToString(item[DatabaseDefines.Roll_Name]),
                    Intangibility = Convert.ToString(item[DatabaseDefines.Roll_Intangibility]),
                    FirstActionableFrame = Convert.ToInt32(item[DatabaseDefines.Roll_FirstActionableFrame]),
                };
                rolls.Add(roll);
            });
            return rolls;
        }

        private static List<Special> BuildSpecials(DataTable table)
        {
            List<Special> specials = new List<Special>();

            Parallel.ForEach(table.Rows.Cast<DataRow>(), item =>
            {
                Special special = new Special
                {
                    Name = Convert.ToString(item[DatabaseDefines.Special_Name]),
                    HitboxActiveRange = Convert.ToString(item[DatabaseDefines.Special_HitboxActiveRange]),
                    FirstActionableFrame = Convert.ToInt32(item[DatabaseDefines.Special_FirstActionableFrame]),
                    BaseDamage = Convert.ToString(item[DatabaseDefines.Special_BaseDamage]),
                    ShieldDamage = Convert.ToString(item[DatabaseDefines.Special_ShieldDamage]),
                    Angle = Convert.ToString(item[DatabaseDefines.Special_Angle]),
                    BaseKnockBack = Convert.ToString(item[DatabaseDefines.Special_BaseKnockBack]),
                    WeightBaseKnockBack = Convert.ToString(item[DatabaseDefines.Special_WeightBaseKnockBack]),
                    KnockBackGrowth = Convert.ToString(item[DatabaseDefines.Special_KnockBackGrowth])
                };
                specials.Add(special);
            });
            return specials;
        }
        private static List<Throw> BuildThrows(DataTable table)
        {
            List<Throw> throws = new List<Throw>();
            Parallel.ForEach(table.Rows.Cast<DataRow>(), item =>
            {
                Throw throwAbility = new Throw()
                {
                    Name = Convert.ToString(item[DatabaseDefines.Throw_Name]),
                    BaseDamage = Convert.ToString(item[DatabaseDefines.Throw_BaseDamage]),
                    ShieldDamage = Convert.ToString(item[DatabaseDefines.Throw_ShieldDamage]),
                    Angle = Convert.ToString(item[DatabaseDefines.Throw_Angle]),
                    BaseKnockBack = Convert.ToString(item[DatabaseDefines.Aerial_BaseKnockBack]),
                    KnockBackGrowth = Convert.ToString(item[DatabaseDefines.Aerial_KnockBackGrowth]),
                };
                throws.Add(throwAbility);
            });
            return throws;
        }
    }
}
