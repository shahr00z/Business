using Data;

namespace Business
{
    public class Post : Context<DomainModel.Post>
    {
        public Post(string db)
            : base(db)
        {
        }
    }
}