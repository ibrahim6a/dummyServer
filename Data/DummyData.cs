
using System.Collections.Generic;
using dummy_server.Models;

namespace dummy_server.Data {

    public class DummyData {

        public List<User> userList = new List<User>() {
            new User(1, "John", "Doe", "jd@gmail.com", 5000),
            new User(2, "Jane", "Doe", "jane.d@gmaill.com", 5000)
        };

    
    }
    
}