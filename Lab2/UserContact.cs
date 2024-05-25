namespace Lab2
{

    public enum Status { OffLine, Online }
    public class UserContact
    {
        public string Name { get; set; }

        public string PhoneNum { get; set; }

        public Status Status { get; set; }

        public string Image { get; set; }


    }
}