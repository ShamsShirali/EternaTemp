using EternaTempl.Models;

namespace EternaTempl.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Feature> Features { get; set; }
        public IEnumerable<Card> Cards { get; set; }
    }
}
