namespace Business
{
    public interface IBusinessContext
    {
        Post Post { get; set; }
        Comment Comment { get; set; }
        Category Category { get; set; }     
    }

}
