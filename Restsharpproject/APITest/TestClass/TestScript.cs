using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using APIDemo;
using NUnit.Framework;



namespace APITest.TestClass
{
    
    public class TestClass
    {
       
        [Test]
        public void GetUser()
        {
            var demo = new Demo<ListOfUserDTO>();
            var user = demo.GetUsers("api/user?page=2");
            Assert.AreEqual(2, user.page);
            Assert.AreEqual("sand dollar", user.data[0].name);
        }
        [Test]
        public void Postusers()
        {
            string payload = @"{
                              ""name"":""George ""                             
                               ""job"":""Bluth"" }";
            var demo = new Demo<CreateUsersDTO>();
            var user = demo.postUser("api/users", payload);

        }
        [Test]
        public void putuser()
        {
            string payload = @"{
                                ""name"":""Janet"",
                               ""job"":""Weaver"" }";
            var demo = new Demo<CreateUsersDTO>();
            var user = demo.putuser("api/users/2", payload);

        }
       
        [Test]
        public void Deluser()
        {
            var Demo = new Demo<CreateUsersDTO>();
            var user = Demo.Delusers("api/users");
        }
    }
}


