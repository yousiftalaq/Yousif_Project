using Microsoft.AspNetCore.Mvc;
using Yousif_DataAccess.Repository.IRepository;

namespace Yousif_Project.Controllers
{
    public class InquiryController : Controller
    {
        private readonly IInquiryHeaderRepository _inqHRepo;

        private readonly IInquiryDetailRepository _inqDRepo;

        public InquiryController(IInquiryHeaderRepository inqHRepo, IInquiryDetailRepository inqDRepo)
        {
            _inqHRepo = inqHRepo;
            _inqDRepo = inqDRepo;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
