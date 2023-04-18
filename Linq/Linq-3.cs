            // Take And Skip 
            var myList = CreateUser();

            // Get from User
            int pageIndex = 1; 

            int PageCount = myList.Count() / 2 ;

            var result = myList.OrderBy(u => u.Name).Skip(PageCount * pageIndex).Take(2).ToList();

            // return result 