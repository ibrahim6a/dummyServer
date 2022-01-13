


namespace dummy_server.Models {

    public class User {

        public User(int Id, string FirstName, string LastName, string Email, int Balance) {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Balance = Balance;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Balance { get; set; }
    }
}