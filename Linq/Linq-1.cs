
            // LINQ Part-1
            // -----------
            // Users Info
            //User user = new User()
            //{
            //    Name = "Mehrshad",
            //    Sex = true,
            //    Age = 20,
            //};

            var usersLinq = users.OrderBy(u => u.Name);

            usersLinq = users.OrderByDescending(u => u.Name);

            var female = users.Where(u => u.Sex == false);

            var contains = users.Where(u => u.Name.Contains("M"));

            var user = users.SingleOrDefault(u => u.Name == "Aria");

            var myUsers = users.Count();

            var ave = users.Average(u => u.Age);

            var sexAndName = users.OrderBy(u => u.Name).ThenBy(u => u.Age);

            var groupBy = users.GroupBy(u => u.Sex);