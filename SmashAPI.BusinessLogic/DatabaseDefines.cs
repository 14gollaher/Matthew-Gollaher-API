namespace SmashAPI.BusinessLogic
{
    public class DatabaseDefines
    {
        #region Character Stored Procedures
        public static string Character_GetCharacters = "EXEC dbo.SEL_GetCharacters";
        public static string Character_UpsertCharacter = "EXEC dbo.UPD_UpsertCharacter";
        #endregion

        #region Character Table Columns
        public static string Character_Id = "Id";
        public static string Character_Name = "Name";
        public static string Character_PortraitPicture = "PortraitPicture";
        #endregion
    }
}
