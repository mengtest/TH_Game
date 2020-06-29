using System.Collections.Generic;
using System.Threading.Tasks;
using com.unity.cloudbase;

namespace CloudBase
{
    public class CloudBase
    {
        public static async Task Init()
        {
            CloudBaseApp app = CloudBaseApp.Init("env-hfrygbiu", 3000);
            AuthState state = await app.Auth.GetAuthStateAsync();
            if (state == null) {
                await app.Auth.SignInAnonymouslyAsync();
            }

            // 调用云函数
            var param = new Dictionary<string, dynamic>() { {"a", 1}, {"b", 2} };
            FunctionResponse res = await app.Function.CallFunctionAsync("add", param);
        }
    }
}