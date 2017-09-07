namespace SmashAPI.BusinessLogic
{
    public class Fighter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PortraitPictureUrl { get; set; }
        Attributes Attributes { get; set; }
        Abilities Abilities { get; set; }
    }
}
