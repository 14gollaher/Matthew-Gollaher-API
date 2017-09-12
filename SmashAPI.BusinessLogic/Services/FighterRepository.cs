using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System;

namespace WiiUSmash4.BusinessLogic
{
    public class FighterRepository : IFighterRepository
    {
        public void InsertFighter(Fighter fighter)
        {
            fighter.Id = InsertPartialFighter(fighter);
            InsertAttributes(fighter.Id, fighter.Attributes);

            foreach (Aerial item in fighter.Aerials)
            {
                InsertAerial(fighter.Id, item);
            }
            foreach (Attack item in fighter.Attacks)
            {
                InsertAttack(fighter.Id, item);
            }
            foreach (Grab item in fighter.Grabs)
            {
                InsertGrab(fighter.Id, item);
            }
            foreach (Roll item in fighter.Rolls)
            {
                InsertRoll(fighter.Id, item);
            }
            foreach (Special item in fighter.Specials)
            {
                InsertSpecial(fighter.Id, item);
            }
            foreach (Throw item in fighter.Throws)
            {
                InsertThrow(fighter.Id, item);
            }
        }

        public IEnumerable<Fighter> GetFighters()
        {
            return null;
        }

        public Fighter GetFighter(int fighterId)
        {
            return null;
        }

        public void UpdateFighter(Fighter fighter)
        {
            throw new NotImplementedException();
        }

        public void DeleteFighter(int fighterId)
        {
            throw new NotImplementedException();
        }

        private int InsertPartialFighter(Fighter fighter)
        {
            int fighterId = 0;
            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.InsertFighter, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.Fighter_TableType, FighterTableBuilder.BuildFighterTable(fighter)));

                    connection.Open();
                    fighterId = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return fighterId;
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
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.Attributes_TableType, FighterTableBuilder.BuildAttributesTable(fighterId, attributes)));

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertAerial(int fighterId, Aerial aerial)
        {
            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.InsertAerial, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.Aerial_TableType, FighterTableBuilder.BuildAerialTable(fighterId, aerial)));

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertAttack(int fighterId, Attack attack)
        {
            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.InsertAttack, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.Attack_TableType, FighterTableBuilder.BuildAttackTable(fighterId, attack)));

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertGrab(int fighterId, Grab grab)
        {
            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.InsertGrab, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.Grab_TableType, FighterTableBuilder.BuildGrabTable(fighterId, grab)));
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.AbilityFramePicture_TableType, FighterTableBuilder.BuildAbilityFramePictureTable(grab.AbilityFramePictureUrls)));
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertRoll(int fighterId, Roll roll)
        {
            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.InsertThrow, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.Roll_TableType, FighterTableBuilder.BuildRollTable(fighterId, roll)));
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.AbilityFramePicture_TableType, FighterTableBuilder.BuildAbilityFramePictureTable(roll.AbilityFramePictureUrls)));
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private void InsertSpecial(int fighterId, Special special)
        {
            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.InsertSpecial, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.Special_TableType, FighterTableBuilder.BuildSpecialTable(fighterId, special)));
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.AbilityFramePicture_TableType, FighterTableBuilder.BuildAbilityFramePictureTable(special.AbilityFramePictureUrls)));
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void InsertThrow(int fighterId, Throw throwAbility)
        {
            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.InsertThrow, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.Throw_TableType, FighterTableBuilder.BuildThrowTable(fighterId, throwAbility)));
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.AbilityFramePicture_TableType, FighterTableBuilder.BuildAbilityFramePictureTable(throwAbility.AbilityFramePictureUrls)));
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
