using ApplicationCore.Interfaces.Repository;

namespace BACKEND;

public class Quiz: IIdentity<int>
{
    public int Id { get; set; }
    
    public string Title { get; }
    
    public List<QuizItem> Items { get; set; }

    public Quiz(int id, List<QuizItem> items, string title)
    {
        Id = id;
        Items = items;
        Title = title;
    }
}