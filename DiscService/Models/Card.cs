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

        public Card(CardColor color, string text) { 
            Color = color;
            Text = text;
        }
    }
}
