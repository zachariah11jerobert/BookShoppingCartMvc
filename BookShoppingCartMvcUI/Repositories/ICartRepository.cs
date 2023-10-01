﻿namespace BookShoppingCartMvcUI.Repositories
{
    public interface ICartRepository
    {
        Task<int> AddItem(int bookId, int qty);
        Task<int> RemoveItem(int bookId);
        Task<IEnumerable<ShoppingCart>> GetUserCart();
        Task<int> GetCartItemCount(string userId = "");
        Task<int> GetCart(string userId);

    }
}
