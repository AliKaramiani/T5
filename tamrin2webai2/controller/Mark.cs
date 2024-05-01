using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]
public class Students : Controller
{
    [HttpPost]
    public Student getmark([FromBody] List<Student> students)
    {
        double maxmark = 0;
        Student beststudent = null;
        foreach (var x in students)
        {
            if (x.Mark < 12)
            {
                if (maxmark < x.Mark)
                {
                    maxmark = x.Mark;
                    beststudent = x;
                }


            }

        }
        return beststudent;

    }

}