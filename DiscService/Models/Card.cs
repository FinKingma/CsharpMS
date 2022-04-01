using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DiscService
{
    public enum CardColor
    {
        BLUE,
        GREEN,
        YELLOW,
        RED
    }
    public class Card
    {
        public CardColor Color {
            get; set;
        }
        public string Text { get; set; }
        public int Id { get; set; }

        public Card(int id, CardColor color, string text) {
            Id = id;
            Color = color;
            Text = text;
        }
    }
}
