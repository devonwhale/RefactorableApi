using RefactorableApi.Models;

namespace RefactorableApi.Managers
{
    public interface BasketInterface
    {
        BasketContents Get(string basketId);

        BasketContents Delete(string basketId, string itemId);
    }
}
