using Data;

namespace Business
{
    public class Comment : Context<DomainModel.Comment>
    {
        public Comment(string db)
            : base(db)
        {
        }
    }
}