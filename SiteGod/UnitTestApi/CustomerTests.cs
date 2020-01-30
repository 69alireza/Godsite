using ApiSiteGod;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace UnitTestApi
{
    [TestClass]
    public class CustomerTests
    {
        private HttpClient _Client;
        public CustomerTests()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _Client = server.CreateClient();
        }
        [TestMethod]
        public void CustomerGetAllTest()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/Api/userss");

            var response = _Client.SendAsync(request).Result;

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        [DataRow(1010)]
        public void CustomerGetAllTest1(int id)
        {
            var request = new HttpRequestMessage(new HttpMethod("Get"),$"/api/userss/{id}");
            var response = _Client.SendAsync(request).Result;

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
