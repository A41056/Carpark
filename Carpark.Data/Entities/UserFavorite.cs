namespace Carpark.Data.Entities
{
    public class UserFavorite
    {
        public Guid UserId { get; set; }
        public string CarParkNo { get; set; }
        public virtual CarPark CarParkNavigation { get; set; }
        public virtual User UserNavigation { get; set; }
    }
}
