
            // LINQ JOIN GroupJoin

            IList<Product1> products1 = CreatePro1();
            IList<Product2> products2 = CreatePro2();


            var res = products1.Join(products2, i => i.Id, p => p.Id , (i,p) => new
            {
                i.Name,
                p.City,
            });

            var res2 = products1.GroupJoin(products2, i => i.Id, p => p.Id, (i, p) => new
            {
                i.Name,
                pro = p,
            });
