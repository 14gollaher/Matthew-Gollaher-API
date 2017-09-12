namespace WiiUSmash4.BusinessLogic
{
    public class DatabaseDefines
    {
        public static string SmashDbConnectionString = "Server=tcp:matthewgollaher.database.windows.net,1433;Initial Catalog=WiiUSmash4;Persist Security Info=False;User ID=gollaher14;Password=ABCmeow123!!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        #region Stored Procedures
        public static string InsertFighter = "dbo.Fighter_INS";
        public static string InsertAbilityFramePicture = "dbo.AbilityFramePicture_INS";
        public static string InsertAerial = "dbo.Aerial_INS";
        public static string InsertAttack = "dbo.Attack_INS";
        public static string InsertAttributes = "dbo.Attributes_INS";
        public static string InsertGrab = "dbo.Grab_INS";
        public static string InsertRoll = "dbo.Roll_INS";
        public static string InsertSpecial = "dbo.Special_INS";
        public static string InsertThrow = "dbo.Throw_INS";

        public static string GetFighters = "dbo.Fighters_SEL";
        public static string GetFighter = "dbo.Fighter_SEL";
        public static string GetAbilityFrameUrls = "dbo.AbilityFramePicture_SEL";
        public static string GetFighterIds = "dbo.FighterId_SEL";
        #endregion

        #region Ability Frame Picture Table
        public static string AbilityFramePicture_TableType = "AbilityFramePictureTable";
        public static string AbilityFramePicture_AbilityName = "Name";
        public static string AbilityFramePicture_PictureUrl = "PictureUrl";

        #endregion 

        #region Aerial Table
        public static string Aerial_TableType = "AerialTable";
        public static string Aerial_Name = "Name";
        public static string Aerial_HitboxActiveRange = "HitboxActiveRange";
        public static string Aerial_BaseDamage = "BaseDamage";
        public static string Aerial_ShieldDamage = "ShieldDamage";
        public static string Aerial_Angle = "Angle";
        public static string Aerial_BaseKnockBack = "BaseKnockBack";
        public static string Aerial_WeightBaseKnockBack = "WeightBaseKnockBack";
        public static string Aerial_KnockBackGrowth = "KnockBackGrowth";
        public static string Aerial_LandingLag = "LandingLag";
        public static string Aerial_AutoCancelFrames = "AutoCancelFrames";
        #endregion

        #region Attack Table
        public static string Attack_TableType = "AttackTable";
        public static string Attack_Name = "Name";
        public static string Attack_HitboxActiveRange = "HitboxActiveRange";
        public static string Attack_FirstActionableFrame = "FirstActionableFrame";
        public static string Attack_BaseDamage = "BaseDamage";
        public static string Attack_ShieldDamage = "ShieldDamage";
        public static string Attack_Angle = "Angle";
        public static string Attack_BaseKnockBack = "BaseKnockBack";
        public static string Attack_WeightBaseKnockBack = "WeightBaseKnockBack";
        public static string Attack_KnockBackGrowth = "KnockBackGrowth";
        #endregion

        #region Attributes Table
        public static string Attributes_TableType = "AttributesTable";
        public static string Attributes_Weight = "Weight";
        public static string Attributes_WeightRank = "WeightRank";
        public static string Attributes_RunSpeed = "RunSpeed";
        public static string Attributes_RunSpeedRank = "RunSpeedRank";
        public static string Attributes_WalkSpeed = "WalkSpeed";
        public static string Attributes_WalkSpeedRank = "WalkSpeedRank";
        public static string Attributes_AirSpeed = "AirSpeed";
        public static string Attributes_AirSpeedRank = "AirSpeedRank";
        public static string Attributes_FallSpeed = "FallSpeed";
        public static string Attributes_FallSpeedRank = "FallSpeedRank";
        public static string Attributes_AirAcceleration = "AirAcceleration";
        public static string Attributes_Gravity = "Gravity"; 
        public static string Attributes_ShortHopAirTimeFrames = "ShortHopAirTimeFrames";
        public static string Attributes_FastFallSpeed = "FastFallSpeed";
        public static string Attributes_FastFallSpeedRank = "FastFallSpeedRank";
        public static string Attributes_MaximumJumps = "MaximumJumps";
        public static string Attributes_WallJump = "WallJump";
        public static string Attributes_WallCling = "WallCling";
        public static string Attributes_Crawl = "Crawl";
        public static string Attributes_Tether = "Tether";
        public static string Attributes_JumpSquatFrames = "JumpSquatFrames";
        public static string Attributes_SoftLandingLagFrames = "SoftLandingLagFrames";
        public static string Attributes_HardLandingLagFrames = "HardLandingLagFrames";
        public static string Attributes_FullHopAirTimeFrames = "FullHopAirTimeFrames"; 
        #endregion

        #region Fighter 
        public static string Fighter_Id = "FighterId";
        public static string Fighter_TableType = "FighterTable";
        public static string Fighter_Name = "Name";
        public static string Fighter_Title = "Title";
        public static string Fighter_PortraitPictureUrl = "PortraitPictureUrl";
        #endregion

        #region Grab Table
        public static string Grab_TableType = "GrabTable";
        public static string Grab_Name = "Name";
        public static string Grab_HitBoxActiveRange = "HitBoxActiveRange";
        public static string Grab_FirstActionableFrame = "FirstActionableFrame";
        #endregion

        #region Roll Table
        public static string Roll_TableType = "RollTable";
        public static string Roll_Name = "Name";
        public static string Roll_Intangibility = "Intangibility";
        public static string Roll_FirstActionableFrame = "FirstActionableFrame";
        #endregion

        #region Special Table
        public static string Special_TableType = "SpecialTable";
        public static string Special_Name = "Name";
        public static string Special_HitboxActiveRange = "HitboxActiveRange";
        public static string Special_FirstActionableFrame = "FirstActionableFrame"; 
        public static string Special_BaseDamage = "BaseDamage";
        public static string Special_ShieldDamage = "ShieldDamage";
        public static string Special_Angle = "Angle";
        public static string Special_BaseKnockBack = "BaseKnockBack";
        public static string Special_WeightBaseKnockBack = "WeightBaseKnockBack";
        public static string Special_KnockBackGrowth = "KnockBackGrowth";
        #endregion

        #region Throw Table
        public static string Throw_TableType = "ThrowTable";
        public static string Throw_Name = "Name";
        public static string Throw_BaseDamage = "BaseDamage";
        public static string Throw_ShieldDamage = "ShieldDamage";
        public static string Throw_Angle = "Angle";
        public static string Throw_BaseKnockBack = "BaseKnockBack";
        public static string Throw_WeightBaseKnockBack = "WeightBaseKnockBack";
        public static string Throw_KnockBackGrowth = "KnockBackGrowth";
        #endregion

    }
}
