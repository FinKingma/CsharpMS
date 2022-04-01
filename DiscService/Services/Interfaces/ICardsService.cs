namespace DiscService.Services.Interfaces
{
    public interface ICardsService
    {
        List<Card> getAll();
        Card getRandom();
        Card draw();
        Card getCard(int id);

        void addCard(Card card);
    }
}
