using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
namespace BACKEND.Pages;

public class AllQuizesModel : PageModel
{
    private readonly IQuizUserService _userService;

    private readonly ILogger _logger;
    
    [BindProperty]
    public List<BACKEND.Quiz> Quizes { get; set; }
    
    public AllQuizesModel(IQuizUserService userService, ILogger<QuizModel> logger)
    {
        _userService = userService;
        _logger = logger;
    }
    
    public void OnGet()
    {
        Quizes = _userService.FindAllQuizes();
    }

    public IActionResult OnPost(int quiz)
    {
        return RedirectToPage("Item", new {quizId = quiz, itemId = 1});
    }
}