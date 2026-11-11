namespace Discr.Services
{
    public interface IApiProvider
    {
        Task<string> GetAsync(string url);
    }
}