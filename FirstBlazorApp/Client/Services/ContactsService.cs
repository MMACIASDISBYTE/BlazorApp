using FirstBlazorApp.Shared;
using System.Net.Http.Json;

namespace FirstBlazorApp.Client.Services
{
    public class ContactsService : IContactsService
    {
        private readonly HttpClient _httpClient; //metodo desde que nos permite http request desde el codigo

        public ContactsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Contact>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Contact>>($"api/contacts");
        }

        public async Task<Contact> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Save(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
