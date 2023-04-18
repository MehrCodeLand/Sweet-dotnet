// mehr code land :)

public class BasePage
    {
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public int PageCount { get; set; }
    }

    public static class PageingHelper
    {
        public static BasePage Pager(int pageIndex,int entitiesCount, int take , int homeManyPageShow)
        {
            int pageCount = (int)Math.Ceiling(entitiesCount / (double)take);

            int startPage = (pageIndex - homeManyPageShow) <= 0 ? 1 : (pageIndex - homeManyPageShow) ;
            int endPage = (pageIndex + homeManyPageShow ) > pageCount ? pageCount : (pageIndex - homeManyPageShow) ;

            var basePage = new BasePage
            {
                EndPage = endPage, 
                StartPage = startPage,
                PageCount = pageCount
            };

            return basePage;
        }
    }

    public class BaseFilterVm<T>
    {
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public int PageCount { get; set; }

        private IEnumerable<T> entities ;
        public IEnumerable<T> Entities { get { return entities; } set { entities = value; } }
    }