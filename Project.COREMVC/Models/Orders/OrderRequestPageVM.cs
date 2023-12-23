using Project.COREMVC.Models.OuterRequestModels;
using Project.ENTITES.Models;

namespace Project.COREMVC.Models.Orders
{
    public class OrderRequestPageVM
    {
        public Order Order { get; set; }
        public PaymentRequestModel PaymentRequestModel { get; set; }
    }
}
