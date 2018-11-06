using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using BTCU.Models;
using System.Threading.Tasks;

namespace BTCU
{
    public static class ApiBTCU
    {
        static RestClient client = new RestClient(new Uri("https://dev.client.btcu.ddev.pw/api/"));
        public async static Task<LoginResponseModel> Login(LoginRequestModel reqData)
        {
            client.CookieContainer = new System.Net.CookieContainer();
            var request = new RestRequest("login", Method.POST);
            request.AddJsonBody(reqData);
            var resp = await client.ExecuteAsync<LoginResponseModel>(request);
            return (resp).Data;
        }

        public async static Task<List<OperationsModel>> Operations()
        {
            var request = new RestRequest("operations", Method.GET);
            return (await client.ExecuteAsync<List<OperationsModel>>(request)).Data;
        }

        public async static Task<UserModel> User()
        {
            var request = new RestRequest("user", Method.GET);
            //request.AddJsonBody(reqData);
            var resp = await client.ExecuteAsync<UserModel>(request);
            return (resp).Data;
        }
    }
}
