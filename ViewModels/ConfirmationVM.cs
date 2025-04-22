using ShelburneMemorialWeb.Models;
namespace ShelburneMemorialWeb.ViewModels
{
    public class ConfirmationVM
    {
        public string OrderNumber { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string ConfirmationFirstName { get; set; }
        public string ConfirmationLastName { get; set; }

        public string ConfirmationFamilyName { get; set; }
        public string ConfirmationAddress { get; set; }
        public string ConfirmationNameofDeceased { get; set; }
    }
}
