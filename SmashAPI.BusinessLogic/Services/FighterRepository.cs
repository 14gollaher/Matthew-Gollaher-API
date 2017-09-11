using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System;

namespace WiiUSmash4.BusinessLogic
{
    public class FighterRepository //: IFighterRepository
    {
        public void InsertCompleteFighter(Fighter fighter)
        {
            fighter.Id = InsertFighter(fighter);
            //InsertAttributes(fighter.Attributes);
        }
        public IEnumerable<Fighter> GetFighters()
        {
            //return _context.Fighters.FromSql(DatabaseDefines.GetFighters).ToList();
            return null;
        }

        public Fighter GetFighter(int fighterId)
        {
            //return _context.Fighter.FromSql(DatabaseDefines.GetFighter).Single();
            return null;
        }

        public void UpdateFighter(Fighter fighter)
        {
            throw new NotImplementedException();
        }

        public void DeleteFighter(int fighterId)
        {
            throw new System.NotImplementedException();
        }

        private int InsertFighter(Fighter fighter)
        {
            int fighterId = 0;
            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.InsertFighter, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    var fighterTable = new SqlParameter(DatabaseDefines.Fighter_TableType, BuildFighterTable(fighter));
                    command.Parameters.Add(fighterTable);

                    connection.Open();
                    fighterId = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return fighterId;
        }

