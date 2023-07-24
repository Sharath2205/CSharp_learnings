namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student()
            {
                FirstName = "Sharath",
                LastName = "Pendyala",
                MiddleName = "Chandra",
                DOB = new DateTime(2001, 05, 22),

                addresses = new List<Address>()
                {
                    new Address()
                    {
                        HNo="12-2",
                        VillageName="XYZ",
                        City="Nizamabad",
                        State="Telangana",
                        ZipCode=500000,
                        mobileNumbers = new List<MobileNumbers>
                        {
                            new MobileNumbers()
                            {
                                PersonalNumber = "+91 9989899898",
                                HomeNumber = "+91 6680000232"
                            }
                        }
                    },
                    new Address()
                    {
                        HNo="1/2A",
                        VillageName="ABC",
                        City="Hyderbad",
                        State="Telangana",
                        ZipCode=000012,
                        mobileNumbers = new List<MobileNumbers>
                        {
                            new MobileNumbers()
                            {
                                PersonalNumber="1234568790",
                                LandLineNumber= "3000121",
                            }
                        }
                    }
                }
            };
        }
    }

    class Student
    {

        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public string? MiddleName { get; set; }
    //    [Required]
        public  DateTime DOB { get; set; }
       
        public List<Address>? addresses { get; set; }

    }

    class Address
    {
        public string? HNo { get; set; }
        public string? StreetName { get; set; }
        public string? VillageName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int ZipCode { get; set; }
        public List<MobileNumbers>? mobileNumbers { get; set; }
    }

    class MobileNumbers
    {
        public required string PersonalNumber { get; set; }
        public string? HomeNumber { get; set;}
        public string? HostelNumber { get; set; }
        public string? LandLineNumber { get; set;}
    }
}