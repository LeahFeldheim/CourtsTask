using Microsoft.AspNetCore.Mvc;
using CourtsTaskAPI.Models;
using CourtsTaskAPI.Interface;
[Route("api/[controller]")]
[ApiController]
public class CasesController : ControllerBase
{
    private readonly ICaseService _caseService;

    public CasesController(ICaseService caseService)
    {
        _caseService = caseService;
    }
    [HttpGet("GetAllTik")]
    public List<TikModel> GetAllTik()
    {
        List<TikModel> listTikim =
        [
            new TikModel
                     {
                       MisTik  = 1,
                       Osek  =    "בדיקת שמירת החלטה",
                      SugTik  = "חרבות ברזל",
                      TkufatZakaaot  = DateTime.Now.AddDays(-20),
                      TarichPtichatTik  = DateTime.Now.AddDays(-40),
                     TarichDyun  = DateTime.Now.AddDays(-10),
                     MgishArar  = "אברהם אברהמי",
                     Mshiva  = "לאה כהן",
                     YprVaada  = "ציון ציוני",
                      Natzig  = "אילה לוי",
                      Status  = enumStatus.niftach
                     },
            new TikModel
            {
              MisTik  = 2,
              Osek  =    "בדיקת שמירת החלטה",
             SugTik  = "חרבות ברזל",
             TkufatZakaaot  = DateTime.Now.AddDays(-20),
             TarichPtichatTik  = DateTime.Now.AddDays(-40),
            TarichDyun  = DateTime.Now.AddDays(-10),
            MgishArar  = "אברהם אברהמי",
            Mshiva  = "לאה כהן",
            YprVaada  = "ציון ציוני",
             Natzig  = "אילה לוי",
             Status  = enumStatus.paail
            },
            new TikModel
             {
               MisTik  = 3,
               Osek  =    "בדיקת שמירת החלטה",
              SugTik  = "חרבות ברזל",
              TkufatZakaaot  = DateTime.Now.AddDays(-20),
              TarichPtichatTik  = DateTime.Now.AddDays(-40),
             TarichDyun  = DateTime.Now.AddDays(-10),
             MgishArar  = "משה אברהמי",
             Mshiva  = "לאה כהן",
             YprVaada  = "ציון ציוני",
              Natzig  = "אילה לוי",
              Status  = enumStatus.paail
             },
            new TikModel
             {
               MisTik  = 4,
               Osek  =    "בדיקת שמירת החלטה",
              SugTik  = "חרבות ברזל",
              TkufatZakaaot  = DateTime.Now.AddDays(-20),
              TarichPtichatTik  = DateTime.Now.AddDays(-40),
             TarichDyun  = DateTime.Now.AddDays(-10),
             MgishArar  = "יעקב יעקבי",
             Mshiva  = "לאה כהן",
             YprVaada  = "ציון ציוני",
              Natzig  = "אילה לוי",
              Status  = enumStatus.sagur
             },
        ];
        return listTikim;
    }

    [HttpPost("open")]
    public async Task<IActionResult> OpenCase([FromBody] TikModel tikModel)
    {
        var tikId = await _caseService.OpenCaseAsync(tikModel);
        return Ok(new { tikId = tikId });
    }
}