using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RestSharp;
using System.Threading.Tasks;

namespace BTCU
{
    public static class RestClientExtensions
    {
        public static async System.Threading.Tasks.Task<IRestResponse<T>> ExecuteAsync<T>(this RestClient client, RestRequest request) where T : new()
        {
            TaskCompletionSource<IRestResponse<T>> taskCompletion = new TaskCompletionSource<IRestResponse<T>>();
            RestRequestAsyncHandle handle = client.ExecuteAsync<T>(request, r => taskCompletion.SetResult(r));
            return (IRestResponse<T>)(await taskCompletion.Task);
        }

        public static async System.Threading.Tasks.Task<IRestResponse> ExecuteAsync(this RestClient client, RestRequest request)
        {
            TaskCompletionSource<IRestResponse> taskCompletion = new TaskCompletionSource<IRestResponse>();
            RestRequestAsyncHandle handle = client.ExecuteAsync(request, r => taskCompletion.SetResult(r));
            return (IRestResponse)(await taskCompletion.Task);
        }
    }
}