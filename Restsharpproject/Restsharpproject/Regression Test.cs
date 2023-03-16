using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace APIDemo



{
    public class Demo<t>
    {
        public ListOfUserDTO GetUsers(string endpoint)
        {



            var user = new APIHelper<ListOfUserDTO>();   //Need to pass the baseUrl
            var url = user.SetUrl(endpoint);     //need to add Endpoint("/api/users?/page=2")
           
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            ListOfUserDTO content = user.GetContent<ListOfUserDTO>(response);
            Console.WriteLine(((int)response.StatusCode) + " (" + response.StatusCode.ToString() + ") ");
            Console.WriteLine(response.Content.ToString()); return content;
        }
        public CreateUsersDTO postUser(string endpoint, dynamic payload)
        {
            var user = new APIHelper<CreateUsersDTO>();
            var url = user.SetUrl("api/users");
            var request = user.CreatePostRequest(payload);
            var response = user.GetResponse(url, request);
            CreateUsersDTO content = user.GetContent<CreateUsersDTO>(response); Console.WriteLine(response.StatusCode.ToString()); Console.WriteLine(response.Content.ToString()); return content;
        }
        public CreateUsersDTO putuser(string endpoint, dynamic payload)
        {
            var user = new APIHelper<CreateUsersDTO>();
            var url = user.SetUrl("api/users/2");
            var request = user.CreatePutRequest(payload);
            var response = user.GetResponse(url, request);
            CreateUsersDTO content = user.GetContent<CreateUsersDTO>(response);
            Console.WriteLine(response.StatusCode.ToString() + " " + response.Content.ToString());
            return content;
        }
        public CreateUsersDTO Delusers(string endpoint)
        {
            var user = new APIHelper<CreateUsersDTO>(); 
            var url = user.SetUrl("api/users"); 
            var request = user.CreateDelRequest(); 
            var response = user.GetResponse(url, request); 
            CreateUsersDTO content = user.GetContent<CreateUsersDTO>(response); 
            Console.WriteLine(((int)response.StatusCode)); 
            Console.WriteLine(response.StatusCode.ToString() + " " + response.Content.ToString()); 
            return content;
            


        }
    }
}