using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace WiiUSmash4.BusinessLogic
{
    public class FighterRepository : IFighterRepository 
    {
        public void InsertFighter(Fighter fighter)
        {
            fighter.Id = FighterDataProvider.InsertPartialFighter(fighter);
            FighterDataProvider.InsertAttributes(fighter.Id, fighter.Attributes);

            Parallel.ForEach(fighter.Aerials, item =>
            {
                FighterDataProvider.InsertAerial(fighter.Id, item);
            });
            Parallel.ForEach(fighter.Attacks, item =>
            {
                FighterDataProvider.InsertAttack(fighter.Id, item);
            });
            Parallel.ForEach(fighter.Grabs, item =>
            {
                FighterDataProvider.InsertGrab(fighter.Id, item);
            });
            Parallel.ForEach(fighter.Rolls, item =>
            {
                FighterDataProvider.InsertRoll(fighter.Id, item);
            });
            Parallel.ForEach(fighter.Specials, item =>
            {
                FighterDataProvider.InsertSpecial(fighter.Id, item);
            });
            Parallel.ForEach(fighter.Throws, item =>
            {
                FighterDataProvider.InsertThrow(fighter.Id, item);
            });
        }

        public IEnumerable<Fighter> GetFighters()
        {
            DataSet dataSet = FighterDataProvider.GetFighters();
            List<int> fighterIds = FighterBuilder.BuildFighterIds(dataSet.Tables[0]);

            List<Fighter> fighters = new List<Fighter>();
            Parallel.ForEach(fighterIds, item =>
            {
                fighters.Add(GetFighter(item));
            });

            return fighters;
        }

        public Fighter GetFighter(int fighterId)
        {
            DataSet dataSet = FighterDataProvider.GetFighter(fighterId);
            return PopulateAbilitiesUrls(FighterBuilder.Build(dataSet));
        }

        public IEnumerable<Icon> GetIcons()
        {
            DataSet dataSet = new DataSet();

            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.GetIcons, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    SqlDataAdapter adapter = new SqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    connection.Open();
                    adapter.Fill(dataSet);
                }
            }
            return FighterBuilder.BuildIcons(dataSet.Tables[0]);
        }

        public void UpdateFighter(Fighter fighter)
        {
            throw new NotImplementedException();
        }

        public void DeleteFighter(int fighterId)
        {
            throw new NotImplementedException();
        }

        private List<string> GetAbilityFrameUrls(int fighterId, string ability)
        {
            DataSet dataSet = new DataSet();

            using (var connection = new SqlConnection(DatabaseDefines.SmashDbConnectionString))
            {
                using (var command = new SqlCommand(DatabaseDefines.GetAbilityFrameUrls, connection)
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.Fighter_Id, fighterId));
                    command.Parameters.Add(new SqlParameter(DatabaseDefines.AbilityFramePicture_AbilityName, ability));

                    SqlDataAdapter adapter = new SqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    connection.Open();
                    adapter.Fill(dataSet);
                }
            }
            return FighterBuilder.BuildAbilityFrameUrls(dataSet.Tables[0]);
        }

        private Fighter PopulateAbilitiesUrls(Fighter fighter)
        {
            Parallel.ForEach(fighter.Aerials, item =>
            {
                item.AbilityFramePictureUrls = GetAbilityFrameUrls(fighter.Id, item.Name);
            });
            Parallel.ForEach(fighter.Attacks, item =>
            {
                item.AbilityFramePictureUrls = GetAbilityFrameUrls(fighter.Id, item.Name);
            });
            Parallel.ForEach(fighter.Grabs, item =>
            {
                item.AbilityFramePictureUrls = GetAbilityFrameUrls(fighter.Id, item.Name);
            });
            Parallel.ForEach(fighter.Rolls, item =>
            {
                item.AbilityFramePictureUrls = GetAbilityFrameUrls(fighter.Id, item.Name);
            });
            Parallel.ForEach(fighter.Specials, item =>
            {
                item.AbilityFramePictureUrls = GetAbilityFrameUrls(fighter.Id, item.Name);
            });
            Parallel.ForEach(fighter.Throws, item =>
            {
                item.AbilityFramePictureUrls = GetAbilityFrameUrls(fighter.Id, item.Name);
            });

            return fighter;
        }
    }
}
