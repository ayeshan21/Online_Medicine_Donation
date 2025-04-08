using Microsoft.EntityFrameworkCore;
using Online_Medicine_Donation.Areas.NGO.Models;
using Online_Medicine_Donation.Areas.User.Models;

namespace Online_Medicine_Donation.Data
{
    public class OnlineMedicineContext : DbContext
    {
        public OnlineMedicineContext(DbContextOptions<OnlineMedicineContext> options)
            : base(options)
        {

        }
    }

}
