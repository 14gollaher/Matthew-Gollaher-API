namespace WiiUSmash4.BusinessLogic
{
    public class DatabaseDefines
    {
        #region Fighter Stored Procedures
        public static string Fighter_GetFighters = "EXEC dbo.SEL_GetFighters";
        public static string Fighter_GetFighter = "EXEC dbo.SEL_GetFighter";
        public static string Fighter_UpsertFighter = "EXEC dbo.UPD_UpsertFighter";
        #endregion

        #region Fighter Table Columns
        public static string Fighter_Id = "Id";
        public static string Fighter_Name = "Name";
        public static string Fighter_PortraitPicture = "PortraitPictureUrl";
        #endregion
    }
}
