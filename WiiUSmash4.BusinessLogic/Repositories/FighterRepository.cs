using System.Collections.Generic;
using System.Data;
using System;
using System.Threading.Tasks;

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

        private List<string> GetAbilityFrameUrls(int fighterId, string ability)
        {
            FighterDataProvider dataProvider = new FighterDataProvider(_configuration);
            DataTable dataTable = dataProvider.GetAbilityFrameUrls(fighterId, ability);
            return FighterBuilder.BuildAbilityFrameUrls(dataTable);
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
