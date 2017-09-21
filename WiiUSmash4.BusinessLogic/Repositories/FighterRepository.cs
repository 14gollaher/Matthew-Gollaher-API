using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace WiiUSmash4.BusinessLogic
{
    public class FighterRepository : IFighterRepository 
    {
        private readonly WiiUSmash4Configuration _configuration;

        public FighterRepository(WiiUSmash4Configuration configuration)
        {
            _configuration = configuration;
        }

        public void InsertFighter(Fighter fighter)
        {
            FighterDataProvider dataProvider = new FighterDataProvider(_configuration);
            fighter.Id = dataProvider.InsertPartialFighter(fighter);
            dataProvider.InsertAttributes(fighter.Id, fighter.Attributes);

            Parallel.ForEach(fighter.Aerials, item =>
            {
                dataProvider.InsertAerial(fighter.Id, item);
            });
            Parallel.ForEach(fighter.Attacks, item =>
            {
                dataProvider.InsertAttack(fighter.Id, item);
            });
            Parallel.ForEach(fighter.Grabs, item =>
            {
                dataProvider.InsertGrab(fighter.Id, item);
            });
            Parallel.ForEach(fighter.Rolls, item =>
            {
                dataProvider.InsertRoll(fighter.Id, item);
            });
            Parallel.ForEach(fighter.Specials, item =>
            {
                dataProvider.InsertSpecial(fighter.Id, item);
            });
            Parallel.ForEach(fighter.Throws, item =>
            {
                dataProvider.InsertThrow(fighter.Id, item);
            });
        }

        public IEnumerable<Fighter> GetFighters()
        {
            FighterDataProvider dataProvider = new FighterDataProvider(_configuration);
            DataSet dataSet = dataProvider.GetFighters();
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
            FighterDataProvider dataProvider = new FighterDataProvider(_configuration);
            DataSet dataSet = dataProvider.GetFighter(fighterId);
            return PopulateAbilitiesUrls(FighterBuilder.Build(dataSet));
        }

        public IEnumerable<Icon> GetIcons()
        {
            FighterDataProvider dataProvider = new FighterDataProvider(_configuration);
            DataTable dataTable = dataProvider.GetIcons();
            return FighterBuilder.BuildIcons(dataTable);
        }

        public void UpdateFighter(Fighter fighter)
        {
            throw new NotImplementedException();
        }

        public void DeleteFighter(int fighterId)
        {
            throw new NotImplementedException();
        }

        private List<string> GetAbilityFrameUrls(int fighterId, string ability) //TODO MOVE ME TO D.Prov
        {
            DataSet dataSet = new DataSet();

            using (var connection = new SqlConnection(_configuration.WiiUSmash4DbConnectionString))
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
