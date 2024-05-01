using Microsoft.AspNetCore.Mvc;
[Route("[Action]")]
[ApiController]

public class Watercost : Controller
{
    [HttpGet]
    public double masraf(int miazan, string noemasraf)

    {
        double result = 0;
        double overfolw = 0;
        if (noemasraf == "h")
        {
            result = (miazan / 100) * 500;

        }
        else if (noemasraf == "i")
        {
            result = (miazan / 1000) * 750;
            if (miazan > 4000000)
            {
                overfolw = (miazan - 4000000) * 0.00025;
                result += overfolw;
            }

        }
        else if (noemasraf == "e")
        {
            result = (miazan / 1500) * 600;
            if (miazan > 2000000)
            {
                overfolw = (miazan - 2000000) * 0.00004;
                result += overfolw;
            }


        }

        return result;

    }


}