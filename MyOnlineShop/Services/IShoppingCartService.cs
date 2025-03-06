using System.Collections.Generic;
using MyOnlineShop.ViewModels;

namespace MyOnlineShop.Services
{
    public interface IShoppingCartService
    {
        ShoppingCartViewModel GetShoppingCart(string cartId); // سبد خرید بر اساس شناسه سبد خرید (می‌تواند Cookie یا Session باشد)
        void AddItemToCart(string cartId, int productId, int quantity);
        void UpdateCartItemQuantity(string cartId, int cartItemId, int quantity);
        void RemoveItemFromCart(string cartId, int cartItemId);
        void ClearShoppingCart(string cartId);
    }
}
