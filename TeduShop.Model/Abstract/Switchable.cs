namespace TeduShop.Model.Abstract
{
    public class Switchable : ISwitchable
    {
        public Switchable()
        {
            Status = true;
        }

        public bool Status { get; set; }
    }
}