using Data;

namespace Business
{
    public class Category : Context<DomainModel.Category>
    {
        public Category(string db)
            : base(db)
        {
        }
    }
}