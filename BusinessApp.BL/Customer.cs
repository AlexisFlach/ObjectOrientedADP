namespace  BusinessApp.BL
{
        public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string FullName
        {
            get
            {   
                string fullName = FirstName;

                if(!string.IsNullOrWhiteSpace(LastName)){
                    if(!string.IsNullOrWhiteSpace(fullName)) {
                        fullName += " ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }
        public string EmailAddress { get; set; }
    }
}