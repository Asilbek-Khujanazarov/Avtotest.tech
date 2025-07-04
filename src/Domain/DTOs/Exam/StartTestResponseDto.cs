using Autotest.Platform.API.DTOs.Questions;
namespace Autotest.Platform.Domain.DTOs.Exam;

public class StartTestResponseDto
{
    public Guid SessionId { get; set; }
    public List<QuestionDto> Questions { get; set; }
    public int DurationMinutes { get; set; }
    public DateTime Deadline { get; set; }
}
