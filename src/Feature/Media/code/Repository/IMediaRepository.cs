using FordIndia.Feature.Media.Models;

namespace FordIndia.Feature.Media.Repository
{
    public interface IMediaRepository
    {
        Carousel GetCarouseItems();
    }
}
