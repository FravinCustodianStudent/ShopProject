using System.Linq;
using Fravin_DataAccess.Repository.IRepository;
using Fravin_Models.ViewModels;
using Fravin_Utility;
using Fravin_Utility.BrainTree;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fravin.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderHeaderRepository _orderHRepo;
        private readonly IOrderDetailRepository _orderDRepo;
        private readonly IBrainTreeGate _brain;
        public OrderController(
            IOrderHeaderRepository orderHRepo, IOrderDetailRepository orderDRepo,
            IBrainTreeGate brain)
        {
            _orderDRepo = orderDRepo;
            _orderHRepo = orderHRepo;
            _brain = brain;
        }
        public IActionResult Index()
        {
            OrderListVM orderListVM = new OrderListVM()
            {
                OrderHList = _orderHRepo.GetAll(),
                StatusList = WC.listStatus.ToList().Select(i=> new SelectListItem()
                {
                    Text=i,
                    Value = i
                })
            };
            return View(orderListVM);
        }
    }
}
