
using System.Collections.Generic;
using dummy_server.Models;

namespace dummy_server.Data {

    public class DummyData {

        public List<User> userList = new List<User>() {
            new User(1, "Ibrahim", "Aboud", "ia@gmail.com", 5000),
            new User(2, "Hadi", "Emami", "emami@gmaill.com", 5000)
        };

    
    }
    
}