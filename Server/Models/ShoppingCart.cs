using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string UserId { get; set; }       

        ICollection<CartItem> CartItems { get; set; }

        [NotMapped]
        public double CartTotal { get; set; }
        [NotMapped]
        public string StripePaymentIntentId { get; set; }
        [NotMapped]
        public string ClientSecret { get; set; }

    }        
}
