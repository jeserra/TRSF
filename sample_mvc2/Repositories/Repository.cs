using System.Collections.Generic;
using sample_mvc2.Models;
namespace sample_mvc2.Repositories
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();

        public static IEnumerable<GuestResponse> Responses => responses;

        public static void AddResponse (GuestResponse response)
        {
            responses.Add(response);
        }
    }
}