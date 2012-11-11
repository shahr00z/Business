namespace Business
{
    public class BusinessContext : IBusinessContext
    {
        private Category _category;
        private Comment _comment;
        private Post _page;

        public BusinessContext(string db)
        {
            Db = db;
        }

        private string Db { get; set; }

        #region IBusinessContext Members

        public Post Post
        {
            get { return _page ?? (_page = new Post(Db)); }
            set { _page = value; }
        }

        public Comment Comment
        {
            get { return _comment ?? (_comment = new Comment(Db)); }
            set { _comment = value; }
        }

        public Category Category
        {
            get { return _category ?? (_category = new Category(Db)); }

            set { _category = value; }
        }

        #endregion
    }
}