        private void InsertAerial(int fighterId, List<Aerial> aerials)
        {
            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.InsertFighter, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    var fighterTable = new SqlParameter(DatabaseDefines.Attributes_TableType, BuildAerialTable(fighterId, aerials));
                    command.Parameters.Add(fighterTable);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertAttributes(int fighterId, Attributes attributes)
        {
            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.InsertAttributes, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    var attributeTable = new SqlParameter(DatabaseDefines.Attributes_TableType, BuildAttributesTable(fighterId, attributes));
                    command.Parameters.Add(attributeTable);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


        private DataTable BuildAerialTable(int fighterId, List<Aerial> aerials)
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
            aerialTable.Columns.Add(new DataColumn(DatabaseDefines.Aerial_FighterId));

            foreach (Aerial item in aerials)
            {
                DataRow aerialRow = aerialTable.NewRow();
                aerialRow[DatabaseDefines.Aerial_Name] = item.Name;
                aerialRow[DatabaseDefines.Aerial_HitboxActiveRange] = item.HitboxActiveRange;
                aerialRow[DatabaseDefines.Aerial_BaseDamage] = item.BaseDamage;
                aerialRow[DatabaseDefines.Aerial_ShieldDamage] = item.ShieldDamage;
                aerialRow[DatabaseDefines.Aerial_Angle] = item.Angle;
                aerialRow[DatabaseDefines.Aerial_BaseKnockBack] = item.BaseKnockBack;
                aerialRow[DatabaseDefines.Aerial_WeightBaseKnockBack] = item.WeightBaseKnockBack;
                aerialRow[DatabaseDefines.Aerial_KnockBackGrowth] = item.KnockBackGrowth;
                aerialRow[DatabaseDefines.Aerial_LandingLag] = item.LandingLag;
                aerialRow[DatabaseDefines.Aerial_AutoCancelFrames] = item.AutoCancelFrames;
                aerialRow[DatabaseDefines.Aerial_FighterId] = fighterId;
                aerialTable.Rows.Add();
            }

            return aerialTable;
        }
        private DataTable BuildAttackTable(List<Attack> attacks)
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

            foreach (Attack item in attacks)
            {
                DataRow attackRow = attackTable.NewRow();
                attackRow[DatabaseDefines.Attack_Name] = item.Name;
                attackRow[DatabaseDefines.Attack_HitboxActiveRange] = item.HitboxActiveRange;
                attackRow[DatabaseDefines.Attack_FirstActionableFrame] = item.FirstActionableFrame;
                attackRow[DatabaseDefines.Attack_BaseDamage] = item.BaseDamage;
                attackRow[DatabaseDefines.Attack_ShieldDamage] = item.ShieldDamage;
                attackRow[DatabaseDefines.Attack_Angle] = item.Angle;
                attackRow[DatabaseDefines.Attack_BaseKnockBack] = item.BaseKnockBack;
                attackRow[DatabaseDefines.Attack_WeightBaseKnockBack] = item.WeightBaseKnockBack;
                attackRow[DatabaseDefines.Attack_KnockBackGrowth] = item.KnockBackGrowth;
                attackTable.Rows.Add();
            }

            return attackTable;
        }
        private DataTable BuildAttributesTable(int fighterId, Attributes attributes)
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
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_MaximumJumps));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WallJump));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_WallCling));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_Crawl));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_Tether));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_JumpSquatFrames));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_SoftLandingLagFrames));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_HardLandingLagFrames));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attributes_FullHopAirTimeFrames));
            attributesTable.Columns.Add(new DataColumn(DatabaseDefines.Attibutes_FighterId));

            DataRow attributeRow = attributesTable.NewRow();
            attributeRow[DatabaseDefines.Attributes_Weight] = attributes.Weight;
            attributeRow[DatabaseDefines.Attributes_WeightRank] = attributes.WeightRank;
            attributeRow[DatabaseDefines.Attributes_RunSpeed] = attributes.RunSpeed;
            attributeRow[DatabaseDefines.Attributes_RunSpeedRank] = attributes.RunSpeedRank;
            attributeRow[DatabaseDefines.Attributes_WalkSpeed] = attributes.WalkSpeed;
            attributeRow[DatabaseDefines.Attributes_WalkSpeedRank] = attributes.WalkSpeedRank;
            attributeRow[DatabaseDefines.Attributes_FallSpeed] = attributes.FallSpeed;
            attributeRow[DatabaseDefines.Attributes_FallSpeedRank] = attributes.FallSpeedRank;
            attributeRow[DatabaseDefines.Attributes_AirAcceleration] = attributes.AirAcceleration;
            attributeRow[DatabaseDefines.Attributes_Gravity] = attributes.Gravity;
            attributeRow[DatabaseDefines.Attributes_ShortHopAirTimeFrames] = attributes.ShortHopAirTimeFrames;
            attributeRow[DatabaseDefines.Attributes_FastFallSpeed] = attributes.FastFallSpeed;
            attributeRow[DatabaseDefines.Attributes_MaximumJumps] = attributes.MaximumJumps;
            attributeRow[DatabaseDefines.Attributes_WallJump] = attributes.WallJump;
            attributeRow[DatabaseDefines.Attributes_WallCling] = attributes.WallCling;
            attributeRow[DatabaseDefines.Attributes_Crawl] = attributes.Crawl;
            attributeRow[DatabaseDefines.Attributes_Tether] = attributes.Tether;
            attributeRow[DatabaseDefines.Attributes_JumpSquatFrames] = attributes.JumpSquatFrames;
            attributeRow[DatabaseDefines.Attributes_SoftLandingLagFrames] = attributes.SoftLandingLagFrames;
            attributeRow[DatabaseDefines.Attributes_HardLandingLagFrames] = attributes.HardLandingLagFrames;
            attributeRow[DatabaseDefines.Attributes_FullHopAirTimeFrames] = attributes.FullHopAirTimeFrames;
            attributeRow[DatabaseDefines.Attibutes_FighterId] = fighterId;
            attributesTable.Rows.Add();

            return attributesTable;
        }
        private DataTable BuildFighterTable(Fighter fighter)
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
        private DataTable BuildGrabTable(List<Grab> grabs)
        {
            DataTable grabTable = new DataTable();
            grabTable.Columns.Add(new DataColumn(DatabaseDefines.Grab_Name));
            grabTable.Columns.Add(new DataColumn(DatabaseDefines.Grab_HitBoxActiveRange));
            grabTable.Columns.Add(new DataColumn(DatabaseDefines.Grab_FirstActionableFrame));

            foreach (Grab item in grabs)
            {
                DataRow grabRow = grabTable.NewRow();
                grabRow[DatabaseDefines.Attack_Name] = item.Name;
                grabRow[DatabaseDefines.Attack_HitboxActiveRange] = item.HitboxActiveRange;
                grabRow[DatabaseDefines.Attack_FirstActionableFrame] = item.FirstActionableFrame;
            }

            return grabTable;
        }
        private DataTable BuildRollTable(List<Roll> rolls)
        {
            DataTable rollTable = new DataTable();
            rollTable.Columns.Add(new DataColumn(DatabaseDefines.Roll_Name));
            rollTable.Columns.Add(new DataColumn(DatabaseDefines.Roll_Intangibility));
            rollTable.Columns.Add(new DataColumn(DatabaseDefines.Roll_FirstActionableFrame));

            foreach (Roll item in rolls)
            {
                DataRow rollRow = rollTable.NewRow();
                rollRow[DatabaseDefines.Roll_Name] = item.Name;
                rollRow[DatabaseDefines.Roll_Intangibility] = item.Intangibility;
                rollRow[DatabaseDefines.Roll_FirstActionableFrame] = item.FirstActionableFrame;
            }

            return rollTable;
        }
        private DataTable BuildSpecialTable(List<Special> specials)
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

            foreach (Special item in specials)
            {
                DataRow specialRow = specialTable.NewRow();
                specialRow[DatabaseDefines.Special_Name] = item.Name;
                specialRow[DatabaseDefines.Special_HitboxActiveRange] = item.HitboxActiveRange;
                specialRow[DatabaseDefines.Special_FirstActionableFrame] = item.FirstActionableFrame;
                specialRow[DatabaseDefines.Special_BaseDamage] = item.BaseDamage;
                specialRow[DatabaseDefines.Special_ShieldDamage] = item.ShieldDamage;
                specialRow[DatabaseDefines.Special_Angle] = item.Angle;
                specialRow[DatabaseDefines.Special_BaseKnockBack] = item.BaseKnockBack;
                specialRow[DatabaseDefines.Special_WeightBaseKnockBack] = item.WeightBaseKnockBack;
                specialRow[DatabaseDefines.Special_KnockBackGrowth] = item.KnockBackGrowth;
                specialTable.Rows.Add();
            }

            return specialTable;
        }
        private DataTable BuildThrowTable(List<Throw> throws)
        {
            DataTable throwTable = new DataTable();
            throwTable.Columns.Add(new DataColumn(DatabaseDefines.Throw_Name));
            throwTable.Columns.Add(new DataColumn(DatabaseDefines.Throw_BaseDamage));
            throwTable.Columns.Add(new DataColumn(DatabaseDefines.Throw_Angle));
            throwTable.Columns.Add(new DataColumn(DatabaseDefines.Throw_BaseKnockBack));
            throwTable.Columns.Add(new DataColumn(DatabaseDefines.Throw_KnockBackGrowth));

            foreach (Throw item in throws)
            {
                DataRow throwRow = throwTable.NewRow();
                throwRow[DatabaseDefines.Throw_Name] = item.Name;
                throwRow[DatabaseDefines.Throw_BaseDamage] = item.BaseDamage;
                throwRow[DatabaseDefines.Throw_Angle] = item.Angle;
                throwRow[DatabaseDefines.Throw_BaseKnockBack] = item.BaseKnockBack;
                throwRow[DatabaseDefines.Throw_KnockBackGrowth] = item.KnockBackGrowth;
                throwTable.Rows.Add();
            }

            return throwTable;
        }

    }
}
